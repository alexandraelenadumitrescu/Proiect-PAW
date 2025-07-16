namespace WinFormsApp2
{
    partial class FormAdaugare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxProduse = new ComboBox();
            numericUpDownCant = new NumericUpDown();
            btnAdauga = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCant).BeginInit();
            SuspendLayout();
            // 
            // comboBoxProduse
            // 
            comboBoxProduse.FormattingEnabled = true;
            comboBoxProduse.Location = new Point(67, 48);
            comboBoxProduse.Name = "comboBoxProduse";
            comboBoxProduse.Size = new Size(182, 33);
            comboBoxProduse.TabIndex = 0;
            // 
            // numericUpDownCant
            // 
            numericUpDownCant.Location = new Point(289, 48);
            numericUpDownCant.Name = "numericUpDownCant";
            numericUpDownCant.Size = new Size(180, 31);
            numericUpDownCant.TabIndex = 1;
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(229, 105);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(112, 34);
            btnAdauga.TabIndex = 2;
            btnAdauga.Text = "OK";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(357, 105);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormAdaugare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnAdauga);
            Controls.Add(numericUpDownCant);
            Controls.Add(comboBoxProduse);
            Name = "FormAdaugare";
            Text = "Form2";
            Load += FormAdaugare_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCant).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxProduse;
        private NumericUpDown numericUpDownCant;
        private Button btnAdauga;
        private Button btnCancel;
    }
}