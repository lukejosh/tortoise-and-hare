namespace HareAndTortoise {
    partial class HareAndTortoise_Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gameBoardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.RollDice = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NumberOfPlayers = new System.Windows.Forms.ComboBox();
            this.Players = new System.Windows.Forms.Label();
            this.HareAndTortoise = new System.Windows.Forms.Label();
            this.playerTokenImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasWonDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.playerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.hareAndTortoiseGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareAndTortoiseGameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.gameBoardPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.Reset);
            this.splitContainer.Panel2.Controls.Add(this.Exit);
            this.splitContainer.Panel2.Controls.Add(this.RollDice);
            this.splitContainer.Panel2.Controls.Add(this.listBox1);
            this.splitContainer.Panel2.Controls.Add(this.NumberOfPlayers);
            this.splitContainer.Panel2.Controls.Add(this.Players);
            this.splitContainer.Panel2.Controls.Add(this.HareAndTortoise);
            this.splitContainer.Size = new System.Drawing.Size(884, 662);
            this.splitContainer.SplitterDistance = 663;
            this.splitContainer.TabIndex = 0;
            // 
            // gameBoardPanel
            // 
            this.gameBoardPanel.AutoSize = true;
            this.gameBoardPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gameBoardPanel.ColumnCount = 7;
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28204F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28633F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28633F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28633F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28633F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28633F));
            this.gameBoardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28633F));
            this.gameBoardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.gameBoardPanel.Name = "gameBoardPanel";
            this.gameBoardPanel.RowCount = 8;
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.gameBoardPanel.Size = new System.Drawing.Size(663, 662);
            this.gameBoardPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerTokenImageDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn,
            this.hasWonDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.playerBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(20, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(199, 172);
            this.dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of Players:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reset
            // 
            this.Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset.Location = new System.Drawing.Point(19, 627);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Location = new System.Drawing.Point(137, 627);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RollDice
            // 
            this.RollDice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RollDice.Location = new System.Drawing.Point(70, 586);
            this.RollDice.Name = "RollDice";
            this.RollDice.Size = new System.Drawing.Size(75, 23);
            this.RollDice.TabIndex = 5;
            this.RollDice.Text = "Roll Dice";
            this.RollDice.UseVisualStyleBackColor = true;
            this.RollDice.Click += new System.EventHandler(this.RollDice_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 355);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 212);
            this.listBox1.TabIndex = 4;
            // 
            // NumberOfPlayers
            // 
            this.NumberOfPlayers.FormattingEnabled = true;
            this.NumberOfPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.NumberOfPlayers.Location = new System.Drawing.Point(151, 71);
            this.NumberOfPlayers.MaxDropDownItems = 5;
            this.NumberOfPlayers.Name = "NumberOfPlayers";
            this.NumberOfPlayers.Size = new System.Drawing.Size(34, 21);
            this.NumberOfPlayers.TabIndex = 2;
            this.NumberOfPlayers.SelectedIndexChanged += new System.EventHandler(this.NumberOfPlayers_SelectedIndexChanged);
            // 
            // Players
            // 
            this.Players.AutoSize = true;
            this.Players.Font = new System.Drawing.Font("Book Antiqua", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Players.Location = new System.Drawing.Point(58, 105);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(87, 26);
            this.Players.TabIndex = 1;
            this.Players.Text = "Players";
            // 
            // HareAndTortoise
            // 
            this.HareAndTortoise.AutoSize = true;
            this.HareAndTortoise.Font = new System.Drawing.Font("Book Antiqua", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HareAndTortoise.ForeColor = System.Drawing.Color.Tomato;
            this.HareAndTortoise.Location = new System.Drawing.Point(14, 26);
            this.HareAndTortoise.Name = "HareAndTortoise";
            this.HareAndTortoise.Size = new System.Drawing.Size(190, 26);
            this.HareAndTortoise.TabIndex = 0;
            this.HareAndTortoise.Text = "Hare and Tortoise";
            // 
            // playerTokenImageDataGridViewImageColumn
            // 
            this.playerTokenImageDataGridViewImageColumn.DataPropertyName = "PlayerTokenImage";
            this.playerTokenImageDataGridViewImageColumn.HeaderText = "Colour";
            this.playerTokenImageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.playerTokenImageDataGridViewImageColumn.Name = "playerTokenImageDataGridViewImageColumn";
            this.playerTokenImageDataGridViewImageColumn.ReadOnly = true;
            this.playerTokenImageDataGridViewImageColumn.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "$";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.moneyDataGridViewTextBoxColumn.Width = 30;
            // 
            // hasWonDataGridViewCheckBoxColumn
            // 
            this.hasWonDataGridViewCheckBoxColumn.DataPropertyName = "HasWon";
            this.hasWonDataGridViewCheckBoxColumn.HeaderText = "Winner";
            this.hasWonDataGridViewCheckBoxColumn.Name = "hasWonDataGridViewCheckBoxColumn";
            this.hasWonDataGridViewCheckBoxColumn.ReadOnly = true;
            this.hasWonDataGridViewCheckBoxColumn.Width = 50;
            // 
            // playerBindingSource4
            // 
            this.playerBindingSource4.DataSource = typeof(Player_Class_Library.Player);
            // 
            // hareAndTortoiseGameBindingSource
            // 
            this.hareAndTortoiseGameBindingSource.DataSource = typeof(HareAndTortoise.HareAndTortoise_Game);
            // 
            // playerBindingSource3
            // 
            this.playerBindingSource3.DataSource = typeof(Player_Class_Library.Player);
            // 
            // playerBindingSource2
            // 
            this.playerBindingSource2.DataSource = typeof(Player_Class_Library.Player);
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(Player_Class_Library.Player);
            // 
            // playerBindingSource1
            // 
            this.playerBindingSource1.DataSource = typeof(Player_Class_Library.Player);
            // 
            // HareAndTortoise_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.splitContainer);
            this.Name = "HareAndTortoise_Form";
            this.Text = "Hare and Tortoise";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareAndTortoiseGameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel gameBoardPanel;
        private System.Windows.Forms.ComboBox NumberOfPlayers;
        private System.Windows.Forms.Label Players;
        private System.Windows.Forms.Label HareAndTortoise;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.BindingSource playerBindingSource1;
        private System.Windows.Forms.BindingSource playerBindingSource2;
        private System.Windows.Forms.BindingSource playerBindingSource3;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button RollDice;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource playerBindingSource4;
        private System.Windows.Forms.BindingSource hareAndTortoiseGameBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn playerTokenImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasWonDataGridViewCheckBoxColumn;
    }
}

