using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form_Student : Form
    {
        public Form_Student()
        {
            InitializeComponent();
        }

        private void lb_raniji_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtb_tekst.LoadFile(lb_raniji.Items[lb_raniji.SelectedIndex].ToString(), RichTextBoxStreamType.RichText);
        }

        private void Form_Student_Load(object sender, EventArgs e)
        {
            string[] datoteke = System.IO.Directory.GetFiles("C:\\\\Student\\Datoteke");
            foreach (string g in datoteke)
            {
                lb_raniji.Items.Add(g);
            }
        }

        private void bt_Odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login fl = new Form_Login();
            fl.Show();
        }
    }
}
