using Bismillah.View;

namespace Bismillah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHalLogin_Click(object sender, EventArgs e)
        {
            LoginAdmincs baru = new LoginAdmincs();
            baru.ShowDialog();
        }
    }
}
