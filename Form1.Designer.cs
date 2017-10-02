namespace RBii
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.dgvPersonen = new System.Windows.Forms.DataGridView();
      this.personenBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.rBDataDataSet = new RBii.RBDataDataSet();
      this.personenTableAdapter = new RBii.RBDataDataSetTableAdapters.PersonenTableAdapter();
      this.tableAdapterManager = new RBii.RBDataDataSetTableAdapters.TableAdapterManager();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.namenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.satz1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.satz2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.satz3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.satz4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.schiessArtenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ScheissArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.infoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.istArchiviertDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.ergebnisseBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.rBDataErgebnisse = new RBii.RBDataErgebnisse();
      this.dataGridView3 = new System.Windows.Forms.DataGridView();
      this.MaterialGruppe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groesseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.langtextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.rBDataMaterial = new RBii.RBDataMaterial();
      this.materialTableAdapter = new RBii.RBDataMaterialTableAdapters.MaterialTableAdapter();
      this.tableAdapterManager2 = new RBii.RBDataMaterialTableAdapters.TableAdapterManager();
      this.ergebnisseTableAdapter = new RBii.RBDataErgebnisseTableAdapters.ErgebnisseTableAdapter();
      this.tableAdapterManager1 = new RBii.RBDataErgebnisseTableAdapters.TableAdapterManager();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ergebnisseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.adressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.zweitnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.geburtstagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.geschlechtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.darfKKDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.darfLGDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.kleinkaliberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.luftgewehrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.handschuhIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.jackeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pistoleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.istKoenigDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.istVizeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.istArchiviertDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPersonen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.personenBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rBDataDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ergebnisseBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rBDataErgebnisse)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rBDataMaterial)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgvPersonen
      // 
      this.dgvPersonen.AllowUserToAddRows = false;
      this.dgvPersonen.AllowUserToDeleteRows = false;
      this.dgvPersonen.AutoGenerateColumns = false;
      this.dgvPersonen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPersonen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.adressIDDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.zweitnameDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.geburtstagDataGridViewTextBoxColumn,
            this.geschlechtDataGridViewTextBoxColumn,
            this.darfKKDataGridViewCheckBoxColumn,
            this.darfLGDataGridViewCheckBoxColumn,
            this.kleinkaliberIDDataGridViewTextBoxColumn,
            this.luftgewehrIDDataGridViewTextBoxColumn,
            this.handschuhIDDataGridViewTextBoxColumn,
            this.jackeIDDataGridViewTextBoxColumn,
            this.pistoleIDDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn,
            this.istKoenigDataGridViewCheckBoxColumn,
            this.istVizeDataGridViewCheckBoxColumn,
            this.istArchiviertDataGridViewCheckBoxColumn});
      this.dgvPersonen.DataSource = this.personenBindingSource;
      this.dgvPersonen.Location = new System.Drawing.Point(12, 27);
      this.dgvPersonen.MultiSelect = false;
      this.dgvPersonen.Name = "dgvPersonen";
      this.dgvPersonen.ReadOnly = true;
      this.dgvPersonen.Size = new System.Drawing.Size(284, 690);
      this.dgvPersonen.TabIndex = 0;
      this.dgvPersonen.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonen_CellEnter);
      // 
      // personenBindingSource
      // 
      this.personenBindingSource.DataMember = "Personen";
      this.personenBindingSource.DataSource = this.rBDataDataSet;
      // 
      // rBDataDataSet
      // 
      this.rBDataDataSet.DataSetName = "RBDataDataSet";
      this.rBDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // personenTableAdapter
      // 
      this.personenTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.PersonenTableAdapter = this.personenTableAdapter;
      this.tableAdapterManager.UpdateOrder = RBii.RBDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // dataGridView2
      // 
      this.dataGridView2.AllowUserToAddRows = false;
      this.dataGridView2.AllowUserToDeleteRows = false;
      this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView2.AutoGenerateColumns = false;
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.namenIDDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.satz1DataGridViewTextBoxColumn,
            this.satz2DataGridViewTextBoxColumn,
            this.satz3DataGridViewTextBoxColumn,
            this.satz4DataGridViewTextBoxColumn,
            this.schiessArtenIDDataGridViewTextBoxColumn,
            this.ScheissArt,
            this.infoDataGridViewTextBoxColumn1,
            this.istArchiviertDataGridViewCheckBoxColumn1});
      this.dataGridView2.DataSource = this.ergebnisseBindingSource;
      this.dataGridView2.Location = new System.Drawing.Point(364, 183);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.ReadOnly = true;
      this.dataGridView2.Size = new System.Drawing.Size(632, 534);
      this.dataGridView2.TabIndex = 1;
      // 
      // iDDataGridViewTextBoxColumn1
      // 
      this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
      this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
      this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
      this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
      this.iDDataGridViewTextBoxColumn1.Visible = false;
      // 
      // namenIDDataGridViewTextBoxColumn
      // 
      this.namenIDDataGridViewTextBoxColumn.DataPropertyName = "NamenID";
      this.namenIDDataGridViewTextBoxColumn.HeaderText = "NamenID";
      this.namenIDDataGridViewTextBoxColumn.Name = "namenIDDataGridViewTextBoxColumn";
      this.namenIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.namenIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // datumDataGridViewTextBoxColumn
      // 
      this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
      this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
      this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
      this.datumDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // satz1DataGridViewTextBoxColumn
      // 
      this.satz1DataGridViewTextBoxColumn.DataPropertyName = "Satz1";
      this.satz1DataGridViewTextBoxColumn.HeaderText = "Satz1";
      this.satz1DataGridViewTextBoxColumn.MinimumWidth = 50;
      this.satz1DataGridViewTextBoxColumn.Name = "satz1DataGridViewTextBoxColumn";
      this.satz1DataGridViewTextBoxColumn.ReadOnly = true;
      this.satz1DataGridViewTextBoxColumn.Width = 50;
      // 
      // satz2DataGridViewTextBoxColumn
      // 
      this.satz2DataGridViewTextBoxColumn.DataPropertyName = "Satz2";
      this.satz2DataGridViewTextBoxColumn.HeaderText = "Satz2";
      this.satz2DataGridViewTextBoxColumn.MinimumWidth = 50;
      this.satz2DataGridViewTextBoxColumn.Name = "satz2DataGridViewTextBoxColumn";
      this.satz2DataGridViewTextBoxColumn.ReadOnly = true;
      this.satz2DataGridViewTextBoxColumn.Width = 50;
      // 
      // satz3DataGridViewTextBoxColumn
      // 
      this.satz3DataGridViewTextBoxColumn.DataPropertyName = "Satz3";
      this.satz3DataGridViewTextBoxColumn.HeaderText = "Satz3";
      this.satz3DataGridViewTextBoxColumn.MinimumWidth = 50;
      this.satz3DataGridViewTextBoxColumn.Name = "satz3DataGridViewTextBoxColumn";
      this.satz3DataGridViewTextBoxColumn.ReadOnly = true;
      this.satz3DataGridViewTextBoxColumn.Width = 50;
      // 
      // satz4DataGridViewTextBoxColumn
      // 
      this.satz4DataGridViewTextBoxColumn.DataPropertyName = "Satz4";
      this.satz4DataGridViewTextBoxColumn.HeaderText = "Satz4";
      this.satz4DataGridViewTextBoxColumn.MinimumWidth = 50;
      this.satz4DataGridViewTextBoxColumn.Name = "satz4DataGridViewTextBoxColumn";
      this.satz4DataGridViewTextBoxColumn.ReadOnly = true;
      this.satz4DataGridViewTextBoxColumn.Width = 50;
      // 
      // schiessArtenIDDataGridViewTextBoxColumn
      // 
      this.schiessArtenIDDataGridViewTextBoxColumn.DataPropertyName = "SchiessArtenID";
      this.schiessArtenIDDataGridViewTextBoxColumn.HeaderText = "SchiessArtenID";
      this.schiessArtenIDDataGridViewTextBoxColumn.Name = "schiessArtenIDDataGridViewTextBoxColumn";
      this.schiessArtenIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.schiessArtenIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // ScheissArt
      // 
      this.ScheissArt.DataPropertyName = "SchiessArt";
      this.ScheissArt.HeaderText = "Schiessart";
      this.ScheissArt.Name = "ScheissArt";
      this.ScheissArt.ReadOnly = true;
      this.ScheissArt.Width = 80;
      // 
      // infoDataGridViewTextBoxColumn1
      // 
      this.infoDataGridViewTextBoxColumn1.DataPropertyName = "Info";
      this.infoDataGridViewTextBoxColumn1.HeaderText = "Info";
      this.infoDataGridViewTextBoxColumn1.Name = "infoDataGridViewTextBoxColumn1";
      this.infoDataGridViewTextBoxColumn1.ReadOnly = true;
      this.infoDataGridViewTextBoxColumn1.Width = 205;
      // 
      // istArchiviertDataGridViewCheckBoxColumn1
      // 
      this.istArchiviertDataGridViewCheckBoxColumn1.DataPropertyName = "IstArchiviert";
      this.istArchiviertDataGridViewCheckBoxColumn1.HeaderText = "IstArchiviert";
      this.istArchiviertDataGridViewCheckBoxColumn1.Name = "istArchiviertDataGridViewCheckBoxColumn1";
      this.istArchiviertDataGridViewCheckBoxColumn1.ReadOnly = true;
      this.istArchiviertDataGridViewCheckBoxColumn1.Visible = false;
      // 
      // ergebnisseBindingSource
      // 
      this.ergebnisseBindingSource.DataMember = "Ergebnisse";
      this.ergebnisseBindingSource.DataSource = this.rBDataErgebnisse;
      // 
      // rBDataErgebnisse
      // 
      this.rBDataErgebnisse.DataSetName = "RBDataErgebnisse";
      this.rBDataErgebnisse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dataGridView3
      // 
      this.dataGridView3.AllowUserToAddRows = false;
      this.dataGridView3.AllowUserToDeleteRows = false;
      this.dataGridView3.AutoGenerateColumns = false;
      this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialGruppe,
            this.bezeichnungDataGridViewTextBoxColumn,
            this.groesseDataGridViewTextBoxColumn,
            this.langtextDataGridViewTextBoxColumn});
      this.dataGridView3.DataSource = this.materialBindingSource;
      this.dataGridView3.Location = new System.Drawing.Point(364, 27);
      this.dataGridView3.Name = "dataGridView3";
      this.dataGridView3.ReadOnly = true;
      this.dataGridView3.Size = new System.Drawing.Size(394, 150);
      this.dataGridView3.TabIndex = 2;
      // 
      // MaterialGruppe
      // 
      this.MaterialGruppe.DataPropertyName = "Gruppe";
      this.MaterialGruppe.HeaderText = "Gruppe";
      this.MaterialGruppe.MinimumWidth = 90;
      this.MaterialGruppe.Name = "MaterialGruppe";
      this.MaterialGruppe.ReadOnly = true;
      this.MaterialGruppe.Width = 90;
      // 
      // bezeichnungDataGridViewTextBoxColumn
      // 
      this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
      this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
      this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
      this.bezeichnungDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // groesseDataGridViewTextBoxColumn
      // 
      this.groesseDataGridViewTextBoxColumn.DataPropertyName = "Groesse";
      this.groesseDataGridViewTextBoxColumn.HeaderText = "Groesse";
      this.groesseDataGridViewTextBoxColumn.MinimumWidth = 60;
      this.groesseDataGridViewTextBoxColumn.Name = "groesseDataGridViewTextBoxColumn";
      this.groesseDataGridViewTextBoxColumn.ReadOnly = true;
      this.groesseDataGridViewTextBoxColumn.Width = 60;
      // 
      // langtextDataGridViewTextBoxColumn
      // 
      this.langtextDataGridViewTextBoxColumn.DataPropertyName = "Langtext";
      this.langtextDataGridViewTextBoxColumn.HeaderText = "Langtext";
      this.langtextDataGridViewTextBoxColumn.Name = "langtextDataGridViewTextBoxColumn";
      this.langtextDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // materialBindingSource
      // 
      this.materialBindingSource.DataMember = "Material";
      this.materialBindingSource.DataSource = this.rBDataMaterial;
      // 
      // rBDataMaterial
      // 
      this.rBDataMaterial.DataSetName = "RBDataMaterial";
      this.rBDataMaterial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // materialTableAdapter
      // 
      this.materialTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager2
      // 
      this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager2.Connection = null;
      this.tableAdapterManager2.UpdateOrder = RBii.RBDataMaterialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // ergebnisseTableAdapter
      // 
      this.ergebnisseTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager1
      // 
      this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager1.Connection = null;
      this.tableAdapterManager1.UpdateOrder = RBii.RBDataErgebnisseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.ergebnisseToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // dateiToolStripMenuItem
      // 
      this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
      this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
      this.dateiToolStripMenuItem.Text = "Datei";
      // 
      // ergebnisseToolStripMenuItem
      // 
      this.ergebnisseToolStripMenuItem.Name = "ergebnisseToolStripMenuItem";
      this.ergebnisseToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
      this.ergebnisseToolStripMenuItem.Text = "Ergebnisse";
      // 
      // iDDataGridViewTextBoxColumn
      // 
      this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
      this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
      this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
      this.iDDataGridViewTextBoxColumn.ReadOnly = true;
      this.iDDataGridViewTextBoxColumn.Visible = false;
      // 
      // adressIDDataGridViewTextBoxColumn
      // 
      this.adressIDDataGridViewTextBoxColumn.DataPropertyName = "AdressID";
      this.adressIDDataGridViewTextBoxColumn.HeaderText = "AdressID";
      this.adressIDDataGridViewTextBoxColumn.Name = "adressIDDataGridViewTextBoxColumn";
      this.adressIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.adressIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // vornameDataGridViewTextBoxColumn
      // 
      this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
      this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
      this.vornameDataGridViewTextBoxColumn.MinimumWidth = 80;
      this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
      this.vornameDataGridViewTextBoxColumn.ReadOnly = true;
      this.vornameDataGridViewTextBoxColumn.Width = 80;
      // 
      // zweitnameDataGridViewTextBoxColumn
      // 
      this.zweitnameDataGridViewTextBoxColumn.DataPropertyName = "Zweitname";
      this.zweitnameDataGridViewTextBoxColumn.HeaderText = "Zweitname";
      this.zweitnameDataGridViewTextBoxColumn.MinimumWidth = 80;
      this.zweitnameDataGridViewTextBoxColumn.Name = "zweitnameDataGridViewTextBoxColumn";
      this.zweitnameDataGridViewTextBoxColumn.ReadOnly = true;
      this.zweitnameDataGridViewTextBoxColumn.Width = 80;
      // 
      // nachnameDataGridViewTextBoxColumn
      // 
      this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
      this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
      this.nachnameDataGridViewTextBoxColumn.MinimumWidth = 80;
      this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
      this.nachnameDataGridViewTextBoxColumn.ReadOnly = true;
      this.nachnameDataGridViewTextBoxColumn.Width = 80;
      // 
      // geburtstagDataGridViewTextBoxColumn
      // 
      this.geburtstagDataGridViewTextBoxColumn.DataPropertyName = "Geburtstag";
      this.geburtstagDataGridViewTextBoxColumn.HeaderText = "Geburtstag";
      this.geburtstagDataGridViewTextBoxColumn.Name = "geburtstagDataGridViewTextBoxColumn";
      this.geburtstagDataGridViewTextBoxColumn.ReadOnly = true;
      this.geburtstagDataGridViewTextBoxColumn.Visible = false;
      // 
      // geschlechtDataGridViewTextBoxColumn
      // 
      this.geschlechtDataGridViewTextBoxColumn.DataPropertyName = "Geschlecht";
      this.geschlechtDataGridViewTextBoxColumn.HeaderText = "Geschlecht";
      this.geschlechtDataGridViewTextBoxColumn.Name = "geschlechtDataGridViewTextBoxColumn";
      this.geschlechtDataGridViewTextBoxColumn.ReadOnly = true;
      this.geschlechtDataGridViewTextBoxColumn.Visible = false;
      // 
      // darfKKDataGridViewCheckBoxColumn
      // 
      this.darfKKDataGridViewCheckBoxColumn.DataPropertyName = "DarfKK";
      this.darfKKDataGridViewCheckBoxColumn.HeaderText = "DarfKK";
      this.darfKKDataGridViewCheckBoxColumn.MinimumWidth = 50;
      this.darfKKDataGridViewCheckBoxColumn.Name = "darfKKDataGridViewCheckBoxColumn";
      this.darfKKDataGridViewCheckBoxColumn.ReadOnly = true;
      this.darfKKDataGridViewCheckBoxColumn.Visible = false;
      this.darfKKDataGridViewCheckBoxColumn.Width = 50;
      // 
      // darfLGDataGridViewCheckBoxColumn
      // 
      this.darfLGDataGridViewCheckBoxColumn.DataPropertyName = "DarfLG";
      this.darfLGDataGridViewCheckBoxColumn.HeaderText = "DarfLG";
      this.darfLGDataGridViewCheckBoxColumn.MinimumWidth = 50;
      this.darfLGDataGridViewCheckBoxColumn.Name = "darfLGDataGridViewCheckBoxColumn";
      this.darfLGDataGridViewCheckBoxColumn.ReadOnly = true;
      this.darfLGDataGridViewCheckBoxColumn.Visible = false;
      this.darfLGDataGridViewCheckBoxColumn.Width = 50;
      // 
      // kleinkaliberIDDataGridViewTextBoxColumn
      // 
      this.kleinkaliberIDDataGridViewTextBoxColumn.DataPropertyName = "KleinkaliberID";
      this.kleinkaliberIDDataGridViewTextBoxColumn.HeaderText = "KleinkaliberID";
      this.kleinkaliberIDDataGridViewTextBoxColumn.Name = "kleinkaliberIDDataGridViewTextBoxColumn";
      this.kleinkaliberIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.kleinkaliberIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // luftgewehrIDDataGridViewTextBoxColumn
      // 
      this.luftgewehrIDDataGridViewTextBoxColumn.DataPropertyName = "LuftgewehrID";
      this.luftgewehrIDDataGridViewTextBoxColumn.HeaderText = "LuftgewehrID";
      this.luftgewehrIDDataGridViewTextBoxColumn.Name = "luftgewehrIDDataGridViewTextBoxColumn";
      this.luftgewehrIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.luftgewehrIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // handschuhIDDataGridViewTextBoxColumn
      // 
      this.handschuhIDDataGridViewTextBoxColumn.DataPropertyName = "HandschuhID";
      this.handschuhIDDataGridViewTextBoxColumn.HeaderText = "HandschuhID";
      this.handschuhIDDataGridViewTextBoxColumn.Name = "handschuhIDDataGridViewTextBoxColumn";
      this.handschuhIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.handschuhIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // jackeIDDataGridViewTextBoxColumn
      // 
      this.jackeIDDataGridViewTextBoxColumn.DataPropertyName = "JackeID";
      this.jackeIDDataGridViewTextBoxColumn.HeaderText = "JackeID";
      this.jackeIDDataGridViewTextBoxColumn.Name = "jackeIDDataGridViewTextBoxColumn";
      this.jackeIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.jackeIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // pistoleIDDataGridViewTextBoxColumn
      // 
      this.pistoleIDDataGridViewTextBoxColumn.DataPropertyName = "PistoleID";
      this.pistoleIDDataGridViewTextBoxColumn.HeaderText = "PistoleID";
      this.pistoleIDDataGridViewTextBoxColumn.Name = "pistoleIDDataGridViewTextBoxColumn";
      this.pistoleIDDataGridViewTextBoxColumn.ReadOnly = true;
      this.pistoleIDDataGridViewTextBoxColumn.Visible = false;
      // 
      // infoDataGridViewTextBoxColumn
      // 
      this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
      this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
      this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
      this.infoDataGridViewTextBoxColumn.ReadOnly = true;
      this.infoDataGridViewTextBoxColumn.Visible = false;
      // 
      // istKoenigDataGridViewCheckBoxColumn
      // 
      this.istKoenigDataGridViewCheckBoxColumn.DataPropertyName = "IstKoenig";
      this.istKoenigDataGridViewCheckBoxColumn.HeaderText = "König";
      this.istKoenigDataGridViewCheckBoxColumn.MinimumWidth = 50;
      this.istKoenigDataGridViewCheckBoxColumn.Name = "istKoenigDataGridViewCheckBoxColumn";
      this.istKoenigDataGridViewCheckBoxColumn.ReadOnly = true;
      this.istKoenigDataGridViewCheckBoxColumn.Visible = false;
      this.istKoenigDataGridViewCheckBoxColumn.Width = 50;
      // 
      // istVizeDataGridViewCheckBoxColumn
      // 
      this.istVizeDataGridViewCheckBoxColumn.DataPropertyName = "IstVize";
      this.istVizeDataGridViewCheckBoxColumn.HeaderText = "Vize";
      this.istVizeDataGridViewCheckBoxColumn.MinimumWidth = 50;
      this.istVizeDataGridViewCheckBoxColumn.Name = "istVizeDataGridViewCheckBoxColumn";
      this.istVizeDataGridViewCheckBoxColumn.ReadOnly = true;
      this.istVizeDataGridViewCheckBoxColumn.Visible = false;
      this.istVizeDataGridViewCheckBoxColumn.Width = 50;
      // 
      // istArchiviertDataGridViewCheckBoxColumn
      // 
      this.istArchiviertDataGridViewCheckBoxColumn.DataPropertyName = "IstArchiviert";
      this.istArchiviertDataGridViewCheckBoxColumn.HeaderText = "IstArchiviert";
      this.istArchiviertDataGridViewCheckBoxColumn.Name = "istArchiviertDataGridViewCheckBoxColumn";
      this.istArchiviertDataGridViewCheckBoxColumn.ReadOnly = true;
      this.istArchiviertDataGridViewCheckBoxColumn.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1008, 729);
      this.Controls.Add(this.dataGridView3);
      this.Controls.Add(this.dataGridView2);
      this.Controls.Add(this.dgvPersonen);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvPersonen)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.personenBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rBDataDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ergebnisseBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rBDataErgebnisse)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rBDataMaterial)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvPersonen;
    private RBDataDataSet rBDataDataSet;
    private System.Windows.Forms.BindingSource personenBindingSource;
    private RBDataDataSetTableAdapters.PersonenTableAdapter personenTableAdapter;
    private RBDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.DataGridView dataGridView2;
    private RBDataErgebnisse rBDataErgebnisse;
    private System.Windows.Forms.BindingSource ergebnisseBindingSource;
    private RBDataErgebnisseTableAdapters.ErgebnisseTableAdapter ergebnisseTableAdapter;
    private RBDataErgebnisseTableAdapters.TableAdapterManager tableAdapterManager1;
    private System.Windows.Forms.DataGridView dataGridView3;
    private RBDataMaterial rBDataMaterial;
    private System.Windows.Forms.BindingSource materialBindingSource;
    private RBDataMaterialTableAdapters.MaterialTableAdapter materialTableAdapter;
    private RBDataMaterialTableAdapters.TableAdapterManager tableAdapterManager2;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn materialGruppenIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ergebnisseToolStripMenuItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn MaterialGruppe;
    private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn groesseDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn langtextDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn namenIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn satz1DataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn satz2DataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn satz3DataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn satz4DataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn schiessArtenIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn ScheissArt;
    private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewCheckBoxColumn istArchiviertDataGridViewCheckBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn adressIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn zweitnameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn geburtstagDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn geschlechtDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn darfKKDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn darfLGDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn kleinkaliberIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn luftgewehrIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn handschuhIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn jackeIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn pistoleIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn istKoenigDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn istVizeDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn istArchiviertDataGridViewCheckBoxColumn;
  }
}

