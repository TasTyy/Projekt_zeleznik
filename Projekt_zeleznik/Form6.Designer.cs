namespace Projekt_zeleznik
{
    partial class Uporabnik
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vrsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Vrsta,
            this.Datum,
            this.Opis,
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(12, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(607, 283);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 28;
            // 
            // Vrsta
            // 
            this.Vrsta.Text = "Vrsta";
            this.Vrsta.Width = 55;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            this.Datum.Width = 129;
            // 
            // Opis
            // 
            this.Opis.Text = "Opis";
            this.Opis.Width = 266;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Uporabnik";
            this.columnHeader1.Width = 123;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userLabel.Location = new System.Drawing.Point(12, 26);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(58, 22);
            this.userLabel.TabIndex = 15;
            this.userLabel.Text = "label1";
            // 
            // Uporabnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 403);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.listView1);
            this.Name = "Uporabnik";
            this.Text = "Uporabnik";
            this.Load += new System.EventHandler(this.Uporabnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Vrsta;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Opis;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label userLabel;
    }
}