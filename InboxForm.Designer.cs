namespace MyEmail
{
    partial class InboxForm
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
            this.dataGridViewInbox = new System.Windows.Forms.DataGridView();
            this.TextEmailPreview = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInbox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInbox
            // 
            this.dataGridViewInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInbox.Location = new System.Drawing.Point(34, 29);
            this.dataGridViewInbox.Name = "dataGridViewInbox";
            this.dataGridViewInbox.Size = new System.Drawing.Size(327, 319);
            this.dataGridViewInbox.TabIndex = 0;
            this.dataGridViewInbox.SelectionChanged += new System.EventHandler(this.dataGridViewInbox_SelectionChanged);
            // 
            // TextEmailPreview
            // 
            this.TextEmailPreview.Location = new System.Drawing.Point(367, 29);
            this.TextEmailPreview.Name = "TextEmailPreview";
            this.TextEmailPreview.Size = new System.Drawing.Size(257, 121);
            this.TextEmailPreview.TabIndex = 1;
            this.TextEmailPreview.Text = "";
            // 
            // InboxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 381);
            this.Controls.Add(this.TextEmailPreview);
            this.Controls.Add(this.dataGridViewInbox);
            this.Name = "InboxForm";
            this.Text = "InboxForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInbox;
        private System.Windows.Forms.RichTextBox TextEmailPreview;
    }
}