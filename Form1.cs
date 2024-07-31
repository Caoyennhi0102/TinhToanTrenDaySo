namespace TinhToanTrenDaySo
{
    public partial class Form1 : Form
    {
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void btTinhToan_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(!int.TryParse(txtBatDau.Text, out _))
            {
                errorProvider1.SetError(txtBatDau, "Phải Nhập Số Nguyên");
                return;
            }
            if(!int.TryParse(txtKetThuc.Text, out _))
            {
                errorProvider1.SetError(txtKetThuc, "Phải Nhập Số Nguyên");
                return;
            }
            if(string.IsNullOrEmpty(txtBatDau.Text))
            {
                errorProvider1.SetError(txtBatDau, "Bắt Buộc Nhập");
                return;
            }
            if (string.IsNullOrEmpty(txtKetThuc.Text))
            {
                errorProvider1.SetError(txtKetThuc, "Bắt buộc Nhập");
            }
            a = Convert.ToInt32(txtBatDau.Text);
            b = Convert.ToInt32(txtKetThuc.Text);

            int TongCacSo = 0, TichCacSo = 0, Tongcacsole = 0, Tongcacsochan = 0;
            for(int i = a; i <= b; i++)
            {
                TongCacSo += i;
                TichCacSo *= i;
                if(i % 2 == 0)
                {
                    Tongcacsochan +=i;
                }
                else
                {

                    Tongcacsole += i;
                }
            }
            txtTongCacSo.Text = Convert.ToString(TongCacSo);
            txtTichCacSo.Text = Convert.ToString(TichCacSo);
            txtTongCacSoChan.Text = Convert.ToString(Tongcacsochan);
            txtTongCacSoLe.Text = Convert.ToString(Tongcacsole);
            
        }
        
    }
}
