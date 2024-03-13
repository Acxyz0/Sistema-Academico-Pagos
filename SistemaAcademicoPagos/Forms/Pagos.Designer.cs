namespace SistemaAcademicoPagos.Forms
{
    partial class Pagos
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
            this.acTextBox1 = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.SuspendLayout();
            // 
            // acTextBox1
            // 
            this.acTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.acTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.acTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.acTextBox1.BorderSize = 2;
            this.acTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.acTextBox1.Location = new System.Drawing.Point(552, 152);
            this.acTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.acTextBox1.Multiline = false;
            this.acTextBox1.Name = "acTextBox1";
            this.acTextBox1.Names = "textBox1";
            this.acTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.acTextBox1.PasswordChar = false;
            this.acTextBox1.Size = new System.Drawing.Size(320, 35);
            this.acTextBox1.TabIndex = 0;
            this.acTextBox1.Texts = "";
            this.acTextBox1.UnderlinedStyle = false;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 600);
            this.Controls.Add(this.acTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.AcTextBox acTextBox1;
    }
}