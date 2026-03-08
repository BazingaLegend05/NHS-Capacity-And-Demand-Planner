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
            components = new System.ComponentModel.Container();
            BackButton = new Button();
            DynamicTable = new DataGridView();
            bindingSource1 = new BindingSource(components);
            DropDown = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DynamicTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
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
            BackButton.Click += BackButton_Click;
            // 
            // DynamicTable
            // 
            DynamicTable.Anchor = AnchorStyles.None;
            DynamicTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DynamicTable.Location = new Point(12, 135);
            DynamicTable.Name = "DynamicTable";
            DynamicTable.Size = new Size(1160, 512);
            DynamicTable.TabIndex = 3;
            DynamicTable.CellContentClick += DynamicTable_CellContentClick;
            // 
            // DropDown
            // 
            DropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            DropDown.Font = new Font("Segoe UI", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            DropDown.FormattingEnabled = true;
            DropDown.Items.AddRange(new object[] { "Clinician Timetable", "Theatre Timetable", "Clinic Setup" });
            DropDown.Location = new Point(12, 91);
            DropDown.Name = "DropDown";
            DropDown.Size = new Size(208, 38);
            DropDown.TabIndex = 4;
            DropDown.SelectedIndexChanged += DropDown_SelectedIndexChanged;
            // 
            // SchedulerWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 761);
            Controls.Add(DropDown);
            Controls.Add(DynamicTable);
            Controls.Add(BackButton);
            MinimumSize = new Size(1200, 800);
            Name = "SchedulerWindow";
            Text = "Scheduler";
            Load += SchedulerWindow_Load;
            ((System.ComponentModel.ISupportInitialize)DynamicTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Button BackButton;
        private DataGridView DynamicTable;
        private BindingSource bindingSource1;
        private ComboBox DropDown;
    }
}