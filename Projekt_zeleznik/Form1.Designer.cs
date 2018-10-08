namespace Projekt_zeleznik
{
    partial class Prijava
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uporImeTextBox = new System.Windows.Forms.TextBox();
            this.gesloTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.prijavaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uporabnško ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Geslo";
            // 
            // uporImeTextBox
            // 
            this.uporImeTextBox.Location = new System.Drawing.Point(338, 188);
            this.uporImeTextBox.Multiline = true;
            this.uporImeTextBox.Name = "uporImeTextBox";
            this.uporImeTextBox.Size = new System.Drawing.Size(157, 29);
            this.uporImeTextBox.TabIndex = 5;
            // 
            // gesloTextBox
            // 
            this.gesloTextBox.Location = new System.Drawing.Point(338, 255);
            this.gesloTextBox.Multiline = true;
            this.gesloTextBox.Name = "gesloTextBox";
            this.gesloTextBox.PasswordChar = '*';
            this.gesloTextBox.Size = new System.Drawing.Size(157, 29);
            this.gesloTextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(374, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Prijava";
            // 
            // prijavaButton
            // 
            this.prijavaButton.Location = new System.Drawing.Point(420, 307);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(75, 29);
            this.prijavaButton.TabIndex = 12;
            this.prijavaButton.Text = "Prijava";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Registracija";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(834, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gesloTextBox);
            this.Controls.Add(this.uporImeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Prijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uporImeTextBox;
        private System.Windows.Forms.TextBox gesloTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button prijavaButton;
        private System.Windows.Forms.Button button1;
    }
}

