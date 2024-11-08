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
    public partial class HalAdmin : Form
    {
        List<M_Tugas> listtugas = new List<M_Tugas>();
        public HalAdmin()
        {
            InitializeComponent();
            M_Tugas baru = new M_Tugas();
            baru.tugas_id = 0;
            baru.judul = "Apapal";
            baru.deadline = "Selasa";
            baru.deskripsi = "Gatau";
            listtugas.Add(baru);

            baru = new M_Tugas();
            baru.tugas_id = 0;
            baru.judul = "Apapal";
            baru.deadline = "Selasa";
            baru.deskripsi = "Gatau";

            listtugas.Add(baru);
            dataGridView1.DataSource = listtugas;
            
        }

        private void btnTambahTugas_Click(object sender, EventArgs e)
        {
            TambahTugascs baru = new TambahTugascs();
            baru.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
