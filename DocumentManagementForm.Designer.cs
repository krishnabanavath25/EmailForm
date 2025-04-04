namespace MyEmail
{
    partial class DocumentManagementForm
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
            this.listDocuments = new System.Windows.Forms.ListBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btbDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDocuments
            // 
            this.listDocuments.FormattingEnabled = true;
            this.listDocuments.Location = new System.Drawing.Point(53, 27);
            this.listDocuments.Name = "listDocuments";
            this.listDocuments.Size = new System.Drawing.Size(400, 251);
            this.listDocuments.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(53, 315);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(107, 23);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "UploadDocument";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(182, 315);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(115, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "ViewDocument";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btbDelete
            // 
            this.btbDelete.Location = new System.Drawing.Point(321, 315);
            this.btbDelete.Name = "btbDelete";
            this.btbDelete.Size = new System.Drawing.Size(132, 23);
            this.btbDelete.TabIndex = 3;
            this.btbDelete.Text = "DeleteDocument";
            this.btbDelete.UseVisualStyleBackColor = true;
            // 
            // DocumentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 382);
            this.Controls.Add(this.btbDelete);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.listDocuments);
            this.Name = "DocumentManagementForm";
            this.Text = "DocumentManagementForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listDocuments;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btbDelete;
    }
}