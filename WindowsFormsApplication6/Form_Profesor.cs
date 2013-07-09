using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication6
{

    public partial class Form_Profesor : Form
    {

        public Form_Profesor()
        {
            InitializeComponent();
        }

        private void tb_naziv_MouseDown(object sender, MouseEventArgs e)
        {
            tb_naziv.Text = null;
        }

        private void bt_Odjava_Click(object sender, EventArgs e)
        {
            Form_Login flog = new Form_Login();
            this.Hide();
            flog.Show();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {

            string s;
            Boolean postoji;
            postoji = false;
            s ="C:\\\\Student\\Datoteke\\";
            s = s+tb_naziv.Text;
            s = s + ".rtf";
            if (System.IO.File.Exists(s))
            {
                MessageBox.Show("datoteka sa tim imenom vec postoji, izaberite novi naziv");
                postoji = true;
            }
            if (!postoji)
            {
                rtb_tekst.SaveFile(s);
                MessageBox.Show("sacuvano");
                    using (BinaryWriter bWriter = new BinaryWriter(File.Open("C:\\\\Student\\Lista\\lista.bin", FileMode.Append)))
                    {
                        bWriter.Write(tb_naziv.Text);
                    }
            }
            lb_raniji.Items.Clear();
            string[] datoteke = Directory.GetFiles("C:\\\\Student\\Datoteke");
            foreach (string g in datoteke)
            {
                lb_raniji.Items.Add(g);
            }
        }

        private void Form_Profesor_Load(object sender, EventArgs e)
        {
            string[] datoteke = Directory.GetFiles("C:\\\\Student\\Datoteke");
            foreach (string s in datoteke)
            {
                    lb_raniji.Items.Add(s);
            }
        }

        private void lb_raniji_SelectedIndexChanged(object sender, EventArgs e)
        {

                rtb_tekst.LoadFile(lb_raniji.Items[lb_raniji.SelectedIndex].ToString(), RichTextBoxStreamType.RichText);
            
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string s = lb_raniji.Items[lb_raniji.SelectedIndex].ToString();
            System.IO.File.Delete(s);
            lb_raniji.Items.Clear();
            MessageBox.Show("obrisano");
            string[] datoteke = Directory.GetFiles("C:\\\\Student\\Datoteke");
            foreach (string g in datoteke)
            {
                lb_raniji.Items.Add(g);
            }
        }
    }
}
