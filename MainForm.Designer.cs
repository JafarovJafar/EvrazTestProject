
namespace EvrazTestProject
{
    partial class MainForm
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
            this.VehiclesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.VehicleProperties = new System.Windows.Forms.FlowLayoutPanel();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.PunctureChanceLabel = new System.Windows.Forms.Label();
            this.PunctureChanceTextBox = new System.Windows.Forms.TextBox();
            this.MinPunctureTimeLabel = new System.Windows.Forms.Label();
            this.MinPunctureTimeTextBox = new System.Windows.Forms.TextBox();
            this.MaxPunctureTimeLabel = new System.Windows.Forms.Label();
            this.MaxPunctureTimeTextBox = new System.Windows.Forms.TextBox();
            this.CargoWeightLabel = new System.Windows.Forms.Label();
            this.CargoWeightTextBox = new System.Windows.Forms.TextBox();
            this.PassengersCountLabel = new System.Windows.Forms.Label();
            this.PassengersCountTextBox = new System.Windows.Forms.TextBox();
            this.SideCarCheckBox = new System.Windows.Forms.CheckBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddVehicleButton = new System.Windows.Forms.Button();
            this.StartRaceButton = new System.Windows.Forms.Button();
            this.SidePanel.SuspendLayout();
            this.VehicleProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehiclesContainer
            // 
            this.VehiclesContainer.AutoScroll = true;
            this.VehiclesContainer.BackColor = System.Drawing.Color.DimGray;
            this.VehiclesContainer.Location = new System.Drawing.Point(10, 10);
            this.VehiclesContainer.Margin = new System.Windows.Forms.Padding(5);
            this.VehiclesContainer.Name = "VehiclesContainer";
            this.VehiclesContainer.Padding = new System.Windows.Forms.Padding(5);
            this.VehiclesContainer.Size = new System.Drawing.Size(625, 603);
            this.VehiclesContainer.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DimGray;
            this.SidePanel.Controls.Add(this.VehicleProperties);
            this.SidePanel.Controls.Add(this.TypeComboBox);
            this.SidePanel.Location = new System.Drawing.Point(645, 10);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(5);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Padding = new System.Windows.Forms.Padding(5);
            this.SidePanel.Size = new System.Drawing.Size(231, 525);
            this.SidePanel.TabIndex = 1;
            // 
            // VehicleProperties
            // 
            this.VehicleProperties.BackColor = System.Drawing.Color.Gray;
            this.VehicleProperties.Controls.Add(this.SpeedLabel);
            this.VehicleProperties.Controls.Add(this.SpeedTextBox);
            this.VehicleProperties.Controls.Add(this.DistanceLabel);
            this.VehicleProperties.Controls.Add(this.DistanceTextBox);
            this.VehicleProperties.Controls.Add(this.PunctureChanceLabel);
            this.VehicleProperties.Controls.Add(this.PunctureChanceTextBox);
            this.VehicleProperties.Controls.Add(this.MinPunctureTimeLabel);
            this.VehicleProperties.Controls.Add(this.MinPunctureTimeTextBox);
            this.VehicleProperties.Controls.Add(this.MaxPunctureTimeLabel);
            this.VehicleProperties.Controls.Add(this.MaxPunctureTimeTextBox);
            this.VehicleProperties.Controls.Add(this.CargoWeightLabel);
            this.VehicleProperties.Controls.Add(this.CargoWeightTextBox);
            this.VehicleProperties.Controls.Add(this.PassengersCountLabel);
            this.VehicleProperties.Controls.Add(this.PassengersCountTextBox);
            this.VehicleProperties.Controls.Add(this.SideCarCheckBox);
            this.VehicleProperties.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.VehicleProperties.Location = new System.Drawing.Point(10, 48);
            this.VehicleProperties.Margin = new System.Windows.Forms.Padding(5);
            this.VehicleProperties.Name = "VehicleProperties";
            this.VehicleProperties.Padding = new System.Windows.Forms.Padding(5);
            this.VehicleProperties.Size = new System.Drawing.Size(211, 467);
            this.VehicleProperties.TabIndex = 1;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpeedLabel.Location = new System.Drawing.Point(8, 5);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(179, 20);
            this.SpeedLabel.TabIndex = 0;
            this.SpeedLabel.Text = "Скорость";
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Location = new System.Drawing.Point(8, 28);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(125, 27);
            this.SpeedTextBox.TabIndex = 1;
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DistanceLabel.Location = new System.Drawing.Point(8, 58);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(179, 20);
            this.DistanceLabel.TabIndex = 2;
            this.DistanceLabel.Text = "Дистанция";
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.Location = new System.Drawing.Point(8, 81);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(125, 27);
            this.DistanceTextBox.TabIndex = 6;
            // 
            // PunctureChanceLabel
            // 
            this.PunctureChanceLabel.AutoSize = true;
            this.PunctureChanceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PunctureChanceLabel.Location = new System.Drawing.Point(8, 111);
            this.PunctureChanceLabel.Name = "PunctureChanceLabel";
            this.PunctureChanceLabel.Size = new System.Drawing.Size(179, 20);
            this.PunctureChanceLabel.TabIndex = 3;
            this.PunctureChanceLabel.Text = "Шанс прокола (0-100)";
            // 
            // PunctureChanceTextBox
            // 
            this.PunctureChanceTextBox.Location = new System.Drawing.Point(8, 134);
            this.PunctureChanceTextBox.Name = "PunctureChanceTextBox";
            this.PunctureChanceTextBox.Size = new System.Drawing.Size(125, 27);
            this.PunctureChanceTextBox.TabIndex = 7;
            // 
            // MinPunctureTimeLabel
            // 
            this.MinPunctureTimeLabel.AutoSize = true;
            this.MinPunctureTimeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MinPunctureTimeLabel.Location = new System.Drawing.Point(8, 164);
            this.MinPunctureTimeLabel.Name = "MinPunctureTimeLabel";
            this.MinPunctureTimeLabel.Size = new System.Drawing.Size(179, 40);
            this.MinPunctureTimeLabel.TabIndex = 4;
            this.MinPunctureTimeLabel.Text = "Минимальное время ремонта";
            // 
            // MinPunctureTimeTextBox
            // 
            this.MinPunctureTimeTextBox.Location = new System.Drawing.Point(8, 207);
            this.MinPunctureTimeTextBox.Name = "MinPunctureTimeTextBox";
            this.MinPunctureTimeTextBox.Size = new System.Drawing.Size(125, 27);
            this.MinPunctureTimeTextBox.TabIndex = 8;
            // 
            // MaxPunctureTimeLabel
            // 
            this.MaxPunctureTimeLabel.AutoSize = true;
            this.MaxPunctureTimeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaxPunctureTimeLabel.Location = new System.Drawing.Point(8, 237);
            this.MaxPunctureTimeLabel.Name = "MaxPunctureTimeLabel";
            this.MaxPunctureTimeLabel.Size = new System.Drawing.Size(179, 40);
            this.MaxPunctureTimeLabel.TabIndex = 5;
            this.MaxPunctureTimeLabel.Text = "Максимальное время прокола";
            // 
            // MaxPunctureTimeTextBox
            // 
            this.MaxPunctureTimeTextBox.Location = new System.Drawing.Point(8, 280);
            this.MaxPunctureTimeTextBox.Name = "MaxPunctureTimeTextBox";
            this.MaxPunctureTimeTextBox.Size = new System.Drawing.Size(125, 27);
            this.MaxPunctureTimeTextBox.TabIndex = 9;
            // 
            // CargoWeightLabel
            // 
            this.CargoWeightLabel.AutoSize = true;
            this.CargoWeightLabel.Location = new System.Drawing.Point(8, 310);
            this.CargoWeightLabel.Name = "CargoWeightLabel";
            this.CargoWeightLabel.Size = new System.Drawing.Size(74, 20);
            this.CargoWeightLabel.TabIndex = 12;
            this.CargoWeightLabel.Text = "Вес груза";
            this.CargoWeightLabel.Visible = false;
            // 
            // CargoWeightTextBox
            // 
            this.CargoWeightTextBox.Location = new System.Drawing.Point(8, 333);
            this.CargoWeightTextBox.Name = "CargoWeightTextBox";
            this.CargoWeightTextBox.Size = new System.Drawing.Size(125, 27);
            this.CargoWeightTextBox.TabIndex = 13;
            this.CargoWeightTextBox.Visible = false;
            // 
            // PassengersCountLabel
            // 
            this.PassengersCountLabel.AutoSize = true;
            this.PassengersCountLabel.Location = new System.Drawing.Point(8, 363);
            this.PassengersCountLabel.Name = "PassengersCountLabel";
            this.PassengersCountLabel.Size = new System.Drawing.Size(179, 20);
            this.PassengersCountLabel.TabIndex = 14;
            this.PassengersCountLabel.Text = "Количество пассажиров";
            this.PassengersCountLabel.Visible = false;
            // 
            // PassengersCountTextBox
            // 
            this.PassengersCountTextBox.Location = new System.Drawing.Point(8, 386);
            this.PassengersCountTextBox.Name = "PassengersCountTextBox";
            this.PassengersCountTextBox.Size = new System.Drawing.Size(125, 27);
            this.PassengersCountTextBox.TabIndex = 15;
            this.PassengersCountTextBox.Visible = false;
            // 
            // SideCarCheckBox
            // 
            this.SideCarCheckBox.AutoSize = true;
            this.SideCarCheckBox.Location = new System.Drawing.Point(8, 419);
            this.SideCarCheckBox.Name = "SideCarCheckBox";
            this.SideCarCheckBox.Size = new System.Drawing.Size(87, 24);
            this.SideCarCheckBox.TabIndex = 16;
            this.SideCarCheckBox.Text = "Коляска";
            this.SideCarCheckBox.UseVisualStyleBackColor = true;
            this.SideCarCheckBox.Visible = false;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Location = new System.Drawing.Point(10, 10);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(211, 28);
            this.TypeComboBox.TabIndex = 0;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.Location = new System.Drawing.Point(645, 545);
            this.AddVehicleButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddVehicleButton.Name = "AddVehicleButton";
            this.AddVehicleButton.Size = new System.Drawing.Size(231, 29);
            this.AddVehicleButton.TabIndex = 2;
            this.AddVehicleButton.Text = "Добавить";
            this.AddVehicleButton.UseVisualStyleBackColor = true;
            this.AddVehicleButton.Click += new System.EventHandler(this.AddVehicleButton_Click);
            // 
            // StartRaceButton
            // 
            this.StartRaceButton.Location = new System.Drawing.Point(645, 584);
            this.StartRaceButton.Margin = new System.Windows.Forms.Padding(5);
            this.StartRaceButton.Name = "StartRaceButton";
            this.StartRaceButton.Size = new System.Drawing.Size(231, 29);
            this.StartRaceButton.TabIndex = 3;
            this.StartRaceButton.Text = "Начать";
            this.StartRaceButton.UseVisualStyleBackColor = true;
            this.StartRaceButton.Click += new System.EventHandler(this.StartRaceButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(886, 623);
            this.Controls.Add(this.StartRaceButton);
            this.Controls.Add(this.AddVehicleButton);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.VehiclesContainer);
            this.MaximumSize = new System.Drawing.Size(904, 670);
            this.MinimumSize = new System.Drawing.Size(904, 670);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Racing Game!!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidePanel.ResumeLayout(false);
            this.VehicleProperties.ResumeLayout(false);
            this.VehicleProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private VehicleControl vehicleControl;
        private System.Windows.Forms.FlowLayoutPanel VehiclesContainer;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button AddVehicleButton;
        private System.Windows.Forms.Button StartRaceButton;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.FlowLayoutPanel VehicleProperties;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.TextBox DistanceTextBox;
        private System.Windows.Forms.Label PunctureChanceLabel;
        private System.Windows.Forms.TextBox PunctureChanceTextBox;
        private System.Windows.Forms.Label MinPunctureTimeLabel;
        private System.Windows.Forms.TextBox MinPunctureTimeTextBox;
        private System.Windows.Forms.Label MaxPunctureTimeLabel;
        private System.Windows.Forms.TextBox MaxPunctureTimeTextBox;
        private System.Windows.Forms.Label CargoWeightLabel;
        private System.Windows.Forms.TextBox CargoWeightTextBox;
        private System.Windows.Forms.Label PassengersCountLabel;
        private System.Windows.Forms.TextBox PassengersCountTextBox;
        private System.Windows.Forms.CheckBox SideCarCheckBox;
    }
}

