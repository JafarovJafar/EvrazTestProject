
namespace EvrazTestProject
{
    partial class VehicleControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PunctureLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.PropertiesTable = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Controls.Add(this.MainPanel);
            this.flowLayoutPanel1.Controls.Add(this.PropertiesTable);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(572, 340);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.LightGray;
            this.MainPanel.Controls.Add(this.PunctureLabel);
            this.MainPanel.Controls.Add(this.ProgressBar);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.TypeLabel);
            this.MainPanel.Location = new System.Drawing.Point(10, 10);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(5);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(5);
            this.MainPanel.Size = new System.Drawing.Size(552, 138);
            this.MainPanel.TabIndex = 1;
            // 
            // PunctureLabel
            // 
            this.PunctureLabel.AutoSize = true;
            this.PunctureLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PunctureLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PunctureLabel.ForeColor = System.Drawing.Color.Red;
            this.PunctureLabel.Location = new System.Drawing.Point(5, 101);
            this.PunctureLabel.Name = "PunctureLabel";
            this.PunctureLabel.Size = new System.Drawing.Size(140, 32);
            this.PunctureLabel.TabIndex = 3;
            this.PunctureLabel.Text = "ПРОКОЛ!!!";
            this.PunctureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(10, 50);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(5);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(532, 29);
            this.ProgressBar.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Location = new System.Drawing.Point(517, 5);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5);
            this.CloseButton.MaximumSize = new System.Drawing.Size(30, 30);
            this.CloseButton.MinimumSize = new System.Drawing.Size(30, 30);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Х";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(10, 10);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(5);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Padding = new System.Windows.Forms.Padding(5);
            this.TypeLabel.Size = new System.Drawing.Size(45, 30);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Тип";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PropertiesTable
            // 
            this.PropertiesTable.AllowUserToAddRows = false;
            this.PropertiesTable.AllowUserToDeleteRows = false;
            this.PropertiesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PropertiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropertiesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.PropertiesTable.Location = new System.Drawing.Point(10, 158);
            this.PropertiesTable.Margin = new System.Windows.Forms.Padding(5);
            this.PropertiesTable.Name = "PropertiesTable";
            this.PropertiesTable.ReadOnly = true;
            this.PropertiesTable.RowHeadersVisible = false;
            this.PropertiesTable.RowHeadersWidth = 51;
            this.PropertiesTable.RowTemplate.Height = 29;
            this.PropertiesTable.Size = new System.Drawing.Size(552, 172);
            this.PropertiesTable.TabIndex = 2;
            // 
            // Key
            // 
            this.Key.HeaderText = "Название";
            this.Key.MinimumWidth = 6;
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // VehicleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(572, 340);
            this.MinimumSize = new System.Drawing.Size(572, 340);
            this.Name = "VehicleControl";
            this.Size = new System.Drawing.Size(572, 340);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.DataGridView PropertiesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Label PunctureLabel;
    }
}
