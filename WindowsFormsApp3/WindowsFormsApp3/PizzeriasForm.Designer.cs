namespace WindowsFormsApp3
{
    partial class PizzeriasForm
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
            this.listBoxPizzerias = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pizzeriaszures = new System.Windows.Forms.TextBox();
            this.KosarbateszBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.kosártartalmadgv = new System.Windows.Forms.DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.kosarboltorol = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rendelesfelvet = new System.Windows.Forms.Button();
            this.összesit = new System.Windows.Forms.Label();
            this.kilepesrendelesnelkulbtn = new System.Windows.Forms.Button();
            this.rendeleseimbtn = new System.Windows.Forms.Button();
            this.pizzakdgw = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pizzaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kosártartalmadgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzakdgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPizzerias
            // 
            this.listBoxPizzerias.FormattingEnabled = true;
            this.listBoxPizzerias.ItemHeight = 20;
            this.listBoxPizzerias.Location = new System.Drawing.Point(44, 105);
            this.listBoxPizzerias.Name = "listBoxPizzerias";
            this.listBoxPizzerias.Size = new System.Drawing.Size(224, 364);
            this.listBoxPizzerias.TabIndex = 0;
            this.listBoxPizzerias.SelectedIndexChanged += new System.EventHandler(this.ListBoxPizzerias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Válassz a pizzériák közül:";
            // 
            // pizzeriaszures
            // 
            this.pizzeriaszures.Location = new System.Drawing.Point(44, 73);
            this.pizzeriaszures.Name = "pizzeriaszures";
            this.pizzeriaszures.Size = new System.Drawing.Size(136, 26);
            this.pizzeriaszures.TabIndex = 2;
            this.pizzeriaszures.TextChanged += new System.EventHandler(this.TextPizzeriaszures_TextChanged);
            // 
            // KosarbateszBtn
            // 
            this.KosarbateszBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KosarbateszBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.KosarbateszBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KosarbateszBtn.ForeColor = System.Drawing.Color.White;
            this.KosarbateszBtn.Location = new System.Drawing.Point(1027, 180);
            this.KosarbateszBtn.Name = "KosarbateszBtn";
            this.KosarbateszBtn.Size = new System.Drawing.Size(214, 96);
            this.KosarbateszBtn.TabIndex = 3;
            this.KosarbateszBtn.Text = "Kosárba rakom";
            this.KosarbateszBtn.UseVisualStyleBackColor = false;
            this.KosarbateszBtn.Click += new System.EventHandler(this.KosarbaRak_Click);
            this.KosarbateszBtn.MouseEnter += new System.EventHandler(this.KosarbateszBtn_MouseEnter);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(453, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Válassz a pizzák közül:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SandyBrown;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(45, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 81);
            this.button3.TabIndex = 7;
            this.button3.Text = "Vissza a kezdőlapra";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Kezdolap_Click);
            // 
            // kosártartalmadgv
            // 
            this.kosártartalmadgv.AllowUserToAddRows = false;
            this.kosártartalmadgv.AllowUserToDeleteRows = false;
            this.kosártartalmadgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kosártartalmadgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kosártartalmadgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected});
            this.kosártartalmadgv.Location = new System.Drawing.Point(303, 421);
            this.kosártartalmadgv.Name = "kosártartalmadgv";
            this.kosártartalmadgv.RowHeadersWidth = 62;
            this.kosártartalmadgv.RowTemplate.Height = 28;
            this.kosártartalmadgv.Size = new System.Drawing.Size(718, 223);
            this.kosártartalmadgv.TabIndex = 8;
            // 
            // selected
            // 
            this.selected.HeaderText = "Kiválaszt";
            this.selected.MinimumWidth = 8;
            this.selected.Name = "selected";
            this.selected.Width = 150;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(453, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kosaram tartalma:";
            // 
            // kosarboltorol
            // 
            this.kosarboltorol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kosarboltorol.BackColor = System.Drawing.Color.SandyBrown;
            this.kosarboltorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kosarboltorol.ForeColor = System.Drawing.Color.White;
            this.kosarboltorol.Location = new System.Drawing.Point(1027, 372);
            this.kosarboltorol.Name = "kosarboltorol";
            this.kosarboltorol.Size = new System.Drawing.Size(214, 96);
            this.kosarboltorol.TabIndex = 10;
            this.kosarboltorol.Text = "Kijelölt elem törlése a kosárból";
            this.kosarboltorol.UseVisualStyleBackColor = false;
            this.kosarboltorol.Click += new System.EventHandler(this.KosarbolTorol_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(40, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "szűrés:";
            // 
            // rendelesfelvet
            // 
            this.rendelesfelvet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rendelesfelvet.BackColor = System.Drawing.Color.SandyBrown;
            this.rendelesfelvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rendelesfelvet.ForeColor = System.Drawing.Color.White;
            this.rendelesfelvet.Location = new System.Drawing.Point(1027, 495);
            this.rendelesfelvet.Name = "rendelesfelvet";
            this.rendelesfelvet.Size = new System.Drawing.Size(214, 96);
            this.rendelesfelvet.TabIndex = 12;
            this.rendelesfelvet.Text = "Rendelés felvétele";
            this.rendelesfelvet.UseVisualStyleBackColor = false;
            this.rendelesfelvet.Click += new System.EventHandler(this.Rendelesfelvet_Click);
            // 
            // összesit
            // 
            this.összesit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.összesit.AutoSize = true;
            this.összesit.BackColor = System.Drawing.Color.Transparent;
            this.összesit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.összesit.ForeColor = System.Drawing.Color.White;
            this.összesit.Location = new System.Drawing.Point(801, 665);
            this.összesit.Name = "összesit";
            this.összesit.Size = new System.Drawing.Size(107, 25);
            this.összesit.TabIndex = 13;
            this.összesit.Text = "Összesen:";
            // 
            // kilepesrendelesnelkulbtn
            // 
            this.kilepesrendelesnelkulbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.kilepesrendelesnelkulbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilepesrendelesnelkulbtn.ForeColor = System.Drawing.Color.White;
            this.kilepesrendelesnelkulbtn.Location = new System.Drawing.Point(45, 566);
            this.kilepesrendelesnelkulbtn.Name = "kilepesrendelesnelkulbtn";
            this.kilepesrendelesnelkulbtn.Size = new System.Drawing.Size(223, 90);
            this.kilepesrendelesnelkulbtn.TabIndex = 15;
            this.kilepesrendelesnelkulbtn.Text = "Kilépés rendelés nélkül";
            this.kilepesrendelesnelkulbtn.UseVisualStyleBackColor = false;
            this.kilepesrendelesnelkulbtn.Click += new System.EventHandler(this.Kilepesrendelesnelkulbtn_Click);
            // 
            // rendeleseimbtn
            // 
            this.rendeleseimbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rendeleseimbtn.BackColor = System.Drawing.Color.SandyBrown;
            this.rendeleseimbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rendeleseimbtn.ForeColor = System.Drawing.Color.White;
            this.rendeleseimbtn.Location = new System.Drawing.Point(1027, 609);
            this.rendeleseimbtn.Name = "rendeleseimbtn";
            this.rendeleseimbtn.Size = new System.Drawing.Size(214, 96);
            this.rendeleseimbtn.TabIndex = 16;
            this.rendeleseimbtn.Text = "Rendeléseim";
            this.rendeleseimbtn.UseVisualStyleBackColor = false;
            this.rendeleseimbtn.Click += new System.EventHandler(this.rendeleseimbtn_Click);
            // 
            // pizzakdgw
            // 
            this.pizzakdgw.AllowUserToAddRows = false;
            this.pizzakdgw.AllowUserToDeleteRows = false;
            this.pizzakdgw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pizzakdgw.AutoGenerateColumns = false;
            this.pizzakdgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pizzakdgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.pizzaIDDataGridViewTextBoxColumn,
            this.pizzaNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.pizzakdgw.DataSource = this.bindingSource1;
            this.pizzakdgw.Location = new System.Drawing.Point(303, 105);
            this.pizzakdgw.Name = "pizzakdgw";
            this.pizzakdgw.RowHeadersWidth = 62;
            this.pizzakdgw.RowTemplate.Height = 28;
            this.pizzakdgw.Size = new System.Drawing.Size(718, 264);
            this.pizzakdgw.TabIndex = 17;
            // 
            // select
            // 
            this.select.DataPropertyName = "select";
            this.select.HeaderText = "Kiválaszt";
            this.select.MinimumWidth = 8;
            this.select.Name = "select";
            this.select.Width = 150;
            // 
            // pizzaIDDataGridViewTextBoxColumn
            // 
            this.pizzaIDDataGridViewTextBoxColumn.DataPropertyName = "pizzaID";
            this.pizzaIDDataGridViewTextBoxColumn.HeaderText = "pizzaID";
            this.pizzaIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pizzaIDDataGridViewTextBoxColumn.Name = "pizzaIDDataGridViewTextBoxColumn";
            this.pizzaIDDataGridViewTextBoxColumn.Visible = false;
            this.pizzaIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // pizzaNameDataGridViewTextBoxColumn
            // 
            this.pizzaNameDataGridViewTextBoxColumn.DataPropertyName = "pizzaName";
            this.pizzaNameDataGridViewTextBoxColumn.HeaderText = "Pizza";
            this.pizzaNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pizzaNameDataGridViewTextBoxColumn.Name = "pizzaNameDataGridViewTextBoxColumn";
            this.pizzaNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Feltét";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Ár(Ft)";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp3.PizzaList);
            // 
            // PizzeriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.hatterkep;
            this.ClientSize = new System.Drawing.Size(1555, 783);
            this.Controls.Add(this.pizzakdgw);
            this.Controls.Add(this.rendeleseimbtn);
            this.Controls.Add(this.kilepesrendelesnelkulbtn);
            this.Controls.Add(this.összesit);
            this.Controls.Add(this.rendelesfelvet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kosarboltorol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kosártartalmadgv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KosarbateszBtn);
            this.Controls.Add(this.pizzeriaszures);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPizzerias);
            this.Name = "PizzeriasForm";
            this.Text = "pizzerias";
            ((System.ComponentModel.ISupportInitialize)(this.kosártartalmadgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzakdgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPizzerias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pizzeriaszures;
        private System.Windows.Forms.Button KosarbateszBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView kosártartalmadgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kosarboltorol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rendelesfelvet;
        private System.Windows.Forms.Label összesit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.Button kilepesrendelesnelkulbtn;
        private System.Windows.Forms.Button rendeleseimbtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView pizzakdgw;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}