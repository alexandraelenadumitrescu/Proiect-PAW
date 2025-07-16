using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormAdaugare : Form
    {
        private List<Produs> produseDisponibile;
        public FormAdaugare()
        {
            InitializeComponent();
            produseDisponibile = new List<Produs>
        {
            new() { Cod = 10, Denumire = "Cafea", Pret = 15.5m },
            new Produs { Cod = 11, Denumire = "Ceai", Pret = 8.2m },
            new Produs { Cod = 12, Denumire = "Suc", Pret = 5.0m },
        };



            comboBoxProduse.DataSource = produseDisponibile;
            comboBoxProduse.DisplayMember = "Denumire";
            comboBoxProduse.ValueMember = "Cod";

            numericUpDownCant.Minimum = 1;
            numericUpDownCant.Value = 1;
        }

        private void FormAdaugare_Load(object sender, EventArgs e)
        {

        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            var produsSelectat = comboBoxProduse.SelectedItem as Produs;
            if (produsSelectat != null)
            {
                int cantitate = (int)numericUpDownCant.Value;

                // Cream o copie cu cantitate
                var produsNou = new Produs
                {
                    Cod = produsSelectat.Cod,
                    Denumire = produsSelectat.Denumire,
                    Pret = produsSelectat.Pret,
                    Cantitate = cantitate
                };

                Program.Cos.AdaugaProdus(produsNou);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
