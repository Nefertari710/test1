namespace WinFormsApp3
{
    partial class Server
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
            labelShowStatus = new Label();
            labelShowStatus1 = new Label();
            labelShowStatus2 = new Label();
            labelShowStatus3 = new Label();
            listBoxAllData = new ListBox();
            label1 = new Label();
            listBoxServerData = new ListBox();
            label2 = new Label();
            buttonAuth = new Button();
            labelShowStatus4 = new Label();
            buttonInsertFile = new Button();
            SuspendLayout();
            // 
            // labelShowStatus
            // 
            labelShowStatus.AutoSize = true;
            labelShowStatus.Location = new Point(12, 9);
            labelShowStatus.Name = "labelShowStatus";
            labelShowStatus.Size = new Size(93, 15);
            labelShowStatus.TabIndex = 0;
            labelShowStatus.Text = "labelShowStatus";
            // 
            // labelShowStatus1
            // 
            labelShowStatus1.AutoSize = true;
            labelShowStatus1.Location = new Point(12, 24);
            labelShowStatus1.Name = "labelShowStatus1";
            labelShowStatus1.Size = new Size(99, 15);
            labelShowStatus1.TabIndex = 1;
            labelShowStatus1.Text = "labelShowStatus1";
            // 
            // labelShowStatus2
            // 
            labelShowStatus2.AutoSize = true;
            labelShowStatus2.Location = new Point(12, 39);
            labelShowStatus2.Name = "labelShowStatus2";
            labelShowStatus2.Size = new Size(99, 15);
            labelShowStatus2.TabIndex = 2;
            labelShowStatus2.Text = "labelShowStatus2";
            // 
            // labelShowStatus3
            // 
            labelShowStatus3.AutoSize = true;
            labelShowStatus3.Location = new Point(12, 54);
            labelShowStatus3.Name = "labelShowStatus3";
            labelShowStatus3.Size = new Size(99, 15);
            labelShowStatus3.TabIndex = 3;
            labelShowStatus3.Text = "labelShowStatus3";
            // 
            // listBoxAllData
            // 
            listBoxAllData.FormattingEnabled = true;
            listBoxAllData.ItemHeight = 15;
            listBoxAllData.Location = new Point(48, 140);
            listBoxAllData.Name = "listBoxAllData";
            listBoxAllData.Size = new Size(174, 229);
            listBoxAllData.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 122);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 5;
            label1.Text = "All File List";
            // 
            // listBoxServerData
            // 
            listBoxServerData.FormattingEnabled = true;
            listBoxServerData.ItemHeight = 15;
            listBoxServerData.Location = new Point(287, 140);
            listBoxServerData.Name = "listBoxServerData";
            listBoxServerData.Size = new Size(167, 229);
            listBoxServerData.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 118);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 7;
            label2.Text = "Available File List";
            // 
            // buttonAuth
            // 
            buttonAuth.Location = new Point(147, 378);
            buttonAuth.Name = "buttonAuth";
            buttonAuth.Size = new Size(75, 23);
            buttonAuth.TabIndex = 8;
            buttonAuth.Text = "Authorized";
            buttonAuth.UseVisualStyleBackColor = true;
            buttonAuth.Click += buttonAuth_Click;
            // 
            // labelShowStatus4
            // 
            labelShowStatus4.AutoSize = true;
            labelShowStatus4.Location = new Point(12, 68);
            labelShowStatus4.Name = "labelShowStatus4";
            labelShowStatus4.Size = new Size(99, 15);
            labelShowStatus4.TabIndex = 9;
            labelShowStatus4.Text = "labelShowStatus4";
            // 
            // buttonInsertFile
            // 
            buttonInsertFile.Location = new Point(117, 114);
            buttonInsertFile.Name = "buttonInsertFile";
            buttonInsertFile.Size = new Size(105, 23);
            buttonInsertFile.TabIndex = 10;
            buttonInsertFile.Text = "buttonInsertFile";
            buttonInsertFile.UseVisualStyleBackColor = true;
            buttonInsertFile.Click += buttonInsertFile_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 467);
            Controls.Add(buttonInsertFile);
            Controls.Add(labelShowStatus4);
            Controls.Add(buttonAuth);
            Controls.Add(label2);
            Controls.Add(listBoxServerData);
            Controls.Add(label1);
            Controls.Add(listBoxAllData);
            Controls.Add(labelShowStatus3);
            Controls.Add(labelShowStatus2);
            Controls.Add(labelShowStatus1);
            Controls.Add(labelShowStatus);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelShowStatus;
        private Label labelShowStatus1;
        private Label labelShowStatus2;
        private Label labelShowStatus3;
        private ListBox listBoxAllData;
        private Label label1;
        private ListBox listBoxServerData;
        private Label label2;
        private Button buttonAuth;
        private Label labelShowStatus4;
        private Button buttonInsertFile;
    }
}