namespace Pendulum_Form
{
    partial class EditSelected
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHossz = new System.Windows.Forms.TextBox();
            this.tbKiadas = new System.Windows.Forms.TextBox();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.tbZenekar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cím:";
            // 
            // tbCim
            // 
            this.tbCim.Location = new System.Drawing.Point(196, 63);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(207, 22);
            this.tbCim.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(160, 369);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(101, 42);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zenekar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Album címe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kiadás éve:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hossz:";
            // 
            // tbHossz
            // 
            this.tbHossz.Location = new System.Drawing.Point(196, 288);
            this.tbHossz.Name = "tbHossz";
            this.tbHossz.Size = new System.Drawing.Size(207, 22);
            this.tbHossz.TabIndex = 7;
            // 
            // tbKiadas
            // 
            this.tbKiadas.Location = new System.Drawing.Point(196, 229);
            this.tbKiadas.Name = "tbKiadas";
            this.tbKiadas.Size = new System.Drawing.Size(207, 22);
            this.tbKiadas.TabIndex = 8;
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(196, 176);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(207, 22);
            this.tbAlbum.TabIndex = 9;
            // 
            // tbZenekar
            // 
            this.tbZenekar.Location = new System.Drawing.Point(196, 117);
            this.tbZenekar.Name = "tbZenekar";
            this.tbZenekar.Size = new System.Drawing.Size(207, 22);
            this.tbZenekar.TabIndex = 10;
            // 
            // EditSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 455);
            this.Controls.Add(this.tbZenekar);
            this.Controls.Add(this.tbAlbum);
            this.Controls.Add(this.tbKiadas);
            this.Controls.Add(this.tbHossz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tbCim);
            this.Controls.Add(this.label1);
            this.Name = "EditSelected";
            this.Text = "EditSelected";
            this.Load += new System.EventHandler(this.EditSelected_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCim;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHossz;
        private System.Windows.Forms.TextBox tbKiadas;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.TextBox tbZenekar;
    }
}