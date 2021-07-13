
namespace Vucut_Kitle_İndeksi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblİndeks = new System.Windows.Forms.Label();
            this.lblSon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(389, 80);
            this.txtBoy.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(212, 31);
            this.txtBoy.TabIndex = 0;
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(389, 179);
            this.txtKilo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(212, 31);
            this.txtKilo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Boyunuzu Girin (Ornegin 156,5) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kilonuzu Girin (Ornegin 67,5) :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(389, 242);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(212, 55);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(270, 334);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(92, 25);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "Sonuc :";
            // 
            // lblİndeks
            // 
            this.lblİndeks.AutoSize = true;
            this.lblİndeks.Location = new System.Drawing.Point(369, 334);
            this.lblİndeks.Name = "lblİndeks";
            this.lblİndeks.Size = new System.Drawing.Size(92, 25);
            this.lblİndeks.TabIndex = 3;
            this.lblİndeks.Text = "Sonuc :";
            this.lblİndeks.Visible = false;
            // 
            // lblSon
            // 
            this.lblSon.AutoSize = true;
            this.lblSon.Location = new System.Drawing.Point(369, 372);
            this.lblSon.Name = "lblSon";
            this.lblSon.Size = new System.Drawing.Size(92, 25);
            this.lblSon.TabIndex = 3;
            this.lblSon.Text = "Sonuc :";
            this.lblSon.Visible = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.lblSon);
            this.Controls.Add(this.lblİndeks);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.txtBoy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vucüt Kitle İndeksi Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblİndeks;
        private System.Windows.Forms.Label lblSon;
    }
}

