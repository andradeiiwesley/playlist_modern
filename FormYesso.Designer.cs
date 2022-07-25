
namespace WF_ModernUI
{
    partial class FormYesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYesso));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusica = new System.Windows.Forms.TextBox();
            this.txtCantor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelSalvar = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Script", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(250, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 71);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yesso";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Playlist PAGODES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMusica
            // 
            this.txtMusica.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusica.Location = new System.Drawing.Point(274, 346);
            this.txtMusica.Name = "txtMusica";
            this.txtMusica.Size = new System.Drawing.Size(396, 41);
            this.txtMusica.TabIndex = 12;
            // 
            // txtCantor
            // 
            this.txtCantor.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantor.Location = new System.Drawing.Point(274, 259);
            this.txtCantor.Name = "txtCantor";
            this.txtCantor.Size = new System.Drawing.Size(396, 41);
            this.txtCantor.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 51);
            this.label4.TabIndex = 10;
            this.label4.Text = "Música:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 51);
            this.label3.TabIndex = 9;
            this.label3.Text = "Autor/Cantor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabelSalvar
            // 
            this.linkLabelSalvar.AutoSize = true;
            this.linkLabelSalvar.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSalvar.Location = new System.Drawing.Point(335, 448);
            this.linkLabelSalvar.Name = "linkLabelSalvar";
            this.linkLabelSalvar.Size = new System.Drawing.Size(111, 44);
            this.linkLabelSalvar.TabIndex = 14;
            this.linkLabelSalvar.TabStop = true;
            this.linkLabelSalvar.Text = "Salvar";
            this.linkLabelSalvar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSalvar_LinkClicked);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(789, 48);
            this.label5.TabIndex = 15;
            this.label5.Text = "Adicionar nova música:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormYesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(789, 524);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabelSalvar);
            this.Controls.Add(this.txtMusica);
            this.Controls.Add(this.txtCantor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormYesso";
            this.Text = "FormContas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusica;
        private System.Windows.Forms.TextBox txtCantor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelSalvar;
        private System.Windows.Forms.Label label5;
    }
}