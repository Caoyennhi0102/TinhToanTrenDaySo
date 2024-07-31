namespace TinhToanTrenDaySo
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lbGioiHanDaySo = new Label();
            lbSoBatDau = new Label();
            lbSoketThuc = new Label();
            txtBatDau = new TextBox();
            txtKetThuc = new TextBox();
            lbTongCacSo = new Label();
            lbTichCacSo = new Label();
            lbTongCacSoChan = new Label();
            lbTongCacSoLe = new Label();
            btTinhToan = new Button();
            txtTongCacSo = new TextBox();
            txtTichCacSo = new TextBox();
            txtTongCacSoChan = new TextBox();
            txtTongCacSoLe = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbGioiHanDaySo
            // 
            lbGioiHanDaySo.AutoSize = true;
            lbGioiHanDaySo.Location = new Point(15, 19);
            lbGioiHanDaySo.Margin = new Padding(6, 0, 6, 0);
            lbGioiHanDaySo.Name = "lbGioiHanDaySo";
            lbGioiHanDaySo.Size = new Size(249, 32);
            lbGioiHanDaySo.TabIndex = 0;
            lbGioiHanDaySo.Text = "Giới Hạn Của Dãy Số";
            // 
            // lbSoBatDau
            // 
            lbSoBatDau.AutoSize = true;
            lbSoBatDau.Location = new Point(273, 19);
            lbSoBatDau.Name = "lbSoBatDau";
            lbSoBatDau.Size = new Size(153, 32);
            lbSoBatDau.TabIndex = 1;
            lbSoBatDau.Text = "Số Bắt Đầu: ";
            // 
            // lbSoketThuc
            // 
            lbSoketThuc.AutoSize = true;
            lbSoketThuc.Location = new Point(537, 19);
            lbSoketThuc.Name = "lbSoketThuc";
            lbSoketThuc.Size = new Size(163, 32);
            lbSoketThuc.TabIndex = 2;
            lbSoketThuc.Text = "Số Kết Thúc: ";
            // 
            // txtBatDau
            // 
            txtBatDau.Location = new Point(422, 19);
            txtBatDau.Name = "txtBatDau";
            txtBatDau.Size = new Size(100, 39);
            txtBatDau.TabIndex = 3;
            // 
            // txtKetThuc
            // 
            txtKetThuc.Location = new Point(706, 19);
            txtKetThuc.Name = "txtKetThuc";
            txtKetThuc.Size = new Size(100, 39);
            txtKetThuc.TabIndex = 4;
            // 
            // lbTongCacSo
            // 
            lbTongCacSo.AutoSize = true;
            lbTongCacSo.Location = new Point(18, 80);
            lbTongCacSo.Name = "lbTongCacSo";
            lbTongCacSo.Size = new Size(169, 32);
            lbTongCacSo.TabIndex = 5;
            lbTongCacSo.Text = "Tổng Các Số: ";
            // 
            // lbTichCacSo
            // 
            lbTichCacSo.AutoSize = true;
            lbTichCacSo.Location = new Point(18, 130);
            lbTichCacSo.Name = "lbTichCacSo";
            lbTichCacSo.Size = new Size(157, 32);
            lbTichCacSo.TabIndex = 6;
            lbTichCacSo.Text = "Tích Các Số: ";
            // 
            // lbTongCacSoChan
            // 
            lbTongCacSoChan.AutoSize = true;
            lbTongCacSoChan.Location = new Point(18, 181);
            lbTongCacSoChan.Name = "lbTongCacSoChan";
            lbTongCacSoChan.Size = new Size(233, 32);
            lbTongCacSoChan.TabIndex = 7;
            lbTongCacSoChan.Text = "Tổng Các Số Chẵn: ";
            // 
            // lbTongCacSoLe
            // 
            lbTongCacSoLe.AutoSize = true;
            lbTongCacSoLe.Location = new Point(18, 230);
            lbTongCacSoLe.Name = "lbTongCacSoLe";
            lbTongCacSoLe.Size = new Size(201, 32);
            lbTongCacSoLe.TabIndex = 8;
            lbTongCacSoLe.Text = "Tổng Các Số Lẻ: ";
            // 
            // btTinhToan
            // 
            btTinhToan.Location = new Point(299, 345);
            btTinhToan.Name = "btTinhToan";
            btTinhToan.Size = new Size(162, 64);
            btTinhToan.TabIndex = 9;
            btTinhToan.Text = "Tính Toán ";
            btTinhToan.UseVisualStyleBackColor = true;
            btTinhToan.Click += btTinhToan_Click;
            // 
            // txtTongCacSo
            // 
            txtTongCacSo.Location = new Point(208, 77);
            txtTongCacSo.Name = "txtTongCacSo";
            txtTongCacSo.Size = new Size(100, 39);
            txtTongCacSo.TabIndex = 10;
            // 
            // txtTichCacSo
            // 
            txtTichCacSo.Location = new Point(208, 130);
            txtTichCacSo.Name = "txtTichCacSo";
            txtTichCacSo.Size = new Size(100, 39);
            txtTichCacSo.TabIndex = 11;
            // 
            // txtTongCacSoChan
            // 
            txtTongCacSoChan.Location = new Point(257, 181);
            txtTongCacSoChan.Name = "txtTongCacSoChan";
            txtTongCacSoChan.Size = new Size(100, 39);
            txtTongCacSoChan.TabIndex = 12;
            // 
            // txtTongCacSoLe
            // 
            txtTongCacSoLe.Location = new Point(257, 244);
            txtTongCacSoLe.Name = "txtTongCacSoLe";
            txtTongCacSoLe.Size = new Size(100, 39);
            txtTongCacSoLe.TabIndex = 13;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 881);
            Controls.Add(txtTongCacSoLe);
            Controls.Add(txtTongCacSoChan);
            Controls.Add(txtTichCacSo);
            Controls.Add(txtTongCacSo);
            Controls.Add(btTinhToan);
            Controls.Add(lbTongCacSoLe);
            Controls.Add(lbTongCacSoChan);
            Controls.Add(lbTichCacSo);
            Controls.Add(lbTongCacSo);
            Controls.Add(txtKetThuc);
            Controls.Add(txtBatDau);
            Controls.Add(lbSoketThuc);
            Controls.Add(lbSoBatDau);
            Controls.Add(lbGioiHanDaySo);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbGioiHanDaySo;
        private Label lbSoBatDau;
        private Label lbSoketThuc;
        private TextBox txtBatDau;
        private TextBox txtKetThuc;
        private Label lbTongCacSo;
        private Label lbTichCacSo;
        private Label lbTongCacSoChan;
        private Label lbTongCacSoLe;
        private Button btTinhToan;
        private TextBox txtTongCacSo;
        private TextBox txtTichCacSo;
        private TextBox txtTongCacSoChan;
        private TextBox txtTongCacSoLe;
        private ErrorProvider errorProvider1;
    }
}
