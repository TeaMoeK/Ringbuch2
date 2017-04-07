using System;
using System.Windows.Forms;

namespace Ringbuch2
{
    public partial class MyDialog : Form
    {
        private string _titel;
        private string _message;
        private string _password = string.Empty;

        private bool _adminPW;
        private bool _inputBox = false;
        private bool _passwordBox = false;
        private bool _setPassword = false;

        private const string aes_key = "TimoistDerCoolsteDerCoolenDigger";  //32
    private Label lblConfirm;
    private TextBox txtConfirmPW;
    private RichTextBox richtxtAnzeigeText;
    private CheckBox chkShowPassword;
    private Label lblPassword;
    private TextBox txtInputBox;
    private Button btnCancle;
    private Button btnOK;
    private const string aes_iv = "EineKetteVonkeys";   //16

        private void MyDialog_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        // Constructors
        private MyDialog(string titel, string message)
        {
            myDialog(titel, message, false, false, false);
        }
        private MyDialog(string titel, string message, bool inputBox)
        {
            myDialog(titel, message, inputBox, false, false);
        }
        public MyDialog(bool passwordBox, string titel, string message, bool setPassword)
        {
            myDialog(titel, message, true, passwordBox, setPassword);
        }

        public MyDialog(bool passwordBox, string titel, string message)
        {
            _adminPW = true;
            myDialog(titel, message, true, passwordBox, false);
        }
        // Hier landen die Constructors
        private void myDialog(string titel, string message, bool inputBox, bool passwordBox, bool setPassword)
        {
            InitializeComponent();
            _titel = titel;
            _message = message;
            _inputBox = inputBox;
            _passwordBox = passwordBox;
            _setPassword = setPassword;

            txtInputBox.Visible = inputBox;
            chkShowPassword.Visible = passwordBox;
            lblPassword.Visible = passwordBox;
            Init();
            this.TopMost = true;
        }
        private void Init()
        {
            if (_passwordBox)
            {
                txtInputBox.PasswordChar = '*';
            }
            if (_setPassword)
            {
                txtConfirmPW.Visible = true;
                lblConfirm.Visible = true;
                txtConfirmPW.PasswordChar = '*';
            }
            else
            {
                txtConfirmPW.Visible = false;
                lblConfirm.Visible = false;
            }
            this.text = _titel;
            richtxtAnzeigeText.Text = _message;
            richtxtAnzeigeText.SelectionAlignment = HorizontalAlignment.Center;
            OK = false;
        }
        private void OK_Klick(object sender, EventArgs e)
        {

    }
    private void Exit(object sender, EventArgs e)
        {
            PasswortOK = false;
            Abbrechen = true;
            OK = false;
            this.Dispose();
        }
        private void keyDown(object sender, KeyEventArgs e)
        {

    }
    private void checkPassword()
        {
            if (!_adminPW)
            {
                GetDaten getDaten = new GetDaten();
                if (text == decryptPW_AES(getDaten.getPassword()))
                {
                    PasswortOK = true;
                }
                else
                {
                    PasswortOK = false;
                    MessageBox.Show("Das Passwort war falsch!", "Falsches Passwort");
                }
            }
            else
            {
                text = txtInputBox.Text;
                PasswortOK = true;
            }
        }
        private string encryptPW_AES(string password)
        {
            return AES.AES.EncrytStringToBytes_Aes(password, aes_key, aes_iv);
        }
        private string decryptPW_AES(string password)
        {
            return AES.AES.DecryptStringFromBytes_Aes(password, aes_key, aes_iv);
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

    }
    // Getter und Setter
    public string text
        {
            get; set;
        }
        public string codedText
        {
            get; set;
        }
        public string decodedText
        {
            get; set;
        }
        public bool PasswortOK
        {
            get; set;
        }
        public bool OK
        {
            get; set;
        }

        public bool Abbrechen
        {
            get; set;
        }

