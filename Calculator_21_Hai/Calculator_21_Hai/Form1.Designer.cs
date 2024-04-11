
namespace Calculator_21_Hai
{
    partial class Form1
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
            this.txt_so_a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_so_b = new System.Windows.Forms.TextBox();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.btn_tru = new System.Windows.Forms.Button();
            this.btn_chia = new System.Windows.Forms.Button();
            this.btn_nhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_so_a
            // 
            this.txt_so_a.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_so_a.Location = new System.Drawing.Point(153, 60);
            this.txt_so_a.Name = "txt_so_a";
            this.txt_so_a.Size = new System.Drawing.Size(48, 26);
            this.txt_so_a.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số a: ";
            // 
            // btn_cong
            // 
            this.btn_cong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cong.Location = new System.Drawing.Point(47, 252);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(84, 44);
            this.btn_cong.TabIndex = 2;
            this.btn_cong.Text = "Cộng";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết Quả: ";
            // 
            // txt_so_b
            // 
            this.txt_so_b.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_so_b.Location = new System.Drawing.Point(153, 121);
            this.txt_so_b.Name = "txt_so_b";
            this.txt_so_b.Size = new System.Drawing.Size(48, 26);
            this.txt_so_b.TabIndex = 5;
            // 
            // txt_kq
            // 
            this.txt_kq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kq.Location = new System.Drawing.Point(153, 182);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(48, 26);
            this.txt_kq.TabIndex = 6;
            // 
            // btn_tru
            // 
            this.btn_tru.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tru.Location = new System.Drawing.Point(175, 252);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(84, 44);
            this.btn_tru.TabIndex = 7;
            this.btn_tru.Text = "Trừ";
            this.btn_tru.UseVisualStyleBackColor = true;
            this.btn_tru.Click += new System.EventHandler(this.btn_tru_Click);
            // 
            // btn_chia
            // 
            this.btn_chia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chia.Location = new System.Drawing.Point(175, 336);
            this.btn_chia.Name = "btn_chia";
            this.btn_chia.Size = new System.Drawing.Size(84, 44);
            this.btn_chia.TabIndex = 9;
            this.btn_chia.Text = "Chia";
            this.btn_chia.UseVisualStyleBackColor = true;
            this.btn_chia.Click += new System.EventHandler(this.btn_chia_Click);
            // 
            // btn_nhan
            // 
            this.btn_nhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhan.Location = new System.Drawing.Point(47, 336);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(84, 44);
            this.btn_nhan.TabIndex = 8;
            this.btn_nhan.Text = "Nhân";
            this.btn_nhan.UseVisualStyleBackColor = true;
            this.btn_nhan.Click += new System.EventHandler(this.btn_nhan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 427);
            this.Controls.Add(this.btn_chia);
            this.Controls.Add(this.btn_nhan);
            this.Controls.Add(this.btn_tru);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.txt_so_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_so_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_so_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_so_b;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button btn_tru;
        private System.Windows.Forms.Button btn_chia;
        private System.Windows.Forms.Button btn_nhan;
    }
}

