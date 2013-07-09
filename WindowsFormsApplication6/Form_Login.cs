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
    public partial class Form_Login : Form
    {
        public struct _temp
        {
            public string username;
            public string password;
            public byte tip;
            public string s;
            public string rec;
            public _temp(string username, string password, string s, byte tip, string rec)
            {
                this.username = username;
                this.password = password;
                this.s = s;
                this.rec = rec;
                this.tip = tip;
            }
        }
        public struct _login
        {
            public string username;
            public string password;
            public byte tip;
            public _temp temp;
            public _login(string username, string password, byte tip, _temp temp)
            {
                this.username = username;
                this.password = password;
                this.tip = tip;
                this.temp = temp;
            }
        }
       
        public Form_Login()
        {
            InitializeComponent();
        }

        private void bt_enter_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("C:\\\\Student\\Nalozi\\Nalozi.txt");
            _login login = new _login();
            Boolean t;
            t = false;

            login.username = tb_username.Text;
            login.password = tb_password.Text;
            #region provera
            while ((reader.EndOfStream != true)&&(!t))
            {
                login.temp.username = null;
                login.temp.password = null;
                login.temp.s = null;
                login.temp.rec = null;
                login.temp.tip = 3;
                int br = 0;
                login.temp.s = reader.ReadLine();
                int duzina = login.temp.s.Length;
                for (int i = 0; i < duzina; i++)
                {
                    if ((login.temp.s[i] != ' ') && (login.temp.s[i] != ';'))
                    {
                        login.temp.rec = login.temp.rec + login.temp.s[i];
                    }
                    if ((login.temp.s[i] == ' ') || (login.temp.s[i] == ';'))
                    {
                        br++;
                        #region switch
                        switch (br)
                        {
                            case 1:
                                {
                                    login.temp.username = login.temp.rec;
                                    login.temp.rec = null;
                                    break;
                                }
                            case 2:
                                {
                                    login.temp.password = login.temp.rec;
                                    login.temp.rec = null;
                                    break;
                                }
                            case 3:
                                {
                                    login.temp.tip = Convert.ToByte(login.temp.rec);
                                    login.temp.rec = null;
                                    break;
                                }
                        }
                        #endregion
                    }
                }
            #endregion
                br = 0;
                if ((login.temp.username == login.username) && (login.temp.password == login.password))
                {
                    login.tip = login.temp.tip;
                    t = true;
                    switch (login.tip)
                    {
                        case 0:
                            {
                                this.Hide();
                                Form_Student fstud = new Form_Student();
                                fstud.ShowDialog();
                                break;
                            }
                        case 1:
                            {
                                this.Hide();
                                Form_Profesor fprof = new Form_Profesor();
                                fprof.ShowDialog();
                                break;
                            }
                    }
                }
            }
            if (t == false)
            {
                MessageBox.Show("neispravno korisnicko ime i/ili lozinka");
                tb_username.Text = null; ;
                tb_password.Text = null;
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            bool isExsist;
            isExsist = System.IO.Directory.Exists("C:\\\\Student\\Nalozi");
            if (!isExsist)
            {
                System.IO.Directory.CreateDirectory("C:\\\\Student\\Nalozi");
            }

            isExsist = System.IO.Directory.Exists("C:\\\\Student\\Datoteke");
            if (!isExsist)
            {
                System.IO.Directory.CreateDirectory("C:\\\\Student\\Datoteke");
            }

            isExsist = System.IO.Directory.Exists("C:\\\\Student\\Lista");
            if (!isExsist)
            {
                System.IO.Directory.CreateDirectory("C:\\\\Student\\Lista");
            }

            isExsist = System.IO.File.Exists("C:\\\\Student\\Nalozi\\Nalozi.txt");
            if (!isExsist)
            {
                using (StreamWriter writer = new StreamWriter("C:\\\\Student\\Nalozi\\Nalozi.txt", true))
                {
                    writer.WriteLine("Dimitrije Stanisic 1;");
                    writer.WriteLine("Vukasin Jocic 0;");
                    writer.WriteLine("Petar Velickovic 1;");
                    writer.WriteLine("Pavle Milicevic 0;");
                }
             

            }
        }

      

        


    }
}