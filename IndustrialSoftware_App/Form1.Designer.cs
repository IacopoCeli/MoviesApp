namespace IndustrialSoftware_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            dataGridView1 = new DataGridView();
            Movie = new DataGridViewTextBoxColumn();
            LeadStudio = new DataGridViewTextBoxColumn();
            RottenTomatoes = new DataGridViewTextBoxColumn();
            AudienceScore = new DataGridViewTextBoxColumn();
            Story = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            TheatersOpenWeek = new DataGridViewTextBoxColumn();
            OpeningWeekend = new DataGridViewTextBoxColumn();
            BOAvgOpenWeekend = new DataGridViewTextBoxColumn();
            DomesticGross = new DataGridViewTextBoxColumn();
            ForeignGross = new DataGridViewTextBoxColumn();
            WorldGross = new DataGridViewTextBoxColumn();
            Budget = new DataGridViewTextBoxColumn();
            Profitability = new DataGridViewTextBoxColumn();
            OpenProfit = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Director = new DataGridViewTextBoxColumn();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Movie, LeadStudio, RottenTomatoes, AudienceScore, Story, Genre, TheatersOpenWeek, OpeningWeekend, BOAvgOpenWeekend, DomesticGross, ForeignGross, WorldGross, Budget, Profitability, OpenProfit, Year, Director });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1587, 813);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            // 
            // Movie
            // 
            Movie.HeaderText = "Movie";
            Movie.MinimumWidth = 8;
            Movie.Name = "Movie";
            Movie.Width = 500;
            // 
            // LeadStudio
            // 
            LeadStudio.HeaderText = "LeadStudio";
            LeadStudio.MinimumWidth = 8;
            LeadStudio.Name = "LeadStudio";
            LeadStudio.Width = 200;
            // 
            // RottenTomatoes
            // 
            RottenTomatoes.HeaderText = "RottenTomatoes";
            RottenTomatoes.MinimumWidth = 8;
            RottenTomatoes.Name = "RottenTomatoes";
            RottenTomatoes.Visible = false;
            RottenTomatoes.Width = 150;
            // 
            // AudienceScore
            // 
            AudienceScore.HeaderText = "AudienceScore";
            AudienceScore.MinimumWidth = 8;
            AudienceScore.Name = "AudienceScore";
            AudienceScore.Visible = false;
            AudienceScore.Width = 150;
            // 
            // Story
            // 
            Story.HeaderText = "Story";
            Story.MinimumWidth = 8;
            Story.Name = "Story";
            Story.Visible = false;
            Story.Width = 150;
            // 
            // Genre
            // 
            Genre.HeaderText = "Genre";
            Genre.MinimumWidth = 8;
            Genre.Name = "Genre";
            Genre.Width = 200;
            // 
            // TheatersOpenWeek
            // 
            TheatersOpenWeek.HeaderText = "TheatersOpenWeek";
            TheatersOpenWeek.MinimumWidth = 8;
            TheatersOpenWeek.Name = "TheatersOpenWeek";
            TheatersOpenWeek.Visible = false;
            TheatersOpenWeek.Width = 150;
            // 
            // OpeningWeekend
            // 
            OpeningWeekend.HeaderText = "OpeningWeekend";
            OpeningWeekend.MinimumWidth = 8;
            OpeningWeekend.Name = "OpeningWeekend";
            OpeningWeekend.Visible = false;
            OpeningWeekend.Width = 150;
            // 
            // BOAvgOpenWeekend
            // 
            BOAvgOpenWeekend.HeaderText = "BOAvgOpenWeekend";
            BOAvgOpenWeekend.MinimumWidth = 8;
            BOAvgOpenWeekend.Name = "BOAvgOpenWeekend";
            BOAvgOpenWeekend.Visible = false;
            BOAvgOpenWeekend.Width = 150;
            // 
            // DomesticGross
            // 
            DomesticGross.HeaderText = "DomesticGross";
            DomesticGross.MinimumWidth = 8;
            DomesticGross.Name = "DomesticGross";
            DomesticGross.Visible = false;
            DomesticGross.Width = 150;
            // 
            // ForeignGross
            // 
            ForeignGross.HeaderText = "ForeignGross";
            ForeignGross.MinimumWidth = 8;
            ForeignGross.Name = "ForeignGross";
            ForeignGross.Visible = false;
            ForeignGross.Width = 150;
            // 
            // WorldGross
            // 
            WorldGross.HeaderText = "WorldGross";
            WorldGross.MinimumWidth = 8;
            WorldGross.Name = "WorldGross";
            WorldGross.Visible = false;
            WorldGross.Width = 150;
            // 
            // Budget
            // 
            Budget.HeaderText = "Budget";
            Budget.MinimumWidth = 8;
            Budget.Name = "Budget";
            Budget.Visible = false;
            Budget.Width = 150;
            // 
            // Profitability
            // 
            Profitability.HeaderText = "Profitability";
            Profitability.MinimumWidth = 8;
            Profitability.Name = "Profitability";
            Profitability.Visible = false;
            Profitability.Width = 150;
            // 
            // OpenProfit
            // 
            OpenProfit.HeaderText = "OpenProfit";
            OpenProfit.MinimumWidth = 8;
            OpenProfit.Name = "OpenProfit";
            OpenProfit.Visible = false;
            OpenProfit.Width = 150;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.MinimumWidth = 8;
            Year.Name = "Year";
            Year.Width = 150;
            // 
            // Director
            // 
            Director.HeaderText = "Director";
            Director.MinimumWidth = 8;
            Director.Name = "Director";
            Director.Width = 200;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(214, 41);
            button1.TabIndex = 1;
            button1.Text = "Upload Data from file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 94F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.Size = new Size(1593, 872);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 822);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1587, 47);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(223, 3);
            button2.Name = "button2";
            button2.Size = new Size(150, 38);
            button2.TabIndex = 3;
            button2.Text = "Save on file";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1593, 872);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridViewTextBoxColumn Movie;
        private DataGridViewTextBoxColumn LeadStudio;
        private DataGridViewTextBoxColumn RottenTomatoes;
        private DataGridViewTextBoxColumn AudienceScore;
        private DataGridViewTextBoxColumn Story;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn TheatersOpenWeek;
        private DataGridViewTextBoxColumn OpeningWeekend;
        private DataGridViewTextBoxColumn BOAvgOpenWeekend;
        private DataGridViewTextBoxColumn DomesticGross;
        private DataGridViewTextBoxColumn ForeignGross;
        private DataGridViewTextBoxColumn WorldGross;
        private DataGridViewTextBoxColumn Budget;
        private DataGridViewTextBoxColumn Profitability;
        private DataGridViewTextBoxColumn OpenProfit;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Director;
    }
}
