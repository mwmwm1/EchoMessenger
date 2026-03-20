namespace EchoMessenger
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
            Sendbtn = new Button();
            MsgRecord = new ListBox();
            InputBox = new TextBox();
            LabelCount = new Label();
            SuspendLayout();
            // 
            // Sendbtn
            // 
            Sendbtn.Location = new Point(676, 390);
            Sendbtn.Name = "Sendbtn";
            Sendbtn.Size = new Size(75, 23);
            Sendbtn.TabIndex = 0;
            Sendbtn.Text = "전송";
            Sendbtn.UseVisualStyleBackColor = true;
            Sendbtn.Click += Sendbtn_Click;
            // 
            // MsgRecord
            // 
            MsgRecord.FormattingEnabled = true;
            MsgRecord.Location = new Point(31, 61);
            MsgRecord.Name = "MsgRecord";
            MsgRecord.Size = new Size(720, 304);
            MsgRecord.TabIndex = 2;
            // 
            // InputBox
            // 
            InputBox.Location = new Point(31, 390);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(630, 23);
            InputBox.TabIndex = 3;
            // 
            // LabelCount
            // 
            LabelCount.Font = new Font("궁서체", 28F);
            LabelCount.ForeColor = Color.Black;
            LabelCount.Location = new Point(31, 9);
            LabelCount.Name = "LabelCount";
            LabelCount.Size = new Size(403, 49);
            LabelCount.TabIndex = 4;
            LabelCount.Text = "Echo Messenger";
            LabelCount.Click += LabelCount_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(788, 453);
            Controls.Add(LabelCount);
            Controls.Add(InputBox);
            Controls.Add(MsgRecord);
            Controls.Add(Sendbtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Sendbtn;
        private ListBox MsgRecord;
        private TextBox InputBox;
        private Label LabelCount;
    }
}
