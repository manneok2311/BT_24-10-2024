namespace Form_Đăng_Nhập
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text;
            string pass = txtmk.Text;
            if (ten == "admin" && pass == "1234")
            {
                MessageBox.Show("Đăng nhập thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Đăng nhập không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
