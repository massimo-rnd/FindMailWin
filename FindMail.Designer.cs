namespace FindMailWin
{
    partial class FindMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindMail));
            StartBtn = new Button();
            label1 = new Label();
            SourceUrl = new TextBox();
            ResultBox = new TextBox();
            SuspendLayout();
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(418, 244);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(75, 23);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "URL to scan";
            // 
            // SourceUrl
            // 
            SourceUrl.Location = new Point(12, 36);
            SourceUrl.Name = "SourceUrl";
            SourceUrl.Size = new Size(238, 23);
            SourceUrl.TabIndex = 2;
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(12, 96);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.ScrollBars = ScrollBars.Vertical;
            ResultBox.Size = new Size(481, 142);
            ResultBox.TabIndex = 3;
            // 
            // FindMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 279);
            Controls.Add(ResultBox);
            Controls.Add(SourceUrl);
            Controls.Add(label1);
            Controls.Add(StartBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FindMail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FindMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartBtn;
        private Label label1;
        private TextBox SourceUrl;
        private TextBox ResultBox;
    }
}