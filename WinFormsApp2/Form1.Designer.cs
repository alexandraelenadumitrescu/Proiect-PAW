using System.ComponentModel;

namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private BindingList<Produs> bindingProduse;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            dataGridViewProduse = new DataGridView();
            codDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pretDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantitateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            denumireDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            stergeProdusToolStripMenuItem = new ToolStripMenuItem();
            produsBindingSource = new BindingSource(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelNumar = new ToolStripStatusLabel();
            toolStripStatusLabelTotal = new ToolStripStatusLabel();
            Fisiere = new MenuStrip();
            toolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemPrint = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand3 = new Microsoft.Data.SqlClient.SqlCommand();
            ((ISupportInitialize)dataGridViewProduse).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((ISupportInitialize)produsBindingSource).BeginInit();
            statusStrip1.SuspendLayout();
            Fisiere.SuspendLayout();
            ((ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProduse
            // 
            dataGridViewProduse.AutoGenerateColumns = false;
            dataGridViewProduse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduse.Columns.AddRange(new DataGridViewColumn[] { codDataGridViewTextBoxColumn, pretDataGridViewTextBoxColumn, cantitateDataGridViewTextBoxColumn, denumireDataGridViewTextBoxColumn });
            dataGridViewProduse.ContextMenuStrip = contextMenuStrip1;
            dataGridViewProduse.DataSource = produsBindingSource;
            dataGridViewProduse.Dock = DockStyle.Fill;
            dataGridViewProduse.Location = new Point(0, 0);
            dataGridViewProduse.Name = "dataGridViewProduse";
            dataGridViewProduse.RowHeadersWidth = 62;
            dataGridViewProduse.Size = new Size(552, 578);
            dataGridViewProduse.TabIndex = 0;
            // 
            // codDataGridViewTextBoxColumn
            // 
            codDataGridViewTextBoxColumn.DataPropertyName = "Cod";
            codDataGridViewTextBoxColumn.HeaderText = "Cod";
            codDataGridViewTextBoxColumn.MinimumWidth = 8;
            codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            codDataGridViewTextBoxColumn.Width = 150;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            pretDataGridViewTextBoxColumn.MinimumWidth = 8;
            pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            pretDataGridViewTextBoxColumn.Width = 150;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            cantitateDataGridViewTextBoxColumn.MinimumWidth = 8;
            cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            cantitateDataGridViewTextBoxColumn.Width = 150;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            denumireDataGridViewTextBoxColumn.DataPropertyName = "Denumire";
            denumireDataGridViewTextBoxColumn.HeaderText = "Denumire";
            denumireDataGridViewTextBoxColumn.MinimumWidth = 8;
            denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            denumireDataGridViewTextBoxColumn.Width = 150;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { stergeProdusToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(196, 36);
            // 
            // stergeProdusToolStripMenuItem
            // 
            stergeProdusToolStripMenuItem.Name = "stergeProdusToolStripMenuItem";
            stergeProdusToolStripMenuItem.Size = new Size(195, 32);
            stergeProdusToolStripMenuItem.Text = "Sterge Produs";
            stergeProdusToolStripMenuItem.Click += stergeProdusToolStripMenuItem_Click;
            // 
            // produsBindingSource
            // 
            produsBindingSource.DataSource = typeof(Produs);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelNumar, toolStripStatusLabelTotal });
            statusStrip1.Location = new Point(0, 611);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1105, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelNumar
            // 
            toolStripStatusLabelNumar.Name = "toolStripStatusLabelNumar";
            toolStripStatusLabelNumar.Size = new Size(223, 25);
            toolStripStatusLabelNumar.Text = "toolStripStatusLabelNumar";
            // 
            // toolStripStatusLabelTotal
            // 
            toolStripStatusLabelTotal.Name = "toolStripStatusLabelTotal";
            toolStripStatusLabelTotal.Size = new Size(206, 25);
            toolStripStatusLabelTotal.Text = "toolStripStatusLabelTotal";
            // 
            // Fisiere
            // 
            Fisiere.ImageScalingSize = new Size(24, 24);
            Fisiere.Items.AddRange(new ToolStripItem[] { toolStripMenuItem, importToolStripMenuItem, exportToolStripMenuItem, toolStripMenuItemPrint });
            Fisiere.Location = new Point(0, 0);
            Fisiere.Name = "Fisiere";
            Fisiere.Size = new Size(1105, 33);
            Fisiere.TabIndex = 2;
            Fisiere.Text = "Fisiere";
            // 
            // toolStripMenuItem
            // 
            toolStripMenuItem.Name = "toolStripMenuItem";
            toolStripMenuItem.Size = new Size(188, 29);
            toolStripMenuItem.Text = "Adauga produs nou";
            toolStripMenuItem.Click += adaugaProdusToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(232, 29);
            importToolStripMenuItem.Text = "importToolStripMenuItem";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(229, 29);
            exportToolStripMenuItem.Text = "exportToolStripMenuItem";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // toolStripMenuItemPrint
            // 
            toolStripMenuItemPrint.Name = "toolStripMenuItemPrint";
            toolStripMenuItemPrint.Size = new Size(64, 29);
            toolStripMenuItemPrint.Text = "Print";
            toolStripMenuItemPrint.Click += buttonPrint_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 33);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridViewProduse);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1105, 578);
            splitContainer1.SplitterDistance = 552;
            splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 578);
            panel1.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.Connection = null;
            sqlCommand2.Notification = null;
            sqlCommand2.Transaction = null;
            // 
            // sqlCommand3
            // 
            sqlCommand3.CommandTimeout = 30;
            sqlCommand3.Connection = null;
            sqlCommand3.Notification = null;
            sqlCommand3.Transaction = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 643);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(Fisiere);
            MainMenuStrip = Fisiere;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((ISupportInitialize)dataGridViewProduse).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((ISupportInitialize)produsBindingSource).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            Fisiere.ResumeLayout(false);
            Fisiere.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProduse;
        private BindingSource produsBindingSource;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelNumar;
        private ToolStripStatusLabel toolStripStatusLabelTotal;
        private DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private MenuStrip Fisiere;
        private ToolStripMenuItem toolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem stergeProdusToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private ToolStripMenuItem toolStripMenuItemPrint;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand3;
    }
}
