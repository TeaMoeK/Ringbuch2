using System.Windows.Forms;

namespace RBii.Forms
{
    public partial class ConfigPersonen : Form
    {
        private DataGridViewRow data;
        public ConfigPersonen(DataGridViewRow Data)
        {
            this.data = Data;
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            txtVorname.Text = data.Cells[(int)Enums.EnumPersonenGrid.PersonenGrid.Vorname].Value.ToString();
            txtZweitname.Text = data.Cells[(int)Enums.EnumPersonenGrid.PersonenGrid.Zweitname].Value.ToString();
            txtNachname.Text = data.Cells[(int)Enums.EnumPersonenGrid.PersonenGrid.Nachname].Value.ToString();
        }
    }
}
