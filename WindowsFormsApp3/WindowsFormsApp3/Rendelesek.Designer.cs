namespace WindowsFormsApp3
{
    partial class RendelesekForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Teteltorlesebtn = new System.Windows.Forms.Button();
            this.kezdolapbtn = new System.Windows.Forms.Button();
            this.tetelmodositbtn = new System.Windows.Forms.Button();
            this.Kilepbtn = new System.Windows.Forms.Button();
            this.RendelesiTetelekListbox = new System.Windows.Forms.ListBox();
            this.RendelesTorlesbtn = new System.Windows.Forms.Button();
            this.Rendeleseklistbox = new System.Windows.Forms.ListBox();
            this.orderSKlistbox = new System.Windows.Forms.ListBox();
            this.orderFKlist = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(411, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rendeléseim";
            // 
            // Teteltorlesebtn
            // 
            this.Teteltorlesebtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Teteltorlesebtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Teteltorlesebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Teteltorlesebtn.ForeColor = System.Drawing.Color.White;
            this.Teteltorlesebtn.Location = new System.Drawing.Point(635, 484);
            this.Teteltorlesebtn.Name = "Teteltorlesebtn";
            this.Teteltorlesebtn.Size = new System.Drawing.Size(145, 81);
            this.Teteltorlesebtn.TabIndex = 2;
            this.Teteltorlesebtn.Text = "Rendelési tétel törlése";
            this.Teteltorlesebtn.UseVisualStyleBackColor = false;
            this.Teteltorlesebtn.Click += new System.EventHandler(this.Teteltorlesebtn_Click);
            this.Teteltorlesebtn.MouseEnter += new System.EventHandler(this.Teteltorlesebtn_MouseEnter);
            // 
            // kezdolapbtn
            // 
            this.kezdolapbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kezdolapbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.kezdolapbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kezdolapbtn.ForeColor = System.Drawing.Color.White;
            this.kezdolapbtn.Location = new System.Drawing.Point(947, 273);
            this.kezdolapbtn.Name = "kezdolapbtn";
            this.kezdolapbtn.Size = new System.Drawing.Size(145, 81);
            this.kezdolapbtn.TabIndex = 3;
            this.kezdolapbtn.Text = "Vissza a kezdőlapra";
            this.kezdolapbtn.UseVisualStyleBackColor = false;
            this.kezdolapbtn.Click += new System.EventHandler(this.Kezdolap_Click);
            // 
            // tetelmodositbtn
            // 
            this.tetelmodositbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tetelmodositbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.tetelmodositbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tetelmodositbtn.ForeColor = System.Drawing.Color.White;
            this.tetelmodositbtn.Location = new System.Drawing.Point(947, 159);
            this.tetelmodositbtn.Name = "tetelmodositbtn";
            this.tetelmodositbtn.Size = new System.Drawing.Size(145, 81);
            this.tetelmodositbtn.TabIndex = 4;
            this.tetelmodositbtn.Text = "Új rendelés";
            this.tetelmodositbtn.UseVisualStyleBackColor = false;
            this.tetelmodositbtn.Click += new System.EventHandler(this.Rendelesek_Click);
            // 
            // Kilepbtn
            // 
            this.Kilepbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Kilepbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.Kilepbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kilepbtn.ForeColor = System.Drawing.Color.White;
            this.Kilepbtn.Location = new System.Drawing.Point(947, 397);
            this.Kilepbtn.Name = "Kilepbtn";
            this.Kilepbtn.Size = new System.Drawing.Size(145, 81);
            this.Kilepbtn.TabIndex = 7;
            this.Kilepbtn.Text = "Kilépés";
            this.Kilepbtn.UseVisualStyleBackColor = false;
            this.Kilepbtn.Click += new System.EventHandler(this.Kilepbtn_Click);
            // 
            // RendelesiTetelekListbox
            // 
            this.RendelesiTetelekListbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RendelesiTetelekListbox.FormattingEnabled = true;
            this.RendelesiTetelekListbox.ItemHeight = 20;
            this.RendelesiTetelekListbox.Location = new System.Drawing.Point(551, 134);
            this.RendelesiTetelekListbox.Name = "RendelesiTetelekListbox";
            this.RendelesiTetelekListbox.Size = new System.Drawing.Size(280, 344);
            this.RendelesiTetelekListbox.TabIndex = 8;
            // 
            // RendelesTorlesbtn
            // 
            this.RendelesTorlesbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RendelesTorlesbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.RendelesTorlesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RendelesTorlesbtn.ForeColor = System.Drawing.Color.White;
            this.RendelesTorlesbtn.Location = new System.Drawing.Point(230, 484);
            this.RendelesTorlesbtn.Name = "RendelesTorlesbtn";
            this.RendelesTorlesbtn.Size = new System.Drawing.Size(145, 81);
            this.RendelesTorlesbtn.TabIndex = 9;
            this.RendelesTorlesbtn.Text = "Rendelés törlése";
            this.RendelesTorlesbtn.UseVisualStyleBackColor = false;
            this.RendelesTorlesbtn.Click += new System.EventHandler(this.RendelesTorlesBtn_Click);
            this.RendelesTorlesbtn.MouseEnter += new System.EventHandler(this.RendelesTorlesbtn_MouseEnter);
            // 
            // Rendeleseklistbox
            // 
            this.Rendeleseklistbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Rendeleseklistbox.FormattingEnabled = true;
            this.Rendeleseklistbox.ItemHeight = 20;
            this.Rendeleseklistbox.Location = new System.Drawing.Point(164, 134);
            this.Rendeleseklistbox.Name = "Rendeleseklistbox";
            this.Rendeleseklistbox.Size = new System.Drawing.Size(291, 344);
            this.Rendeleseklistbox.TabIndex = 10;
            // 
            // orderSKlistbox
            // 
            this.orderSKlistbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderSKlistbox.FormattingEnabled = true;
            this.orderSKlistbox.ItemHeight = 20;
            this.orderSKlistbox.Location = new System.Drawing.Point(96, 134);
            this.orderSKlistbox.Name = "orderSKlistbox";
            this.orderSKlistbox.Size = new System.Drawing.Size(51, 344);
            this.orderSKlistbox.TabIndex = 11;
            // 
            // orderFKlist
            // 
            this.orderFKlist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderFKlist.FormattingEnabled = true;
            this.orderFKlist.ItemHeight = 20;
            this.orderFKlist.Location = new System.Drawing.Point(494, 134);
            this.orderFKlist.Name = "orderFKlist";
            this.orderFKlist.Size = new System.Drawing.Size(51, 344);
            this.orderFKlist.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rendelés";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(605, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Rendelési tételek";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sorszám";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(479, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sorszám";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(WindowsFormsApp3.Order);
            // 
            // RendelesekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.hatterkep;
            this.ClientSize = new System.Drawing.Size(1321, 628);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderFKlist);
            this.Controls.Add(this.orderSKlistbox);
            this.Controls.Add(this.Rendeleseklistbox);
            this.Controls.Add(this.RendelesTorlesbtn);
            this.Controls.Add(this.RendelesiTetelekListbox);
            this.Controls.Add(this.Kilepbtn);
            this.Controls.Add(this.tetelmodositbtn);
            this.Controls.Add(this.kezdolapbtn);
            this.Controls.Add(this.Teteltorlesebtn);
            this.Controls.Add(this.label1);
            this.Name = "RendelesekForm";
            this.Text = "Rendelesek";
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Teteltorlesebtn;
        private System.Windows.Forms.Button kezdolapbtn;
        private System.Windows.Forms.Button tetelmodositbtn;
        private System.Windows.Forms.Button Kilepbtn;
        private System.Windows.Forms.ListBox RendelesiTetelekListbox;
        private System.Windows.Forms.Button RendelesTorlesbtn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.ListBox Rendeleseklistbox;
        private System.Windows.Forms.ListBox orderSKlistbox;
        private System.Windows.Forms.ListBox orderFKlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}