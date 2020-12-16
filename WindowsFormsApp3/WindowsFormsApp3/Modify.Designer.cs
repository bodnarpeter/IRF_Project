namespace WindowsFormsApp3
{
    partial class Modify
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
            this.PizzeriaCombo = new System.Windows.Forms.ComboBox();
            this.PizzaCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pizzeriaTxt = new System.Windows.Forms.TextBox();
            this.PizzeriaFelvetelBtn = new System.Windows.Forms.Button();
            this.UjPizzaFelveszBtn = new System.Windows.Forms.Button();
            this.UjPizzanevtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PizzeriaTorlesBtn = new System.Windows.Forms.Button();
            this.PizzaTorlesBtn = new System.Windows.Forms.Button();
            this.StartPageBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PizzeriakujPizzahozCombo = new System.Windows.Forms.ComboBox();
            this.Feltet = new System.Windows.Forms.Label();
            this.UjFeltettxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UjArtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UjrendelesBtn = new System.Windows.Forms.Button();
            this.TorolniPizzalistbox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FeltetekCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PizzeriaCombo
            // 
            this.PizzeriaCombo.FormattingEnabled = true;
            this.PizzeriaCombo.Location = new System.Drawing.Point(35, 104);
            this.PizzeriaCombo.Name = "PizzeriaCombo";
            this.PizzeriaCombo.Size = new System.Drawing.Size(157, 28);
            this.PizzeriaCombo.TabIndex = 0;
            this.PizzeriaCombo.Text = "Pizzériák:";
            // 
            // PizzaCombo
            // 
            this.PizzaCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PizzaCombo.FormattingEnabled = true;
            this.PizzaCombo.Location = new System.Drawing.Point(508, 106);
            this.PizzaCombo.Name = "PizzaCombo";
            this.PizzaCombo.Size = new System.Drawing.Size(129, 28);
            this.PizzaCombo.TabIndex = 1;
            this.PizzaCombo.Text = "Pizzák:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Új pizzéria hozáadása:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(707, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Új Pizza neve:";
            // 
            // pizzeriaTxt
            // 
            this.pizzeriaTxt.Location = new System.Drawing.Point(225, 106);
            this.pizzeriaTxt.Name = "pizzeriaTxt";
            this.pizzeriaTxt.Size = new System.Drawing.Size(197, 26);
            this.pizzeriaTxt.TabIndex = 4;
            // 
            // PizzeriaFelvetelBtn
            // 
            this.PizzeriaFelvetelBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.PizzeriaFelvetelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PizzeriaFelvetelBtn.ForeColor = System.Drawing.Color.White;
            this.PizzeriaFelvetelBtn.Location = new System.Drawing.Point(245, 193);
            this.PizzeriaFelvetelBtn.Name = "PizzeriaFelvetelBtn";
            this.PizzeriaFelvetelBtn.Size = new System.Drawing.Size(143, 31);
            this.PizzeriaFelvetelBtn.TabIndex = 5;
            this.PizzeriaFelvetelBtn.Text = "Felvétel";
            this.PizzeriaFelvetelBtn.UseVisualStyleBackColor = false;
            this.PizzeriaFelvetelBtn.Click += new System.EventHandler(this.PizzeriaFelvetelBtn_Click);
            this.PizzeriaFelvetelBtn.MouseEnter += new System.EventHandler(this.PizzeriaFelvetelBtn_MouseEnter);
            // 
            // UjPizzaFelveszBtn
            // 
            this.UjPizzaFelveszBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.UjPizzaFelveszBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UjPizzaFelveszBtn.ForeColor = System.Drawing.Color.White;
            this.UjPizzaFelveszBtn.Location = new System.Drawing.Point(580, 529);
            this.UjPizzaFelveszBtn.Name = "UjPizzaFelveszBtn";
            this.UjPizzaFelveszBtn.Size = new System.Drawing.Size(203, 65);
            this.UjPizzaFelveszBtn.TabIndex = 6;
            this.UjPizzaFelveszBtn.Text = "Pizza felvétele";
            this.UjPizzaFelveszBtn.UseVisualStyleBackColor = false;
            this.UjPizzaFelveszBtn.Click += new System.EventHandler(this.UjPizzaFelveszBtn_Click);
            this.UjPizzaFelveszBtn.MouseEnter += new System.EventHandler(this.UjPizzaFelveszBtn_MouseEnter);
            // 
            // UjPizzanevtxt
            // 
            this.UjPizzanevtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UjPizzanevtxt.Location = new System.Drawing.Point(711, 106);
            this.UjPizzanevtxt.Name = "UjPizzanevtxt";
            this.UjPizzanevtxt.Size = new System.Drawing.Size(297, 26);
            this.UjPizzanevtxt.TabIndex = 7;
            this.UjPizzanevtxt.Validating += new System.ComponentModel.CancelEventHandler(this.UjPizzanevtxt_Validating);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pizzériák:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(502, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pizza kiválasztása:";
            // 
            // PizzeriaTorlesBtn
            // 
            this.PizzeriaTorlesBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.PizzeriaTorlesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PizzeriaTorlesBtn.ForeColor = System.Drawing.Color.White;
            this.PizzeriaTorlesBtn.Location = new System.Drawing.Point(35, 193);
            this.PizzeriaTorlesBtn.Name = "PizzeriaTorlesBtn";
            this.PizzeriaTorlesBtn.Size = new System.Drawing.Size(165, 31);
            this.PizzeriaTorlesBtn.TabIndex = 10;
            this.PizzeriaTorlesBtn.Text = "Törlés";
            this.PizzeriaTorlesBtn.UseVisualStyleBackColor = false;
            this.PizzeriaTorlesBtn.Click += new System.EventHandler(this.PizzeriaTorlesBtn_Click);
            this.PizzeriaTorlesBtn.MouseEnter += new System.EventHandler(this.PizzeriaTorlesBtn_MouseEnter);
            // 
            // PizzaTorlesBtn
            // 
            this.PizzaTorlesBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.PizzaTorlesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PizzaTorlesBtn.ForeColor = System.Drawing.Color.White;
            this.PizzaTorlesBtn.Location = new System.Drawing.Point(1043, 524);
            this.PizzaTorlesBtn.Name = "PizzaTorlesBtn";
            this.PizzaTorlesBtn.Size = new System.Drawing.Size(203, 65);
            this.PizzaTorlesBtn.TabIndex = 11;
            this.PizzaTorlesBtn.Text = "Pizza törlése";
            this.PizzaTorlesBtn.UseVisualStyleBackColor = false;
            this.PizzaTorlesBtn.Click += new System.EventHandler(this.PizzaTorlesBtn_Click);
            this.PizzaTorlesBtn.MouseEnter += new System.EventHandler(this.PizzaTorlesBtn_MouseEnter);
            // 
            // StartPageBtn
            // 
            this.StartPageBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.StartPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartPageBtn.ForeColor = System.Drawing.Color.White;
            this.StartPageBtn.Location = new System.Drawing.Point(125, 266);
            this.StartPageBtn.Name = "StartPageBtn";
            this.StartPageBtn.Size = new System.Drawing.Size(146, 75);
            this.StartPageBtn.TabIndex = 12;
            this.StartPageBtn.Text = "Vissza a kezdőlapra";
            this.StartPageBtn.UseVisualStyleBackColor = false;
            this.StartPageBtn.Click += new System.EventHandler(this.StartPageBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(125, 524);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(146, 75);
            this.ExitBtn.TabIndex = 13;
            this.ExitBtn.Text = "Kilépés";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(503, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Melyik Pizzériában szeretnéd látni?";
            // 
            // PizzeriakujPizzahozCombo
            // 
            this.PizzeriakujPizzahozCombo.FormattingEnabled = true;
            this.PizzeriakujPizzahozCombo.Location = new System.Drawing.Point(507, 195);
            this.PizzeriakujPizzahozCombo.Name = "PizzeriakujPizzahozCombo";
            this.PizzeriakujPizzahozCombo.Size = new System.Drawing.Size(262, 28);
            this.PizzeriakujPizzahozCombo.TabIndex = 15;
            this.PizzeriakujPizzahozCombo.Text = "Pizzériák:";
            // 
            // Feltet
            // 
            this.Feltet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Feltet.AutoSize = true;
            this.Feltet.BackColor = System.Drawing.Color.Transparent;
            this.Feltet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Feltet.ForeColor = System.Drawing.Color.White;
            this.Feltet.Location = new System.Drawing.Point(502, 351);
            this.Feltet.Name = "Feltet";
            this.Feltet.Size = new System.Drawing.Size(184, 25);
            this.Feltet.TabIndex = 16;
            this.Feltet.Text = "Új feltét megadása: ";
            // 
            // UjFeltettxt
            // 
            this.UjFeltettxt.Location = new System.Drawing.Point(506, 390);
            this.UjFeltettxt.Name = "UjFeltettxt";
            this.UjFeltettxt.Size = new System.Drawing.Size(373, 26);
            this.UjFeltettxt.TabIndex = 17;
            this.UjFeltettxt.Validating += new System.ComponentModel.CancelEventHandler(this.UjFeltettxt_Validating);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(502, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ár megadása:";
            // 
            // UjArtxt
            // 
            this.UjArtxt.Location = new System.Drawing.Point(506, 481);
            this.UjArtxt.Name = "UjArtxt";
            this.UjArtxt.Size = new System.Drawing.Size(197, 26);
            this.UjArtxt.TabIndex = 19;
            this.UjArtxt.Validating += new System.ComponentModel.CancelEventHandler(this.UjArtxt_Validating);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(502, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Feltét kiválasztása: ";
            // 
            // UjrendelesBtn
            // 
            this.UjrendelesBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.UjrendelesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UjrendelesBtn.ForeColor = System.Drawing.Color.White;
            this.UjrendelesBtn.Location = new System.Drawing.Point(125, 400);
            this.UjrendelesBtn.Name = "UjrendelesBtn";
            this.UjrendelesBtn.Size = new System.Drawing.Size(146, 75);
            this.UjrendelesBtn.TabIndex = 22;
            this.UjrendelesBtn.Text = "Pizzák rendelése";
            this.UjrendelesBtn.UseVisualStyleBackColor = false;
            this.UjrendelesBtn.Click += new System.EventHandler(this.UjrendelesBtn_Click);
            // 
            // TorolniPizzalistbox
            // 
            this.TorolniPizzalistbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TorolniPizzalistbox.FormattingEnabled = true;
            this.TorolniPizzalistbox.ItemHeight = 20;
            this.TorolniPizzalistbox.Location = new System.Drawing.Point(1057, 119);
            this.TorolniPizzalistbox.Name = "TorolniPizzalistbox";
            this.TorolniPizzalistbox.Size = new System.Drawing.Size(207, 344);
            this.TorolniPizzalistbox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1025, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Törölni kívánt pizza kiválasztása:";
            // 
            // FeltetekCombo
            // 
            this.FeltetekCombo.FormattingEnabled = true;
            this.FeltetekCombo.Location = new System.Drawing.Point(376, 294);
            this.FeltetekCombo.Name = "FeltetekCombo";
            this.FeltetekCombo.Size = new System.Drawing.Size(632, 28);
            this.FeltetekCombo.TabIndex = 27;
            this.FeltetekCombo.Text = "Feltétek:";
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.hatterkep;
            this.ClientSize = new System.Drawing.Size(1334, 684);
            this.Controls.Add(this.FeltetekCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TorolniPizzalistbox);
            this.Controls.Add(this.UjrendelesBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UjArtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UjFeltettxt);
            this.Controls.Add(this.Feltet);
            this.Controls.Add(this.PizzeriakujPizzahozCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StartPageBtn);
            this.Controls.Add(this.PizzaTorlesBtn);
            this.Controls.Add(this.PizzeriaTorlesBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UjPizzanevtxt);
            this.Controls.Add(this.UjPizzaFelveszBtn);
            this.Controls.Add(this.PizzeriaFelvetelBtn);
            this.Controls.Add(this.pizzeriaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PizzaCombo);
            this.Controls.Add(this.PizzeriaCombo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Modify";
            this.Text = "Modify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PizzeriaCombo;
        private System.Windows.Forms.ComboBox PizzaCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pizzeriaTxt;
        private System.Windows.Forms.Button PizzeriaFelvetelBtn;
        private System.Windows.Forms.Button UjPizzaFelveszBtn;
        private System.Windows.Forms.TextBox UjPizzanevtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PizzeriaTorlesBtn;
        private System.Windows.Forms.Button PizzaTorlesBtn;
        private System.Windows.Forms.Button StartPageBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PizzeriakujPizzahozCombo;
        private System.Windows.Forms.Label Feltet;
        private System.Windows.Forms.TextBox UjFeltettxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UjArtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UjrendelesBtn;
        private System.Windows.Forms.ListBox TorolniPizzalistbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox FeltetekCombo;
    }
}