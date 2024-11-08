using Bismillah.App.Context;
using Bismillah.App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bismillah.View
{
    public partial class LoginAdmincs : Form
    {
        public LoginAdmincs()
        {
            InitializeComponent();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            LoginAdminContext login = new LoginAdminContext();
            Akun lo = login.Validate(tbUser.Text, tbPass.Text);
            if (lo != null)
            {
                MessageBox.Show("Login berhasil!", "INFO", MessageBoxButtons.OK,
                MessageBoxIcon.Information);


                HalAdmin baru = new HalAdmin();
                baru.ShowDialog();

            }
        }
    }
}