    private void InitializeComponent()
    {
      this.lblConfirm = new System.Windows.Forms.Label();
      this.txtConfirmPW = new System.Windows.Forms.TextBox();
      this.richtxtAnzeigeText = new System.Windows.Forms.RichTextBox();
      this.chkShowPassword = new System.Windows.Forms.CheckBox();
      this.lblPassword = new System.Windows.Forms.Label();
      this.txtInputBox = new System.Windows.Forms.TextBox();
      this.btnCancle = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblConfirm
      // 
      this.lblConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblConfirm.AutoSize = true;
      this.lblConfirm.Location = new System.Drawing.Point(9, 119);
      this.lblConfirm.Name = "lblConfirm";
      this.lblConfirm.Size = new System.Drawing.Size(57, 13);
      this.lblConfirm.TabIndex = 15;
      this.lblConfirm.Text = "Bestätigen";
      // 
      // txtConfirmPW
      // 
      this.txtConfirmPW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtConfirmPW.Location = new System.Drawing.Point(67, 116);
      this.txtConfirmPW.Name = "txtConfirmPW";
      this.txtConfirmPW.Size = new System.Drawing.Size(102, 20);
      this.txtConfirmPW.TabIndex = 14;
      // 
      // richtxtAnzeigeText
      // 
      this.richtxtAnzeigeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.richtxtAnzeigeText.Location = new System.Drawing.Point(12, 12);
      this.richtxtAnzeigeText.Name = "richtxtAnzeigeText";
      this.richtxtAnzeigeText.ReadOnly = true;
      this.richtxtAnzeigeText.Size = new System.Drawing.Size(233, 68);
      this.richtxtAnzeigeText.TabIndex = 11;
      this.richtxtAnzeigeText.Text = "";
      // 
      // chkShowPassword
      // 
      this.chkShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.chkShowPassword.AutoSize = true;
      this.chkShowPassword.Location = new System.Drawing.Point(175, 92);
      this.chkShowPassword.Name = "chkShowPassword";
      this.chkShowPassword.Size = new System.Drawing.Size(53, 17);
      this.chkShowPassword.TabIndex = 13;
      this.chkShowPassword.Text = "Show";
      this.chkShowPassword.UseVisualStyleBackColor = true;
      // 
      // lblPassword
      // 
      this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblPassword.AutoSize = true;
      this.lblPassword.Location = new System.Drawing.Point(9, 94);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(50, 13);
      this.lblPassword.TabIndex = 12;
      this.lblPassword.Text = "Passwort";
      // 
      // txtInputBox
      // 
      this.txtInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtInputBox.Location = new System.Drawing.Point(67, 90);
      this.txtInputBox.Name = "txtInputBox";
      this.txtInputBox.Size = new System.Drawing.Size(102, 20);
      this.txtInputBox.TabIndex = 8;
      // 
      // btnCancle
      // 
      this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancle.Location = new System.Drawing.Point(170, 144);
      this.btnCancle.Name = "btnCancle";
      this.btnCancle.Size = new System.Drawing.Size(75, 23);
      this.btnCancle.TabIndex = 10;
      this.btnCancle.Text = "Abbrechen";
      this.btnCancle.UseVisualStyleBackColor = true;
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.Location = new System.Drawing.Point(12, 144);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 9;
      this.btnOK.Text = "Ok";
      this.btnOK.UseVisualStyleBackColor = true;
      // 
      // MyDialog
      // 
      this.ClientSize = new System.Drawing.Size(257, 178);
      this.Controls.Add(this.lblConfirm);
      this.Controls.Add(this.txtConfirmPW);
      this.Controls.Add(this.richtxtAnzeigeText);
      this.Controls.Add(this.chkShowPassword);
      this.Controls.Add(this.lblPassword);
      this.Controls.Add(this.txtInputBox);
      this.Controls.Add(this.btnCancle);
      this.Controls.Add(this.btnOK);
      this.Name = "MyDialog";
      this.ResumeLayout(false);
      this.PerformLayout();

    }
  }
}
