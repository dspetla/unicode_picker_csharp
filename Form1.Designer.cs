namespace UnicodePicker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Type character name";
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 20;
            this.lstResults.Location = new System.Drawing.Point(12, 60);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(400, 284);
            this.lstResults.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(298, 350);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(114, 32);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert Character";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Unicode Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button btnInsert;
    }
}
