using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBii
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // TODO: Diese Codezeile lädt Daten in die Tabelle "rBDataDataSet.Personen". Sie können sie bei Bedarf verschieben oder entfernen.
      this.personenTableAdapter.Fill(this.rBDataDataSet.Personen);

    }

    private void dgvPersonen_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      materialTableAdapter.Fill(this.rBDataMaterial.Material, Convert.ToInt32(dgvPersonen.Rows[dgvPersonen.CurrentRow.Index].Cells[0].Value));
      ergebnisseTableAdapter.Fill(this.rBDataErgebnisse.Ergebnisse, Convert.ToInt32(dgvPersonen.Rows[dgvPersonen.CurrentRow.Index].Cells[0].Value));
    }
  }
}
