namespace MyEmail
{
    partial class ComposeEmailForm
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
            this.Tolabel = new System.Windows.Forms.Label();
            this.textTo = new System.Windows.Forms.TextBox();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.subjectlabel = new System.Windows.Forms.Label();
            this.messagelabel = new System.Windows.Forms.Label();
            this.sendbutton = new System.Windows.Forms.Button();
            this.richTextMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Tolabel
            // 
            this.Tolabel.AutoSize = true;
            this.Tolabel.Location = new System.Drawing.Point(46, 28);
            this.Tolabel.Name = "Tolabel";
            this.Tolabel.Size = new System.Drawing.Size(20, 13);
            this.Tolabel.TabIndex = 0;
            this.Tolabel.Text = "To";
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(49, 55);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(360, 20);
            this.textTo.TabIndex = 1;
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(49, 128);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(360, 20);
            this.textSubject.TabIndex = 3;
            // 
            // subjectlabel
            // 
            this.subjectlabel.AutoSize = true;
            this.subjectlabel.Location = new System.Drawing.Point(46, 101);
            this.subjectlabel.Name = "subjectlabel";
            this.subjectlabel.Size = new System.Drawing.Size(43, 13);
            this.subjectlabel.TabIndex = 2;
            this.subjectlabel.Text = "Subject";
            // 
            // messagelabel
            // 
            this.messagelabel.AutoSize = true;
            this.messagelabel.Location = new System.Drawing.Point(46, 177);
            this.messagelabel.Name = "messagelabel";
            this.messagelabel.Size = new System.Drawing.Size(50, 13);
            this.messagelabel.TabIndex = 4;
            this.messagelabel.Text = "Message";
            // 
            // sendbutton
            // 
            this.sendbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.sendbutton.ForeColor = System.Drawing.SystemColors.Info;
            this.sendbutton.Location = new System.Drawing.Point(209, 336);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(75, 23);
            this.sendbutton.TabIndex = 6;
            this.sendbutton.Text = "Send";
            this.sendbutton.UseVisualStyleBackColor = false;
            // 
            // richTextMessage
            // 
            this.richTextMessage.Location = new System.Drawing.Point(49, 193);
            this.richTextMessage.Name = "richTextMessage";
            this.richTextMessage.Size = new System.Drawing.Size(360, 123);
            this.richTextMessage.TabIndex = 7;
            this.richTextMessage.Text = "";
            // 
            // ComposeEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 431);
            this.Controls.Add(this.richTextMessage);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.messagelabel);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.subjectlabel);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.Tolabel);
            this.Name = "ComposeEmailForm";
            this.Text = "ComposeEmailForm";
            this.Load += new System.EventHandler(this.ComposeEmailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tolabel;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.Label subjectlabel;
        private System.Windows.Forms.Label messagelabel;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.RichTextBox richTextMessage;
    }
}