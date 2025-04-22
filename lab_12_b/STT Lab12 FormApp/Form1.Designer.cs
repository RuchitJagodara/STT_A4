namespace STT_Lab12_FormApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label title;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            title = new Label();
            txtTime = new TextBox();
            btnStart = new Button();
            lblPrompt = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // title
            // 
            title.Font = new Font("Times New Roman", 22F, FontStyle.Bold);
            title.ForeColor = Color.DarkBlue;
            title.Location = new Point(0, 13);
            title.Name = "title";
            title.Size = new Size(514, 67);
            title.TabIndex = 0;
            title.Text = "Alarm Clock";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTime
            // 
            txtTime.Font = new Font("Times New Roman", 14F);
            txtTime.Location = new Point(171, 107);
            txtTime.Margin = new Padding(3, 4, 3, 4);
            txtTime.Name = "txtTime";
            txtTime.PlaceholderText = "HH:mm:ss";
            txtTime.Size = new Size(205, 34);
            txtTime.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LightSkyBlue;
            btnStart.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            btnStart.ForeColor = Color.DarkBlue;
            btnStart.Location = new Point(143, 173);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(229, 67);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblPrompt
            // 
            lblPrompt.Font = new Font("Times New Roman", 14F);
            lblPrompt.Location = new Point(34, 107);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(126, 40);
            lblPrompt.TabIndex = 1;
            lblPrompt.Text = "Set Time:";
            lblPrompt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            lblStatus.ForeColor = Color.DarkGreen;
            lblStatus.Location = new Point(29, 267);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(457, 33);
            lblStatus.TabIndex = 2;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(514, 360);
            Controls.Add(title);
            Controls.Add(lblPrompt);
            Controls.Add(txtTime);
            Controls.Add(btnStart);
            Controls.Add(lblStatus);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Alarm Clock";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}