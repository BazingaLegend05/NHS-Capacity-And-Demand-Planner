namespace NHSCapacityAndDemandPlanner
{
    partial class SchedulerWindow
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
            BackButton = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(118, 40);
            BackButton.TabIndex = 0;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += this.BackButton_Click;
            // 
            // SchedulerWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(BackButton);
            MinimumSize = new Size(1200, 800);
            Name = "SchedulerWindow";
            Text = "Scheduler";
            Load += this.SchedulerWindow_Load;
            ResumeLayout(false);
        }

        private void SchedulerWindow_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button BackButton;
    }
}