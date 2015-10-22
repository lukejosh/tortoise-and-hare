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
            this.Reset = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.RollDice = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.playerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.NumberOfPlayers = new System.Windows.Forms.ComboBox();
            this.Players = new System.Windows.Forms.Label();
            this.HareAndTortoise = new System.Windows.Forms.Label();
            this.playerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.playerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playerTokenImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasWonDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hareAndTortoiseGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareAndTortoiseGameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.splitContainer.Size = new System.Drawing.Size(1179, 815);
            this.splitContainer.SplitterDistance = 885;
            this.splitContainer.SplitterWidth = 5;
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
            this.gameBoardPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.gameBoardPanel.Size = new System.Drawing.Size(885, 815);
            this.gameBoardPanel.TabIndex = 0;
            // 
            // Reset
            // 
            this.Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset.Location = new System.Drawing.Point(26, 772);
            this.Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 28);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Location = new System.Drawing.Point(184, 772);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 28);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // RollDice
            // 
            this.RollDice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RollDice.Location = new System.Drawing.Point(94, 721);
            this.RollDice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RollDice.Name = "RollDice";
            this.RollDice.Size = new System.Drawing.Size(100, 28);
            this.RollDice.TabIndex = 5;
            this.RollDice.Text = "Roll Dice";
            this.RollDice.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(21, 437);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 260);
            this.listBox1.TabIndex = 4;
            // 
            // playerBindingSource3
            // 
            this.playerBindingSource3.DataSource = typeof(Player_Class_Library.Player);
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
            this.NumberOfPlayers.Location = new System.Drawing.Point(201, 87);
            this.NumberOfPlayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberOfPlayers.MaxDropDownItems = 5;
            this.NumberOfPlayers.Name = "NumberOfPlayers";
            this.NumberOfPlayers.Size = new System.Drawing.Size(44, 24);
            this.NumberOfPlayers.TabIndex = 2;
            // 
            // Players
            // 
            this.Players.AutoSize = true;
            this.Players.Font = new System.Drawing.Font("Book Antiqua", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Players.Location = new System.Drawing.Point(77, 129);
            this.Players.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(107, 32);
            this.Players.TabIndex = 1;
            this.Players.Text = "Players";
            // 
            // HareAndTortoise
            // 
            this.HareAndTortoise.AutoSize = true;
            this.HareAndTortoise.Font = new System.Drawing.Font("Book Antiqua", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HareAndTortoise.ForeColor = System.Drawing.Color.Tomato;
            this.HareAndTortoise.Location = new System.Drawing.Point(19, 32);
            this.HareAndTortoise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HareAndTortoise.Name = "HareAndTortoise";
            this.HareAndTortoise.Size = new System.Drawing.Size(235, 32);
            this.HareAndTortoise.TabIndex = 0;
            this.HareAndTortoise.Text = "Hare and Tortoise";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of Players:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // playerBindingSource4
            // 
            this.playerBindingSource4.DataSource = typeof(Player_Class_Library.Player);
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
            this.dataGridView1.Location = new System.Drawing.Point(26, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(265, 212);
            this.dataGridView1.TabIndex = 9;
            // 
            // playerTokenImageDataGridViewImageColumn
            // 
            this.playerTokenImageDataGridViewImageColumn.DataPropertyName = "PlayerTokenImage";
            this.playerTokenImageDataGridViewImageColumn.HeaderText = "Colour";
            this.playerTokenImageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.playerTokenImageDataGridViewImageColumn.Name = "playerTokenImageDataGridViewImageColumn";
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
            this.moneyDataGridViewTextBoxColumn.Width = 30;
            // 
            // hasWonDataGridViewCheckBoxColumn
            // 
            this.hasWonDataGridViewCheckBoxColumn.DataPropertyName = "HasWon";
            this.hasWonDataGridViewCheckBoxColumn.HeaderText = "Winner";
            this.hasWonDataGridViewCheckBoxColumn.Name = "hasWonDataGridViewCheckBoxColumn";
            this.hasWonDataGridViewCheckBoxColumn.Width = 50;
            // 
            // hareAndTortoiseGameBindingSource
            // 
            this.hareAndTortoiseGameBindingSource.DataSource = typeof(HareAndTortoise.HareAndTortoise_Game);
            // 
            // HareAndTortoise_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 815);
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HareAndTortoise_Form";
            this.Text = "Hare and Tortoise";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareAndTortoiseGameBindingSource)).EndInit();
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

