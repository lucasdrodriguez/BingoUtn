
namespace Bingo2E
{
    partial class FrmBolillero
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
            this.btn_numero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_numero
            // 
            this.btn_numero.Location = new System.Drawing.Point(209, 30);
            this.btn_numero.Name = "btn_numero";
            this.btn_numero.Size = new System.Drawing.Size(291, 64);
            this.btn_numero.TabIndex = 0;
            this.btn_numero.Text = "Sacar proximo numero";
            this.btn_numero.UseVisualStyleBackColor = true;
            this.btn_numero.Click += new System.EventHandler(this.btn_numero_Click);
            // 
            // FrmBolillero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 263);
            this.Controls.Add(this.btn_numero);
            this.Name = "FrmBolillero";
            this.Text = "Bolillero";
            this.Load += new System.EventHandler(this.FrmBolillero_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_numero;
    }
}

