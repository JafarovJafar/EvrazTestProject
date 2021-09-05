
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(886, 623);
            this.Controls.Add(this.VehiclesContainer);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Racing Game!!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private VehicleControl vehicleControl;
        private System.Windows.Forms.FlowLayoutPanel VehiclesContainer;
    }
}

