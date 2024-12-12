namespace TutorialProject
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
            label1 = new Label();
            SensorName = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            SensorType = new TextBox();
            SensorID = new TextBox();
            label3 = new Label();
            DBView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DBView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 117);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Sensor Name";
            // 
            // SensorName
            // 
            SensorName.Location = new Point(49, 135);
            SensorName.Name = "SensorName";
            SensorName.Size = new Size(262, 23);
            SensorName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 208);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Sensor Type";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(49, 384);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // SensorType
            // 
            SensorType.Location = new Point(49, 226);
            SensorType.Name = "SensorType";
            SensorType.Size = new Size(262, 23);
            SensorType.TabIndex = 5;
            // 
            // SensorID
            // 
            SensorID.Location = new Point(49, 46);
            SensorID.Name = "SensorID";
            SensorID.Size = new Size(262, 23);
            SensorID.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 28);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Sensor ID";
            // 
            // DBView
            // 
            DBView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DBView.Location = new Point(317, 12);
            DBView.Name = "DBView";
            DBView.Size = new Size(555, 437);
            DBView.TabIndex = 8;
            DBView.CellContentClick += DBView_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(DBView);
            Controls.Add(SensorID);
            Controls.Add(label3);
            Controls.Add(SensorType);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(SensorName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DBView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SensorName;
        private Label label2;
        private Button btnSave;
        private TextBox SensorType;
        private TextBox SensorID;
        private Label label3;
        private DataGridView DBView;
    }
}
