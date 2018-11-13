namespace ShardCalculator
{
    partial class CalculateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateForm));
            this.shardMultiplierLabel = new System.Windows.Forms.Label();
            this.currentLevelLabel = new System.Windows.Forms.Label();
            this.currentExperienceLabel = new System.Windows.Forms.Label();
            this.totalShardsLabel = new System.Windows.Forms.Label();
            this.shardMultiplierBox = new System.Windows.Forms.TextBox();
            this.currentLevelBox = new System.Windows.Forms.TextBox();
            this.shardCountBox = new System.Windows.Forms.TextBox();
            this.currentExperienceBox = new System.Windows.Forms.TextBox();
            this.calculationBox = new System.Windows.Forms.ListView();
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Shards = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calculateButton = new System.Windows.Forms.Button();
            this.experienceLeftBox = new System.Windows.Forms.TextBox();
            this.experienceLeftLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shardMultiplierLabel
            // 
            this.shardMultiplierLabel.AutoSize = true;
            this.shardMultiplierLabel.Location = new System.Drawing.Point(12, 23);
            this.shardMultiplierLabel.Name = "shardMultiplierLabel";
            this.shardMultiplierLabel.Size = new System.Drawing.Size(135, 13);
            this.shardMultiplierLabel.TabIndex = 0;
            this.shardMultiplierLabel.Text = "Shard Experience Multiplier";
            // 
            // currentLevelLabel
            // 
            this.currentLevelLabel.AutoSize = true;
            this.currentLevelLabel.Location = new System.Drawing.Point(77, 79);
            this.currentLevelLabel.Name = "currentLevelLabel";
            this.currentLevelLabel.Size = new System.Drawing.Size(70, 13);
            this.currentLevelLabel.TabIndex = 1;
            this.currentLevelLabel.Text = "Current Level";
            // 
            // currentExperienceLabel
            // 
            this.currentExperienceLabel.AutoSize = true;
            this.currentExperienceLabel.Location = new System.Drawing.Point(50, 137);
            this.currentExperienceLabel.Name = "currentExperienceLabel";
            this.currentExperienceLabel.Size = new System.Drawing.Size(97, 13);
            this.currentExperienceLabel.TabIndex = 2;
            this.currentExperienceLabel.Text = "Current Experience";
            // 
            // totalShardsLabel
            // 
            this.totalShardsLabel.AutoSize = true;
            this.totalShardsLabel.Location = new System.Drawing.Point(80, 204);
            this.totalShardsLabel.Name = "totalShardsLabel";
            this.totalShardsLabel.Size = new System.Drawing.Size(67, 13);
            this.totalShardsLabel.TabIndex = 3;
            this.totalShardsLabel.Text = "Total Shards";
            // 
            // shardMultiplierBox
            // 
            this.shardMultiplierBox.Location = new System.Drawing.Point(167, 20);
            this.shardMultiplierBox.Name = "shardMultiplierBox";
            this.shardMultiplierBox.ReadOnly = true;
            this.shardMultiplierBox.Size = new System.Drawing.Size(75, 20);
            this.shardMultiplierBox.TabIndex = 4;
            this.shardMultiplierBox.Text = "300";
            this.shardMultiplierBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentLevelBox
            // 
            this.currentLevelBox.Location = new System.Drawing.Point(167, 76);
            this.currentLevelBox.MaxLength = 4;
            this.currentLevelBox.Name = "currentLevelBox";
            this.currentLevelBox.Size = new System.Drawing.Size(75, 20);
            this.currentLevelBox.TabIndex = 5;
            this.currentLevelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currentLevelBox.TextChanged += new System.EventHandler(this.currentLevelBoxTextChanged);
            // 
            // shardCountBox
            // 
            this.shardCountBox.Location = new System.Drawing.Point(167, 201);
            this.shardCountBox.MaxLength = 5;
            this.shardCountBox.Name = "shardCountBox";
            this.shardCountBox.Size = new System.Drawing.Size(75, 20);
            this.shardCountBox.TabIndex = 6;
            this.shardCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentExperienceBox
            // 
            this.currentExperienceBox.Location = new System.Drawing.Point(167, 134);
            this.currentExperienceBox.MaxLength = 30;
            this.currentExperienceBox.Name = "currentExperienceBox";
            this.currentExperienceBox.Size = new System.Drawing.Size(75, 20);
            this.currentExperienceBox.TabIndex = 7;
            this.currentExperienceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calculationBox
            // 
            this.calculationBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Level,
            this.Shards});
            this.calculationBox.GridLines = true;
            this.calculationBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.calculationBox.Location = new System.Drawing.Point(276, 20);
            this.calculationBox.MultiSelect = false;
            this.calculationBox.Name = "calculationBox";
            this.calculationBox.Size = new System.Drawing.Size(224, 365);
            this.calculationBox.TabIndex = 8;
            this.calculationBox.TabStop = false;
            this.calculationBox.UseCompatibleStateImageBehavior = false;
            this.calculationBox.View = System.Windows.Forms.View.Details;
            // 
            // Level
            // 
            this.Level.Text = "Level";
            this.Level.Width = 106;
            // 
            // Shards
            // 
            this.Shards.Text = "# Shards Used";
            this.Shards.Width = 92;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(122, 269);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(107, 39);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButtonClick);
            // 
            // experienceLeftBox
            // 
            this.experienceLeftBox.Location = new System.Drawing.Point(167, 338);
            this.experienceLeftBox.Name = "experienceLeftBox";
            this.experienceLeftBox.ReadOnly = true;
            this.experienceLeftBox.Size = new System.Drawing.Size(75, 20);
            this.experienceLeftBox.TabIndex = 10;
            this.experienceLeftBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // experienceLeftLabel
            // 
            this.experienceLeftLabel.Location = new System.Drawing.Point(0, 341);
            this.experienceLeftLabel.Name = "experienceLeftLabel";
            this.experienceLeftLabel.Size = new System.Drawing.Size(161, 13);
            this.experienceLeftLabel.TabIndex = 11;
            this.experienceLeftLabel.Text = "Exp. To Level After Shards";
            this.experienceLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 397);
            this.Controls.Add(this.experienceLeftLabel);
            this.Controls.Add(this.experienceLeftBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.calculationBox);
            this.Controls.Add(this.currentExperienceBox);
            this.Controls.Add(this.shardCountBox);
            this.Controls.Add(this.currentLevelBox);
            this.Controls.Add(this.shardMultiplierBox);
            this.Controls.Add(this.totalShardsLabel);
            this.Controls.Add(this.currentExperienceLabel);
            this.Controls.Add(this.currentLevelLabel);
            this.Controls.Add(this.shardMultiplierLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shard Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shardMultiplierLabel;
        private System.Windows.Forms.Label currentLevelLabel;
        private System.Windows.Forms.Label currentExperienceLabel;
        private System.Windows.Forms.Label totalShardsLabel;
        private System.Windows.Forms.TextBox shardMultiplierBox;
        private System.Windows.Forms.TextBox currentLevelBox;
        private System.Windows.Forms.TextBox shardCountBox;
        private System.Windows.Forms.TextBox currentExperienceBox;
        private System.Windows.Forms.ListView calculationBox;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader Shards;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox experienceLeftBox;
        private System.Windows.Forms.Label experienceLeftLabel;
    }
}

