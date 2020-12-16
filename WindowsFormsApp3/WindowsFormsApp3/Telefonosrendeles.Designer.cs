namespace WindowsFormsApp3
{
    partial class Telefonosrendeles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rendelesekbetoltbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(706, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // rendelesekbetoltbtn
            // 
            this.rendelesekbetoltbtn.Location = new System.Drawing.Point(37, 28);
            this.rendelesekbetoltbtn.Name = "rendelesekbetoltbtn";
            this.rendelesekbetoltbtn.Size = new System.Drawing.Size(141, 67);
            this.rendelesekbetoltbtn.TabIndex = 1;
            this.rendelesekbetoltbtn.Text = "Rendelések betöltése";
            this.rendelesekbetoltbtn.UseVisualStyleBackColor = true;
            this.rendelesekbetoltbtn.Click += new System.EventHandler(this.rendelesekbetoltbtn_Click);
            // 
            // Telefonosrendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rendelesekbetoltbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Telefonosrendeles";
            this.Text = "Telefonosrendeles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button rendelesekbetoltbtn;
    }
}