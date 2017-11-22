namespace Assessment_2B
{
    partial class Form1
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
            this.JokeLabel = new System.Windows.Forms.Label();
            this.btnsetup = new System.Windows.Forms.Button();
            this.btnPunchline = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JokeLabel
            // 
            this.JokeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.JokeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.JokeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JokeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JokeLabel.Location = new System.Drawing.Point(-3, 0);
            this.JokeLabel.Name = "JokeLabel";
            this.JokeLabel.Size = new System.Drawing.Size(732, 88);
            this.JokeLabel.TabIndex = 0;
            this.JokeLabel.Text = "Ready for a Joke?";
            this.JokeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsetup
            // 
            this.btnsetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(17)))));
            this.btnsetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsetup.Location = new System.Drawing.Point(95, 134);
            this.btnsetup.Name = "btnsetup";
            this.btnsetup.Size = new System.Drawing.Size(130, 43);
            this.btnsetup.TabIndex = 1;
            this.btnsetup.Text = "Setup";
            this.btnsetup.UseVisualStyleBackColor = false;
            this.btnsetup.Click += new System.EventHandler(this.btnsetup_Click);
            // 
            // btnPunchline
            // 
            this.btnPunchline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(17)))));
            this.btnPunchline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunchline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPunchline.Location = new System.Drawing.Point(502, 134);
            this.btnPunchline.Name = "btnPunchline";
            this.btnPunchline.Size = new System.Drawing.Size(130, 43);
            this.btnPunchline.TabIndex = 2;
            this.btnPunchline.Text = "Punchline";
            this.btnPunchline.UseVisualStyleBackColor = false;
            this.btnPunchline.Click += new System.EventHandler(this.btnPunchline_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(17)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(297, 196);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 43);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(17)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(609, 273);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 31);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(103)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(728, 316);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPunchline);
            this.Controls.Add(this.btnsetup);
            this.Controls.Add(this.JokeLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label JokeLabel;
        private System.Windows.Forms.Button btnsetup;
        private System.Windows.Forms.Button btnPunchline;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
    }
}

