
namespace EvrazTestProject
{
    partial class Rating
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
            this.RatingTable = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RatingTable)).BeginInit();
            this.SuspendLayout();
            // 
            // RatingTable
            // 
            this.RatingTable.AllowUserToAddRows = false;
            this.RatingTable.AllowUserToDeleteRows = false;
            this.RatingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RatingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Time});
            this.RatingTable.Location = new System.Drawing.Point(10, 10);
            this.RatingTable.Margin = new System.Windows.Forms.Padding(5);
            this.RatingTable.Name = "RatingTable";
            this.RatingTable.ReadOnly = true;
            this.RatingTable.RowHeadersVisible = false;
            this.RatingTable.RowHeadersWidth = 51;
            this.RatingTable.RowTemplate.Height = 29;
            this.RatingTable.Size = new System.Drawing.Size(256, 255);
            this.RatingTable.TabIndex = 0;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(10, 297);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(256, 29);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Рестарт";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 353);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.RatingTable);
            this.MaximumSize = new System.Drawing.Size(300, 400);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Rating";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Rating";
            ((System.ComponentModel.ISupportInitialize)(this.RatingTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RatingTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Button RestartButton;
    }
}