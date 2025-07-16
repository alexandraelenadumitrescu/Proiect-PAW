using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting;




namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        CosCumparaturi cos;
        private BindingList<Produs> produseBinding;
       

        public Form1()
        {
            InitializeComponent();
            cos = new CosCumparaturi();

            cos.AdaugaProdus(new Produs() { Cod = 1, Denumire = "Lapte", Pret = 5.5m, Cantitate = 2 });
            cos.AdaugaProdus(new Produs() { Cod = 2, Denumire = "Paine", Pret = 3.0m, Cantitate = 1 });

            produseBinding = new BindingList<Produs>(Program.Cos.ToList());
            dataGridViewProduse.DataSource = produseBinding;

            Program.Cos.AdaugareProdus += OnCosChanged;
            Program.Cos.StergereProdus += OnCosChanged;
            Program.Cos.ModificareProdus += OnCosChanged;

            dataGridViewProduse.CellValueChanged += DataGridViewProduse_CellValueChanged;
            dataGridViewProduse.UserDeletingRow += DataGridViewProduse_UserDeletingRow;

            ActualizeazaStatusBar();





        }

        private void OnCosChanged(object? sender, EventArgs e)
        {
            produseBinding = new BindingList<Produs>(Program.Cos.ToList());
            dataGridViewProduse.DataSource = produseBinding;
            ActualizeazaStatusBar();
        }

        private void DataGridViewProduse_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // force update manual — pentru cazul in care BindingList nu se updateaza
            ActualizeazaStatusBar();
        }

        private void DataGridViewProduse_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.DataBoundItem is Produs p)

            {
                if (p != null)
                {
                    Program.Cos.StergeProdus(p.Cod);
                }
            }
        }

        //private void OnCosChanged(object sender, Produs e)
        //{
        //    produseBinding = new BindingList<Produs>(Program.Cos.ToList());
        //    dataGridViewProduse.DataSource = produseBinding;
        //    ActualizeazaStatusBar();
        //}

        private void ActualizeazaStatusBar()
        {
            toolStripStatusLabelNumar.Text = $"Număr produse: {Program.Cos.NumarProduse}";
            toolStripStatusLabelTotal.Text = $"Valoare totală: {Program.Cos.ValoareTotala:F2} lei";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DeseneazaGrafic();

        }
        private void adaugaProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAdaugare = new FormAdaugare();
            formAdaugare.ShowDialog();


            produseBinding = new BindingList<Produs>(Program.Cos.ToList());
            dataGridViewProduse.DataSource = produseBinding;
            ActualizeazaStatusBar();
        }
        //private void stergeProdusToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    StergeProdusSelectat();
        //}
        private void stergeProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduse.SelectedRows.Count > 0)
            {
                var produs = dataGridViewProduse.SelectedRows[0].DataBoundItem as Produs;
                if (produs != null)
                {
                    produsBindingSource.Remove(produs);
                    
                    ActualizeazaStatusBar();
                }
            }
            else
            {
                MessageBox.Show("Selectează o linie pentru a șterge.");
            }
        }

        //private void StergeProdusSelectat()
        //{
        //    if (dataGridViewProduse.SelectedRows.Count > 0)
        //    {
        //        var produs = dataGridViewProduse.SelectedRows[0].DataBoundItem as Produs;
        //        if (produs != null)
        //        {
        //            Program.Cos.StergeProdus(produs.Cod);
        //            produseBinding = new BindingList<Produs>(Program.Cos.ToList());
        //            dataGridViewProduse.DataSource = produseBinding;
        //            ActualizeazaStatusBar();
        //        }
        //    }
        //}
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fișiere text|*.txt";
            saveFileDialog.Title = "Exportă coșul într-un fișier";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var produs in Program.Cos.ToList())
                    {
                        writer.WriteLine($"{produs.Cod};{produs.Denumire};{produs.Pret};{produs.Cantitate}");
                    }
                }

                MessageBox.Show("Export realizat cu succes!");
            }
        }
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fișiere text|*.txt";
            openFileDialog.Title = "Importă coșul dintr-un fișier";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var linii = File.ReadAllLines(openFileDialog.FileName);

                    foreach (var linie in linii)
                    {
                        var parti = linie.Split(';');
                        if (parti.Length == 4)
                        {
                            int cod = int.Parse(parti[0]);
                            string denumire = parti[1];
                            decimal pret = decimal.Parse(parti[2]);
                            int cantitate = int.Parse(parti[3]);

                            var produs = new Produs
                            {
                                Cod = cod,
                                Denumire = denumire,
                                Pret = pret,
                                Cantitate = cantitate
                            };

                            Program.Cos.AdaugaProdus(produs);
                        }
                    }

                    // Refresh UI
                    produseBinding = new BindingList<Produs>(Program.Cos.ToList());
                    dataGridViewProduse.DataSource = produseBinding;
                    ActualizeazaStatusBar();

                    MessageBox.Show("Import realizat cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la import: " + ex.Message);
                }
            }
        }
        PrintDocument printDoc = new PrintDocument();

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            // codul pentru print
            printDoc.PrintPage += new PrintPageEventHandler(PrintPageHandler);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;
            previewDialog.ShowDialog(); // sau: printDoc.Print();
        }
        //private void PrintPageHandler(object sender, PrintPageEventArgs e)
        //{
        //    //e.Graphics.DrawString("Test de print", new Font("Arial", 16), Brushes.Black, 100, 100);
        //    List<Produs> produse = cos.ToList();
        //    Font font = new Font("Arial", 12);
        //    float y = 100;
        //    int linie = 1;

        //    e.Graphics.DrawString("Coșul de cumpărături", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 100, y);
        //    y += 40;

        //    foreach (Produs p in produse)
        //    {
        //        string linieText = $"{linie}. Cod: {p.Cod} | Nume: {p.Denumire} | Preț: {p.Pret} lei";
        //        e.Graphics.DrawString(linieText, font, Brushes.Black, 100, y);
        //        y += 30;
        //        linie++;
        //    }
        //}



        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            //if (cos == null || cos.ToList() == null)
            //{
            //    e.Graphics.DrawString("Cosul este gol!", new Font("Arial", 14), Brushes.Black, 100, 100);
            //    return;
            //}
            List<Produs> produse = Program.Cos.ToList();
            Font font = new Font("Arial", 12);
            float y = 100;

            foreach (Produs p in produse)
            {
                string linie = $"{p.Denumire} - {p.Cantitate} x {p.Pret} lei";
                e.Graphics.DrawString(linie, font, Brushes.Black, 100, y);
                y += 30;
            }

            e.Graphics.DrawString($"Total: {Program.Cos.ValoareTotala} lei", font, Brushes.Black, 100, y + 20);
        }


        //private void DeseneazaGrafic()
        //{
        //    var produse = Program.Cos.ToList();
        //    if (produse.Count == 0) return;

        //    panelGrafic.Invalidate(); // Șterge tot
        //    Graphics g = panelGrafic.CreateGraphics();

        //    int latimeTotala = panelGrafic.Width;
        //    int inaltimeTotala = panelGrafic.Height;

        //    float maxValoare = (float)produse.Max(p => p.Pret * p.Cantitate);
        //    if (maxValoare == 0) return;

        //    int baraInaltime = 30;
        //    int spatiu = 10;

        //    Font font = new Font("Segoe UI", 9);
        //    Brush textBrush = Brushes.Black;

        //    for (int i = 0; i < produse.Count; i++)
        //    {
        //        var produs = produse[i];
        //        float valoare = (float)produs.Pret * produs.Cantitate;
        //        float lungimeBara = (valoare / maxValoare) * (latimeTotala - 150);

        //        RectangleF bara = new RectangleF(140, i * (baraInaltime + spatiu), lungimeBara, baraInaltime);

        //        // Bară colorată
        //        Brush brush = new SolidBrush(Color.FromArgb(100 + (i * 30) % 155, 100, 200));
        //        g.FillRectangle(brush, bara);

        //        // Eticheta produsului + valoarea
        //        g.DrawString($"{produs.Denumire} ({valoare:F2} RON)", font, textBrush, 5, i * (baraInaltime + spatiu) + 5);
        //    }
        //}

        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void AdaugaChart()
        {
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea("MainArea");
            chart.ChartAreas.Add(chartArea);

            Series serie = new Series("Vanzari");
            serie.ChartType = SeriesChartType.Column;
            serie.Points.AddXY("Produs A", 10);
            serie.Points.AddXY("Produs B", 20);
            serie.Points.AddXY("Produs C", 30);

            chart.Series.Add(serie);

            this.Controls.Add(chart);
        }
    }
}
