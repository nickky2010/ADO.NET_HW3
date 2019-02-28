namespace Model_First
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byCatNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byAgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byOwnerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namesOfCatsInAlphabeticalOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDiagramByOwnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageAgeOfCatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoHaveMoreThanTwoCatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addCatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOwnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.editToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byCatNameToolStripMenuItem,
            this.byAgeToolStripMenuItem,
            this.byOwnerNameToolStripMenuItem,
            this.namesOfCatsInAlphabeticalOrderToolStripMenuItem,
            this.allCatsToolStripMenuItem});
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // byCatNameToolStripMenuItem
            // 
            this.byCatNameToolStripMenuItem.Name = "byCatNameToolStripMenuItem";
            this.byCatNameToolStripMenuItem.Size = new System.Drawing.Size(385, 30);
            this.byCatNameToolStripMenuItem.Text = "by cat name";
            this.byCatNameToolStripMenuItem.Click += new System.EventHandler(this.byCatNameToolStripMenuItem_Click);
            // 
            // byAgeToolStripMenuItem
            // 
            this.byAgeToolStripMenuItem.Name = "byAgeToolStripMenuItem";
            this.byAgeToolStripMenuItem.Size = new System.Drawing.Size(385, 30);
            this.byAgeToolStripMenuItem.Text = "by age";
            this.byAgeToolStripMenuItem.Click += new System.EventHandler(this.byAgeToolStripMenuItem_Click);
            // 
            // byOwnerNameToolStripMenuItem
            // 
            this.byOwnerNameToolStripMenuItem.Name = "byOwnerNameToolStripMenuItem";
            this.byOwnerNameToolStripMenuItem.Size = new System.Drawing.Size(385, 30);
            this.byOwnerNameToolStripMenuItem.Text = "by owner name";
            this.byOwnerNameToolStripMenuItem.Click += new System.EventHandler(this.byOwnerNameToolStripMenuItem_Click);
            // 
            // namesOfCatsInAlphabeticalOrderToolStripMenuItem
            // 
            this.namesOfCatsInAlphabeticalOrderToolStripMenuItem.Name = "namesOfCatsInAlphabeticalOrderToolStripMenuItem";
            this.namesOfCatsInAlphabeticalOrderToolStripMenuItem.Size = new System.Drawing.Size(385, 30);
            this.namesOfCatsInAlphabeticalOrderToolStripMenuItem.Text = "names of cats in alphabetical order";
            this.namesOfCatsInAlphabeticalOrderToolStripMenuItem.Click += new System.EventHandler(this.namesOfCatsInAlphabeticalOrderToolStripMenuItem_Click);
            // 
            // allCatsToolStripMenuItem
            // 
            this.allCatsToolStripMenuItem.Name = "allCatsToolStripMenuItem";
            this.allCatsToolStripMenuItem.Size = new System.Drawing.Size(385, 30);
            this.allCatsToolStripMenuItem.Text = "all cats";
            this.allCatsToolStripMenuItem.Click += new System.EventHandler(this.allCatsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCatToolStripMenuItem,
            this.addOwnerToolStripMenuItem,
            this.deleteCatToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDiagramByOwnersToolStripMenuItem,
            this.averageAgeOfCatsToolStripMenuItem,
            this.whoHaveMoreThanTwoCatsToolStripMenuItem});
            this.statisticsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // showDiagramByOwnersToolStripMenuItem
            // 
            this.showDiagramByOwnersToolStripMenuItem.Name = "showDiagramByOwnersToolStripMenuItem";
            this.showDiagramByOwnersToolStripMenuItem.Size = new System.Drawing.Size(337, 30);
            this.showDiagramByOwnersToolStripMenuItem.Text = "show diagram by owners";
            this.showDiagramByOwnersToolStripMenuItem.Click += new System.EventHandler(this.showDiagramByOwnersToolStripMenuItem_Click);
            // 
            // averageAgeOfCatsToolStripMenuItem
            // 
            this.averageAgeOfCatsToolStripMenuItem.Name = "averageAgeOfCatsToolStripMenuItem";
            this.averageAgeOfCatsToolStripMenuItem.Size = new System.Drawing.Size(337, 30);
            this.averageAgeOfCatsToolStripMenuItem.Text = "average age of cats";
            this.averageAgeOfCatsToolStripMenuItem.Click += new System.EventHandler(this.averageAgeOfCatsToolStripMenuItem_Click);
            // 
            // whoHaveMoreThanTwoCatsToolStripMenuItem
            // 
            this.whoHaveMoreThanTwoCatsToolStripMenuItem.Name = "whoHaveMoreThanTwoCatsToolStripMenuItem";
            this.whoHaveMoreThanTwoCatsToolStripMenuItem.Size = new System.Drawing.Size(337, 30);
            this.whoHaveMoreThanTwoCatsToolStripMenuItem.Text = "who have more than two cats";
            this.whoHaveMoreThanTwoCatsToolStripMenuItem.Click += new System.EventHandler(this.whoHaveMoreThanTwoCatsToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(379, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(431, 314);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(153, 45);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(174, 28);
            this.textBoxSearch.TabIndex = 3;
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchBy.Location = new System.Drawing.Point(12, 48);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(90, 24);
            this.labelSearchBy.TabIndex = 4;
            this.labelSearchBy.Text = "Cat name";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(12, 88);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(316, 37);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 31);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(361, 314);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Model_First.Properties.Resources.Catdefault1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // addCatToolStripMenuItem
            // 
            this.addCatToolStripMenuItem.Name = "addCatToolStripMenuItem";
            this.addCatToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.addCatToolStripMenuItem.Text = "add cat";
            this.addCatToolStripMenuItem.Click += new System.EventHandler(this.addCatToolStripMenuItem_Click);
            // 
            // addOwnerToolStripMenuItem
            // 
            this.addOwnerToolStripMenuItem.Name = "addOwnerToolStripMenuItem";
            this.addOwnerToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.addOwnerToolStripMenuItem.Text = "add owner";
            this.addOwnerToolStripMenuItem.Click += new System.EventHandler(this.addOwnerToolStripMenuItem_Click);
            // 
            // deleteCatToolStripMenuItem
            // 
            this.deleteCatToolStripMenuItem.Name = "deleteCatToolStripMenuItem";
            this.deleteCatToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.deleteCatToolStripMenuItem.Text = "delete cat";
            this.deleteCatToolStripMenuItem.Click += new System.EventHandler(this.deleteCatToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 361);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSearchBy);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chart1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cats and owners";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byCatNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byAgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byOwnerNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem namesOfCatsInAlphabeticalOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDiagramByOwnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageAgeOfCatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoHaveMoreThanTwoCatsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem addCatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOwnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCatToolStripMenuItem;
    }
}

