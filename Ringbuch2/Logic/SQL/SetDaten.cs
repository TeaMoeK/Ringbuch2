﻿using Logging_APE;
using Ringbuch2.Logic.SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace Ringbuch2
{
  class SetDaten
  {
    private string _sqliteDatabase;
    private SQLiteConnection _con;
    private SQLiteCommand _command;
    private SQLiteDataReader _dataReader;
    private GetDaten _getDaten = new GetDaten();
    private MyDialog _myDialog;
    private bool _showMsgBoxes = true;
    private bool _isAdmin = false;

    //private const string aes_key = "TimoistDerCoolsteDerCoolenDigger";  //32
    //private const string aes_iv = "EineKetteVonkeys";   //16

    public SetDaten(bool showMsgBoxes)
    {
      _showMsgBoxes = showMsgBoxes;
    }
    public SetDaten()
    {
      //if (!Debugger.IsAttached)
      //{
      //    _showMsgBoxes = false;
      //}
    }
    private void DoConnect()
    {
      if (_con == null)
      {
        _con = SqliteCon.Con;
      }
      //try
      //{
      //  getDatabasePath();
      //  _con = new SQLiteConnection();
      //  _con.ConnectionString = "Data Source=" + _sqliteDatabase;
      //  _con.SetPassword(_getDaten.DatabasePW);        
      //  _con.Open();
      //  _command = new SQLiteCommand(_con);
      //  _command.CommandText = "SELECT * FROM Personen";
      //  _command.ExecuteNonQuery();
      //}
      //catch (Exception ex)
      //{
      //  writeLog("SQL-Verbindung ist fehlgeschlagen. Exception: " + ex.Message + " Methode: " + MethodBase.GetCurrentMethod().ToString());
      //  MessageBox.Show(ex.Message);
      //  Environment.Exit(-1);
      //}
    }
    public void ClearDBPW(string pw)
    {
      try
      {
        getDatabasePath();
        _con = new SQLiteConnection();
        _con.ConnectionString = "Data Source=" + _sqliteDatabase;
        _con.SetPassword(pw);
        _con.Open();
        _command = new SQLiteCommand(_con);
        _command.CommandText = "";
        _command.ExecuteNonQuery();
        clearPW();
      }
      catch (Exception ex)
      {
        writeLog("SQL-Verbindung ist fehlgeschlagen. Exception: " + ex.Message + " Methode: " + MethodBase.GetCurrentMethod().ToString());
        MessageBox.Show(ex.Message);
        Environment.Exit(-1);
      }
    }
    private void clearPW()
    {
      _con.ChangePassword("");
      Environment.Exit(-1);
    }
    private void writeLog(string logText)
    {
      Log.Instance.FILENAME_SUFFIX = "Ringbuch";
      Log.Instance.Write(logText, typeof(Program).ToString());
    }
    private void getDatabasePath()
    {
      XmlDocument xml = new XmlDocument();
      if (File.Exists(Directory.GetCurrentDirectory() + "\\ringbuch.xml"))
      {
        xml.Load(Directory.GetCurrentDirectory() + "\\ringbuch.xml");
        XmlNode node = xml.DocumentElement.SelectSingleNode("/Datenbank/Pfad");
        _sqliteDatabase = node.InnerText;
      }
      else
      {
        writeLog("Es ist ein Fehler mit der xml-Datei aufgetreten! Methode: " + MethodBase.GetCurrentMethod().ToString());
        MessageBox.Show("Es ist ein Fehler mit der xml-Datei aufgetreten!");
      }
    }
    public void CreateNewDatabase()
    {
      FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
      folderBrowser.ShowDialog();

    }
    public void SetPassword()
    {
      if (PasswortAbfrage())
      {
        _myDialog = new MyDialog(true, "Passwort", "Bitte ein Passwort eingeben.", true);
        _myDialog.ShowDialog();
        if (_myDialog.OK)
        {
          SetAdminPasswordToDatabase(_myDialog.codedText);
          MessageBox.Show("Das Passwort wurde geändert.", "Passwort");
          writeLog("Das Passwort wurde geändert." + " Methode: " + MethodBase.GetCurrentMethod().ToString());
        }
      }
    }
    public void SetAdminPasswordToDatabase(string password)
    {
      DoConnect();
      _command = new SQLiteCommand(_con);
      _command.CommandText = CreateUpdateStatement("Verschiedenes", "Password", password);
      _dataReader = _command.ExecuteReader();
      StatementSuccessful(_dataReader, false);

    }
    public void SetDatabase()
    {
      if (PasswortAbfrage())
      {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "SQLite-Datenbank | *.db";
        openFileDialog.Title = "Select Database";
        openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          XMLDateiBeschreiben("Datenbank", "Pfad", openFileDialog.FileName);
        }
      }
    }

    public void SetDatenbankPassword(string codedPassword)
    {
      XMLDateiBeschreiben("Datenbank", "DatenbankPasswort", codedPassword);
    }
    private void XMLDateiBeschreiben(string node1, string node2, string text)
    {
      //if (PasswortAbfrage())
      //{
      XmlDocument doc = new XmlDocument();
      doc.Load("Ringbuch.xml");
      XmlNode docNode = doc.SelectSingleNode("/" + node1 + "/" + node2);
      docNode.InnerText = text;
      doc.Save("Ringbuch.xml");
      getDatabasePath();
      if (_showMsgBoxes)
      {
        MessageBox.Show("Die Eintrage für '" + node2 + "' wurde geändert.", node2 + " ändern");
      }
      //}
    }
    /// <summary>
    /// Passwortabfrage. Im Debuggerbetrieb abgeschaltet
    /// </summary>
    /// <returns></returns>
    private Boolean PasswortAbfrage()
    {
      if (!_isAdmin)
      {
        _myDialog = new MyDialog(true, "Password", "Für diese Aktion ist ein Passwort erforderlich");
        _myDialog.ShowDialog();
        if (_getDaten.getPassword() == _myDialog.text)
        {
          return true;
        }
        else
        {
          if (!_myDialog.Abbrechen)
          {
            MessageBox.Show("Das Passwort ist falsch.", "Falsches Passwort");
            writeLog("Das Passwort wurde falsch eingegeben. Methode: " + MethodBase.GetCurrentMethod().ToString());
          }
          return false;
        }
      }
      else
      {
        return true;
      }
    }
    public bool SetAdminMode()
    {
      if (!_isAdmin)
      {
        _myDialog = new MyDialog(true, "Password", "Für diese Aktion ist ein Passwort erforderlich");
        _myDialog.ShowDialog();
        if (_getDaten.getPassword() == _myDialog.text)
        {
          _isAdmin = true;
          return _isAdmin;
        }
        return _isAdmin;
      }
      else
      {
        _isAdmin = false;
        return _isAdmin;
      }
    }
    public void SetSchiessartenDelete(int schiessartID)
    {
      if (PasswortAbfrage())
      {
        if (MessageBox.Show("Soll der Eintrag wirklich gelöscht werden?", "Schiessart löschen", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          DoConnect();
          _command = new SQLiteCommand(_con);
          _command.CommandText = CreateSelectStatement("Ergebnisse", "SchiessArtenID", schiessartID.ToString());
          _dataReader = _command.ExecuteReader();
          if (_dataReader.HasRows)
          {
            MessageBox.Show("Es wurden Abhängigkeiten gefunden. Der Eintrag kann nicht archiviert werden.");
            writeLog("Es wurden Abhängigkeiten gefunden. Die SchiessArt mit der ID " + schiessartID + " kann nicht archiviert werden.");
          }
          else
          {
            _command = new SQLiteCommand(_con);
            _command.CommandText = CreateArchivStatement("SchiessArten", schiessartID.ToString());
            _dataReader = _command.ExecuteReader();
            if (!StatementSuccessful(_dataReader, true))
            {
              writeLog("Die SchiessArt mit der ID " + schiessartID + " konnte nicht archiviert werden.");
            }
            else
            {
              writeLog("Die Schießart mit der ID " + schiessartID + " wurde archiviert.");
            }
          }
        }

      }
    }
    //  Alte Methode
    //public void SetSchiessartenNeu(string schiessart)
    //{
    //  List<string> neueSchiessarten = schiessart.Split(',').ToList();
    //  List<string> alteScheissarten = _getDaten.getSchiessArten();
    //  List<string> newList = new List<string>(neueSchiessarten.Count + alteScheissarten.Count);
    //  newList.AddRange(neueSchiessarten);
    //  newList.AddRange(alteScheissarten);

    //  string schiessarten = "";

    //  foreach (string item in newList)
    //  {
    //    if (item.Trim() != "")
    //    {
    //      schiessarten += item.Replace(" ", "") + ",";
    //    }
    //  }
    //  schiessarten = schiessarten.Remove(schiessarten.Length - 1, 1);
    //  schiessartenUpdate(schiessarten, false);
    //}

    public void SetSchiessartenNeu(string schiessart)
    {
      List<string> neueSchiessarten = schiessart.Split(',').ToList();

      foreach (string item in neueSchiessarten)
      {
        schiessartenInsert(item.Trim());
      }
    }

    private void schiessartenInsert(string schiessart)
    {
      DoConnect();
      _command = new SQLiteCommand(_con);
      _command.CommandText = CreateInsertIntoStatement("SchiessArten", "SchiessArt, IstArchiviert", "'" + schiessart + "', 0");
      _dataReader = _command.ExecuteReader();
      if (!StatementSuccessful(_dataReader, false))
      {
        writeLog("Statement war nicht erfolgreich. Statement: " + _command.CommandText.ToString() + " Methode: " + MethodBase.GetCurrentMethod().ToString());
      }

    }
    //  Alte Delete Methode
    //private void schiessartenDelete(string schiessart)
    //{
    //  DoConnect();
    //  _command = new SQLiteCommand(_con);
    //  _command.CommandText = CreateDeleteStatement("", -1);
    //  _dataReader = _command.ExecuteReader();
    //  if (!StatementSuccessful(_dataReader, true))
    //  {
    //    writeLog("Statement war nicht erfolgreich. Statement: " + _command.CommandText.ToString() + " Methode: " + MethodBase.GetCurrentMethod().ToString());
    //  }
    //  
    //}
    private void schiessartenUpdate(int schiessartenID)
    {
      throw new NotImplementedException();
    }

    public void SetSchFest(DateTime dt)
    {
      bool setDate = true;
      TimeSpan timeSpan = DateTime.Now - dt;

      if (timeSpan.Days > 0)
      {
        if (MessageBox.Show("Das Datum liegt in der Vergangenheit.", "Schützenfest", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.Cancel)
        {
          setDate = false;
        }
      }

      if (setDate)
      {
        DoConnect();
        _command = new SQLiteCommand(_con);
        _command.CommandText = CreateUpdateStatement("Verschiedenes", "Schuetzenfest", dt.ToString("yyyy-MM-dd"));
        _dataReader = _command.ExecuteReader();
        if (!StatementSuccessful(_dataReader, false))
        {
          writeLog("Der Versuch, das Datum des Schützenfestes zu ändern, ist fehlgeschlagen. " + _command.CommandText);
        }
        else
        {
          writeLog("Das Datum des Schützenfestes wurde auf den " + dt.ToString("yyy-MM-dd") + " gesetzt.");
        }

      }
    }
    public void DeleteErgebnis(int id)
    {
      if (PasswortAbfrage())
      {
        DialogResult result = MessageBox.Show("Ergebnis löschen?", "Löschen", MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
        {
          DoConnect();
          _command = new SQLiteCommand(_con);
          _command.CommandText = CreateDeleteStatement("Ergebnisse", id);
          _dataReader = _command.ExecuteReader();
          if (!StatementSuccessful(_dataReader, true))
          {
            writeLog("Das Löschen des Ergebnisses mit der ID: " + id + " war nicht erfolgreicht.");
          }
          else
          {
            writeLog("Das Ergebnisses mit der ID: " + id + " wurde gelöscht.");
          }

        }
      }
    }
    public bool UpdateErgebnis(DataTable dt)
    {
      if (CheckErgebnis(dt))
      {
        DoConnect();
        _command = new SQLiteCommand(_con);
        _command.CommandText = CreateUpdateStatement(
            "Ergebnisse",
            "Datum = '" + dt.Rows[0]["Datum"] + "', " +
            "\"Satz1\" = '" + dt.Rows[0]["Satz1"] + "', " +
            "\"Satz2\" = '" + dt.Rows[0]["Satz2"] + "', " +
            "\"Satz3\" = '" + dt.Rows[0]["Satz3"] + "', " +
            "\"Satz4\" = '" + dt.Rows[0]["Satz4"] + "', " +
            "SchiessArtenID = '" + dt.Rows[0]["SchiessArtenID"] + "', " +
            "Info = '" + dt.Rows[0]["Info"] + "'",
            "rowid", dt.Rows[0]["ErgebnisID"].ToString());
        try
        {
          _dataReader = _command.ExecuteReader();
          if (!StatementSuccessful(_dataReader, false))
          {
            writeLog("Das Update des Ergebnisses mit der ID: " + dt.Rows[0]["ErgebnisID"].ToString() + " war nicht erfolgreicht.");

            return false;
          }
          else
          {
            writeLog("Das Ergebnisses mit der ID: " + dt.Rows[0]["ErgebnisID"].ToString() + " wurde bearbeitet.");

            return true;
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Es ist ein Fehler beim Beschreiben der Datenbank aufgetreten.");
          writeLog("Es ist ein Fehler beim Beschreiben der Datenbank aufgetreten: " + ex.Message.ToString() + "Methode: " + MethodBase.GetCurrentMethod().ToString());

          return false;
        }
      }
      else
      {
        return false;
      }
    }
    public bool CreateErgebnis(DataTable dt)
    {
      if (CheckErgebnis(dt))
      {
        DoConnect();
        _command = new SQLiteCommand(_con);
        _command.CommandText = CreateInsertIntoStatement(
            "Ergebnisse",
            "NamenID, Datum, \"Satz1\", \"Satz2\", \"Satz3\", \"Satz4\", SchiessArtenID, Info",
            "'" +
            dt.Rows[0]["NamenID"] + "', '" +
            dt.Rows[0]["Datum"] + "', '" +
            dt.Rows[0]["Satz1"] + "', '" +
            dt.Rows[0]["Satz2"] + "', '" +
            dt.Rows[0]["Satz3"] + "', '" +
            dt.Rows[0]["Satz4"] + "', '" +
            dt.Rows[0]["SchiessArtenID"] + "', '" +
            dt.Rows[0]["Info"] + "'"
            );
        _command.ExecuteNonQuery();

        return true;
      }
      else
      {
        return false;
      }
    }
    private Boolean CheckErgebnis(DataTable dt)
    {
      List<string> liste = new List<string>();
      liste.Add("Satz1");
      liste.Add("Satz2");
      liste.Add("Satz3");
      liste.Add("Satz4");
      string errorMessage = "";
      foreach (string satz in liste)
      {
        string test = dt.Rows[0][satz].ToString();
        if (Convert.ToDouble(dt.Rows[0][satz]) > 109 || Convert.ToDouble(dt.Rows[0][satz]) < 0)
        {
          errorMessage += "Der Eintrage in " + satz + " macht mit dem Wert " + Convert.ToDouble(dt.Rows[0][satz]) + " keinen Sinn." +
              Environment.NewLine;
        }
      }
      if (errorMessage != "")
      {
        errorMessage += "Es sind nur Werte zwischen 0.0 und 109 erlaubt.";
        writeLog(errorMessage);
        MessageBox.Show(errorMessage, "Fehler");
        return false;
      }
      else
      {
        return true;
      }
    }
    private List<string> getMaterialGruppen()
    {
      return _getDaten.getMaterialGruppen();
    }
    public bool SetProfilUpdate(DataTable dt)
    {
      if (PasswortAbfrage())
      {
        List<string> listMaterial = getMaterialGruppen();
        for (int i = 0; i < dt.Columns.Count - 1; i++)
        {
          if (listMaterial.Contains(dt.Columns[i].ToString().Replace("ID", ""))
              && dt.Columns[i].ToString().Substring(dt.Columns[i].ToString().Length - 2) == "ID"
              && dt.Rows[0][i].ToString() == "")
          {
            dt.Rows[0][i] = -1;
          }
        }
        if (CheckGeburtstag(Convert.ToDateTime(dt.Rows[0]["Geburtstag"].ToString()), MethodInfo.GetCurrentMethod().Name))
        {

          DoConnect();
          _command = new SQLiteCommand(_con);
          _command.CommandText = CreateUpdateStatement(
              "Personen",
              "Vorname = \"" + dt.Rows[0]["Vorname"] + "\", " +
              "Zweitname = \"" + dt.Rows[0]["Zweitname"] + "\", " +
              "Nachname = \"" + dt.Rows[0]["Nachname"] + "\", " +
              "Geburtstag = \"" + dt.Rows[0]["Geburtstag"] + "\", " +
              "Geschlecht = \"" + dt.Rows[0]["Geschlecht"] + "\", " +
              "DarfKK = \"" + dt.Rows[0]["DarfKK"] + "\", " +
              "DarfLG = \"" + dt.Rows[0]["DarfLG"] + "\", " +
              "IstKoenig = \"" + dt.Rows[0]["IstKoenig"] + "\", " +
              "KleinkaliberID = \"" + dt.Rows[0]["KleinkaliberID"] + "\", " +
              "LuftgewehrID = \"" + dt.Rows[0]["LuftgewehrID"] + "\", " +
              "PistoleID = \"" + dt.Rows[0]["PistoleID"] + "\", " +
              "HandschuhID = \"" + dt.Rows[0]["HandschuhID"] + "\", " +
              "JackeID = \"" + dt.Rows[0]["JackeID"] + "\", " +
              "Info = \"" + dt.Rows[0]["Info"] + "\"",
              "rowid",
              dt.Rows[0]["rowid"].ToString());

          try
          {
            _dataReader = _command.ExecuteReader();

            if (!StatementSuccessful(_dataReader, false))
            {
              writeLog("Der Eintrag konnte nicht geändert werden. Methode: " + MethodBase.GetCurrentMethod().ToString());
              return false;
            }
            writeLog("Das Profil mit der ID" + dt.Rows[0]["rowid"] + " wurde bearbeitet");
            return true;
          }
          catch (Exception ex)
          {
            MessageBox.Show("Es ist ein Fehler beim Beschreiben der Datenbank aufgetreten.");
            writeLog("Es ist ein Fehler beim Beschreiben der Datenbank aufgetreten: " + ex.Message.ToString() + "Methode: " + MethodBase.GetCurrentMethod().ToString());

          }
        }
      }
      return false;
    }
    public bool SetProfilNeu(DataTable dt)
    {
      if (PasswortAbfrage())
      {
        if (CheckGeburtstag(Convert.ToDateTime(dt.Rows[0]["Geburtstag"].ToString()), MethodInfo.GetCurrentMethod().Name))
        {
          DoConnect();
          _command = new SQLiteCommand(_con);
          _command.CommandText = CreateInsertIntoStatement(
              "Personen",
              "AdressID, Vorname, Zweitname, Nachname, Geburtstag, Geschlecht, DarfKK, DarfLG, KleinkaliberID, LuftgewehrID, JackeID, HandschuhID, Info, IstKoenig, IstArchiviert, PistoleID",
              "'" + dt.Rows[0]["AdressID"] + "', " +
              "'" + dt.Rows[0]["Vorname"] + "', " +
              "'" + dt.Rows[0]["Zweitname"] + "', " +
              "'" + dt.Rows[0]["Nachname"] + "', " +
              "'" + dt.Rows[0]["Geburtstag"] + "', " +
              "'" + dt.Rows[0]["Geschlecht"] + "', " +
              "'" + dt.Rows[0]["DarfKK"] + "', " +
              "'" + dt.Rows[0]["DarfLG"] + "', " +
              "'" + dt.Rows[0]["KleinkaliberID"] + "', " +
              "'" + dt.Rows[0]["LuftgewehrID"] + "', " +
              "'" + dt.Rows[0]["JackeID"] + "', " +
              "'" + dt.Rows[0]["HandschuhID"] + "', " +
              "'" + dt.Rows[0]["Info"] + "', " +
              "'" + dt.Rows[0]["IstKoenig"] + "', " +
              "'" + dt.Rows[0]["PistoleID"] + "', " +
              "'0'"   //  IstArchiviert
              );
          _dataReader = _command.ExecuteReader();

          if (!StatementSuccessful(_dataReader, false))
          {
            writeLog("Statement war nicht erfolgreich. Methode: SetProfilNeu(DataTable dt) Statement: " + _command.CommandText.ToString());
            return false;
          }
          writeLog("Ein Neues Profil unter dem Namen " + dt.Rows[0]["Vorname"] + " " + dt.Rows[0]["Nachname"] + " wurde angelegt");
          return true;
        }
      }
      return false;
    }
    private bool CheckGeburtstag(DateTime geburtstag, object sender)
    {
      TimeSpan timeSpan = DateTime.Now - geburtstag;
      if (timeSpan.Days < 0)
      {
        if (MessageBox.Show("Das Datum liegt in der Zukunft.", "Geburtstag", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
        {

          return false;
        }
      }
      else
      {
        int alter = Convert.ToInt16(DateTime.Now.ToString("yyyy")) - geburtstag.Year;
        if (alter <= 5)
        {
          if (MessageBox.Show("Das Alter ist unter 6 Jahre.", "Alter", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
          {
            return false;
          }
        }
      }
      return true;
    }
    public void SetProfilDelete(int ID)
    {
      if (PasswortAbfrage())
      {
        if (DeleteProfilRequested("Profil löschen"))
        {
          DoConnect();
          _command = new SQLiteCommand(_con);
          _command.CommandText = CreateDeleteStatement("Personen", ID);
          _dataReader = _command.ExecuteReader();
          if (!StatementSuccessful(_dataReader, true))
          {
            writeLog("Statement war nicht erfolgreich. Statement: " + _command.CommandText.ToString() + "Methode: " + MethodBase.GetCurrentMethod().ToString());
          }
          else
          {
            writeLog("Das Profil mit der ID:" + ID + " wurde archiviert");
          }

        }
      }
    }
    private bool DeleteProfilRequested(string titelText)
    {
      DialogResult result = MessageBox.Show("Soll der Eintrag wirklich gelöscht werden?", titelText, MessageBoxButtons.YesNo);

      if (result == DialogResult.Yes)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    private bool StatementSuccessful(SQLiteDataReader dataReader, bool delete)
    {
      if (dataReader != null)
      {
        if (dataReader.RecordsAffected > 0)
        {
          if (delete)
          {
            if (_showMsgBoxes)
            {
              MessageBox.Show("Löschen erfolgreich.");
            }

            return true;
          }
          else
          {
            if (_showMsgBoxes)
            {
              MessageBox.Show("Eintrag erfolgreich.");
            }

            return true;
          }

        }
        else
        {
          if (delete)
          {
            MessageBox.Show("Eintrag konnte nicht gelöscht werden.");
            return false;
          }
          else
          {
            MessageBox.Show("Eintrag konnte nicht erstellt werden.");
            return false;
          }
        }
      }
      else
      {
        MessageBox.Show("Vorgang war nicht erfolgreicht.");
        return false;
      }

    }
    public void SetMaterialInsert(DataTable dt)
    {
      if (dt != null)
      {
        if (!dt.Rows[0]["Bezeichnung"].ToString().ToLower().Contains("n/a") && dt.Rows[0]["Bezeichnung"].ToString().ToLower().Trim() != "")
        {
          DoConnect();
          _command = new SQLiteCommand(_con);
          _command.CommandText = CreateInsertIntoStatement(
              "Material",
              "Gruppe, Bezeichnung, Langtext, Groesse",
              "'" + dt.Rows[0]["Gruppe"].ToString() + "', " +
              "'" + dt.Rows[0]["Bezeichnung"].ToString() + "', " +
              "'" + dt.Rows[0]["Langtext"].ToString() + "', " +
              "'" + dt.Rows[0]["Groesse"].ToString() + "'");
          _dataReader = _command.ExecuteReader();
          if (!StatementSuccessful(_dataReader, false))
          {
            writeLog("Statement war nicht erfolgreich. Statement: " + _command.CommandText.ToString() + "Methode: " + MethodBase.GetCurrentMethod().ToString());
          }

        }
        else
        {
          MessageBox.Show(
              "Die Bezeichnung ist ungültig!" + Environment.NewLine +
              "Die darf nicht 'N/A' oder leer sein.", "Material");
        }
      }
    }
    public void SetMaterialUpdate(DataTable dt)
    {
      if (dt != null)
      {
        if (!dt.Rows[0]["Bezeichnung"].ToString().ToLower().Contains("n/a") && dt.Rows[0]["Bezeichnung"].ToString().ToLower().Trim() != "")
        {
          DoConnect();
          _command = new SQLiteCommand(_con);
          _command.CommandText = CreateUpdateStatement(
              "Material",
              "Bezeichnung = '" + dt.Rows[0]["Bezeichnung"] + "', " +
              "Langtext = '" + dt.Rows[0]["Langtext"] + "', " +
              "Groesse = '" + dt.Rows[0]["Groesse"] + "'",
              "rowid", dt.Rows[0]["rowid"].ToString());
          _dataReader = _command.ExecuteReader();
          if (!StatementSuccessful(_dataReader, false))
          {
            writeLog("Statement war nicht erfolgreich. Statement: " + _command.CommandText.ToString() + "Methode: " + MethodBase.GetCurrentMethod().ToString());
          }

        }
      }
    }
    public void SetMaterialDelete(int id)
    {
      if (PasswortAbfrage())
      {
        if (DeleteProfilRequested("Material löschen"))
        {
          if (id > 8)
          {
            DoConnect();
            _command = new SQLiteCommand(_con);
            _command.CommandText = CreateDeleteStatement("Material", id);
            _dataReader = _command.ExecuteReader();
            if (!StatementSuccessful(_dataReader, true))
            {
              writeLog("Statement war nicht erfolgreich. Statement: " + _command.CommandText.ToString() + " Methode: " + MethodBase.GetCurrentMethod().ToString());
            }
            else
            {
              writeLog("Es wurde ein Materialeintrag gelöscht." + Environment.NewLine + "Statement: " + _command.CommandText.ToString());
            }

          }
          else
          {
            writeLog("Es wurde versucht einen festen Material-Eintrag zu löschen. Statement: " + _command.CommandText.ToString());
            MessageBox.Show("Dieser Eintrag darf nicht gelöscht werden!", "Material");
          }
        }
      }
    }
    /// <summary>
    /// Update Statement
    /// </summary>
    /// <param name="dbTable"></param>
    /// <param name="dbColumn"></param>
    /// <param name="dbValue"></param>
    /// <returns></returns>
    private string CreateUpdateStatement(string dbTable, string dbColumn, string dbValue)
    {
      return "UPDATE " + dbTable + " SET " + dbColumn + " = '" + dbValue + "'";
    }
    /// <summary>
    /// Update Statement Einzelwert
    /// </summary>
    /// <param name="dbtable"></param>
    /// <param name="dbColumnAndValues"></param>
    /// <param name="dbWhere"></param>
    /// <param name="dbValue"></param>
    /// <returns></returns>
    private string CreateUpdateStatement(string dbtable, string dbColumnAndValues, string dbWhere, string dbValue)
    {
      return "UPDATE " + dbtable + " SET " + dbColumnAndValues + " WHERE " + dbWhere + " = " + dbValue;
    }
    /// <summary>
    /// Insert Into Statement viele Werte
    /// </summary>
    /// <param name="dbTable"></param>
    /// <param name="dbColumns"></param>
    /// <param name="dbValues"></param>
    /// <returns></returns>
    private string CreateInsertIntoStatement(string dbTable, string dbColumns, string dbValues)
    {
      return "INSERT INTO " + dbTable + "( " + dbColumns + " ) VALUES " + "( " + dbValues + " )";
    }
    /// <summary>
    /// Delete Statement
    /// </summary>
    /// <param name="dbTable">as string</param>
    /// <param name="dbRowid">as int</param>
    /// <returns></returns>
    private string CreateDeleteStatement(string dbTable, int dbRowid)
    {
      if (dbTable.ToLower() == "personen" || dbTable.ToLower() == "ergebnisse")
      {
        return "UPDATE " + dbTable + " SET IstArchiviert = 1 WHERE " + "rowid = " + dbRowid;
      }
      else
      {
        return "DELETE FROM " + dbTable + " WHERE rowid = " + dbRowid;
      }
    }
    private string CreateSelectStatement(string dbTable, string dbColumn, string dbValue)
    {
      return "SELECT * FROM " + dbTable + " WHERE " + dbColumn + " = '" + dbValue + "'";
    }
    private string CreateArchivStatement(string dbTable, string dbRowid)
    {
      return "UPDATE " + dbTable + " SET 'IstArchiviert' = 1 WHERE rowid = " + dbRowid;
    }
  }
}
