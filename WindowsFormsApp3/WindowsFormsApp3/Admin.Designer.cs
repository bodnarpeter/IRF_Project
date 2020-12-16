namespace WindowsFormsApp3
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderTitleDataGridView = new System.Windows.Forms.DataGridView();
            this.pizzaListDataGridView = new System.Windows.Forms.DataGridView();
            this.pizzeriaDataGridView = new System.Windows.Forms.DataGridView();
            this.orderLabel = new System.Windows.Forms.Label();
            this.orderTitlesLabel = new System.Windows.Forms.Label();
            this.pizzeriaListlabel = new System.Windows.Forms.Label();
            this.pizzzalistLabel = new System.Windows.Forms.Label();
            this.KezdolapBtn = new System.Windows.Forms.Button();
            this.KilepesBtn = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzeriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
            this.orderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTitleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTitleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderBindingNavigator
            // 
            this.orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderBindingNavigator.BindingSource = this.orderBindingSource;
            this.orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orderBindingNavigatorSaveItem});
            this.orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderBindingNavigator.Name = "orderBindingNavigator";
            this.orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderBindingNavigator.Size = new System.Drawing.Size(1791, 38);
            this.orderBindingNavigator.TabIndex = 0;
            this.orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(170, 78);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 62;
            this.orderDataGridView.RowTemplate.Height = 28;
            this.orderDataGridView.Size = new System.Drawing.Size(528, 240);
            this.orderDataGridView.TabIndex = 1;
            // 
            // orderTitleDataGridView
            // 
            this.orderTitleDataGridView.AllowUserToAddRows = false;
            this.orderTitleDataGridView.AllowUserToDeleteRows = false;
            this.orderTitleDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderTitleDataGridView.AutoGenerateColumns = false;
            this.orderTitleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTitleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.orderTitleDataGridView.DataSource = this.orderTitleBindingSource;
            this.orderTitleDataGridView.Location = new System.Drawing.Point(709, 78);
            this.orderTitleDataGridView.Name = "orderTitleDataGridView";
            this.orderTitleDataGridView.RowHeadersWidth = 62;
            this.orderTitleDataGridView.RowTemplate.Height = 28;
            this.orderTitleDataGridView.Size = new System.Drawing.Size(547, 240);
            this.orderTitleDataGridView.TabIndex = 2;
            // 
            // pizzaListDataGridView
            // 
            this.pizzaListDataGridView.AllowUserToAddRows = false;
            this.pizzaListDataGridView.AllowUserToDeleteRows = false;
            this.pizzaListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pizzaListDataGridView.AutoGenerateColumns = false;
            this.pizzaListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pizzaListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.pizzaListDataGridView.DataSource = this.pizzaListBindingSource;
            this.pizzaListDataGridView.Location = new System.Drawing.Point(709, 365);
            this.pizzaListDataGridView.Name = "pizzaListDataGridView";
            this.pizzaListDataGridView.RowHeadersWidth = 62;
            this.pizzaListDataGridView.RowTemplate.Height = 28;
            this.pizzaListDataGridView.Size = new System.Drawing.Size(547, 328);
            this.pizzaListDataGridView.TabIndex = 3;
            // 
            // pizzeriaDataGridView
            // 
            this.pizzeriaDataGridView.AllowUserToAddRows = false;
            this.pizzeriaDataGridView.AllowUserToDeleteRows = false;
            this.pizzeriaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pizzeriaDataGridView.AutoGenerateColumns = false;
            this.pizzeriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pizzeriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20});
            this.pizzeriaDataGridView.DataSource = this.pizzeriaBindingSource;
            this.pizzeriaDataGridView.Location = new System.Drawing.Point(170, 365);
            this.pizzeriaDataGridView.Name = "pizzeriaDataGridView";
            this.pizzeriaDataGridView.RowHeadersWidth = 62;
            this.pizzeriaDataGridView.RowTemplate.Height = 28;
            this.pizzeriaDataGridView.Size = new System.Drawing.Size(528, 328);
            this.pizzeriaDataGridView.TabIndex = 4;
            // 
            // orderLabel
            // 
            this.orderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderLabel.AutoSize = true;
            this.orderLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderLabel.ForeColor = System.Drawing.Color.White;
            this.orderLabel.Location = new System.Drawing.Point(170, 55);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(168, 25);
            this.orderLabel.TabIndex = 5;
            this.orderLabel.Text = "Rendelések tábla:";
            // 
            // orderTitlesLabel
            // 
            this.orderTitlesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderTitlesLabel.AutoSize = true;
            this.orderTitlesLabel.BackColor = System.Drawing.Color.Transparent;
            this.orderTitlesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderTitlesLabel.ForeColor = System.Drawing.Color.White;
            this.orderTitlesLabel.Location = new System.Drawing.Point(705, 55);
            this.orderTitlesLabel.Name = "orderTitlesLabel";
            this.orderTitlesLabel.Size = new System.Drawing.Size(219, 25);
            this.orderTitlesLabel.TabIndex = 6;
            this.orderTitlesLabel.Text = "Rendelési elemek tábla:";
            // 
            // pizzeriaListlabel
            // 
            this.pizzeriaListlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pizzeriaListlabel.AutoSize = true;
            this.pizzeriaListlabel.BackColor = System.Drawing.Color.Transparent;
            this.pizzeriaListlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pizzeriaListlabel.ForeColor = System.Drawing.Color.White;
            this.pizzeriaListlabel.Location = new System.Drawing.Point(170, 337);
            this.pizzeriaListlabel.Name = "pizzeriaListlabel";
            this.pizzeriaListlabel.Size = new System.Drawing.Size(144, 25);
            this.pizzeriaListlabel.TabIndex = 7;
            this.pizzeriaListlabel.Text = "Pizzériák tábla:";
            // 
            // pizzzalistLabel
            // 
            this.pizzzalistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pizzzalistLabel.AutoSize = true;
            this.pizzzalistLabel.BackColor = System.Drawing.Color.Transparent;
            this.pizzzalistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pizzzalistLabel.ForeColor = System.Drawing.Color.White;
            this.pizzzalistLabel.Location = new System.Drawing.Point(705, 337);
            this.pizzzalistLabel.Name = "pizzzalistLabel";
            this.pizzzalistLabel.Size = new System.Drawing.Size(123, 25);
            this.pizzzalistLabel.TabIndex = 8;
            this.pizzzalistLabel.Text = "Pizzák tábla:";
            // 
            // KezdolapBtn
            // 
            this.KezdolapBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.KezdolapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KezdolapBtn.ForeColor = System.Drawing.Color.White;
            this.KezdolapBtn.Location = new System.Drawing.Point(25, 175);
            this.KezdolapBtn.Name = "KezdolapBtn";
            this.KezdolapBtn.Size = new System.Drawing.Size(128, 88);
            this.KezdolapBtn.TabIndex = 9;
            this.KezdolapBtn.Text = "Vissza a kezdőlapra";
            this.KezdolapBtn.UseVisualStyleBackColor = false;
            this.KezdolapBtn.Click += new System.EventHandler(this.KezdolapBtn_Click);
            // 
            // KilepesBtn
            // 
            this.KilepesBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.KilepesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KilepesBtn.ForeColor = System.Drawing.Color.White;
            this.KilepesBtn.Location = new System.Drawing.Point(25, 381);
            this.KilepesBtn.Name = "KilepesBtn";
            this.KilepesBtn.Size = new System.Drawing.Size(128, 88);
            this.KilepesBtn.TabIndex = 10;
            this.KilepesBtn.Text = "Kilépés";
            this.KilepesBtn.UseVisualStyleBackColor = false;
            this.KilepesBtn.Click += new System.EventHandler(this.KilepesBtn_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Enabled = false;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderBindingNavigatorSaveItem.Enabled = false;
            this.orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderBindingNavigatorSaveItem.Image")));
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.orderBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "pizzeriaName";
            this.dataGridViewTextBoxColumn20.HeaderText = "Pizzéria";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 150;
            // 
            // pizzeriaBindingSource
            // 
            this.pizzeriaBindingSource.DataSource = typeof(WindowsFormsApp3.Pizzeria);
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "pizzaID";
            this.dataGridViewTextBoxColumn12.HeaderText = "pizzaID";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "pizzaName";
            this.dataGridViewTextBoxColumn13.HeaderText = "Pizza";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn14.HeaderText = "Ár (Ft)";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "pizzeriaFK";
            this.dataGridViewTextBoxColumn15.HeaderText = "pizzeriaFK";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn16.HeaderText = "Feltét";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 150;
            // 
            // pizzaListBindingSource
            // 
            this.pizzaListBindingSource.DataSource = typeof(WindowsFormsApp3.PizzaList);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "titleSK";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sorszám";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "pizzaFK";
            this.dataGridViewTextBoxColumn6.HeaderText = "pizzaFK";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "orderFK";
            this.dataGridViewTextBoxColumn7.HeaderText = "orderFK";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "pizzaName";
            this.dataGridViewTextBoxColumn8.HeaderText = "Pizza";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ár (Ft)";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // orderTitleBindingSource
            // 
            this.orderTitleBindingSource.DataSource = typeof(WindowsFormsApp3.OrderTitle);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "orderdate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rendelés dátuma";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ár (Ft)";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(WindowsFormsApp3.Order);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.hatterkep;
            this.ClientSize = new System.Drawing.Size(1791, 705);
            this.Controls.Add(this.KilepesBtn);
            this.Controls.Add(this.KezdolapBtn);
            this.Controls.Add(this.pizzzalistLabel);
            this.Controls.Add(this.pizzeriaListlabel);
            this.Controls.Add(this.orderTitlesLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.pizzeriaDataGridView);
            this.Controls.Add(this.pizzaListDataGridView);
            this.Controls.Add(this.orderTitleDataGridView);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.orderBindingNavigator);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
            this.orderBindingNavigator.ResumeLayout(false);
            this.orderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTitleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingNavigator orderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.BindingSource orderTitleBindingSource;
        private System.Windows.Forms.DataGridView orderTitleDataGridView;
        private System.Windows.Forms.BindingSource pizzaListBindingSource;
        private System.Windows.Forms.DataGridView pizzaListDataGridView;
        private System.Windows.Forms.BindingSource pizzeriaBindingSource;
        private System.Windows.Forms.DataGridView pizzeriaDataGridView;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label orderTitlesLabel;
        private System.Windows.Forms.Label pizzeriaListlabel;
        private System.Windows.Forms.Label pizzzalistLabel;
        private System.Windows.Forms.Button KezdolapBtn;
        private System.Windows.Forms.Button KilepesBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    }
}