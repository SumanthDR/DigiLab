using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fortune_Infotech
{
    public partial class Home : Form
    {
        public static int var_c;
        public static int var_dbms;
        public static int var_ds;
        public static int var_nt;
        public static int var_cpp;
        public static int var_ip;
        public static int var_unix;
        public static int var_ada;
        public static int var_java;
        public static int var_dotnet;
        public static int var_mp; 
        public static int var_php;      
        public static int var_py;
        public static int var_cg;
        public static int var_flag;
        public Home()
        {
            InitializeComponent();
          //  setFormSize();
        }
            
        private void setFormSize()
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
        }
        private void SetEnableBtn(int var)
        {
            btnprg9.Visible = true;
            btnprg10.Visible = true;
            btnprg11.Visible = true;
            btnprg12.Visible = true;
            btnprg13.Visible = true;
            btnprg14.Visible = true;
            btnprg15.Visible = true;
            btnprg16.Visible = false;
            btnprg17.Visible = false;
            if (var == 1)
            {
                btnprg16.Visible = true;
            }
            if (var == 2)
            {
                btnprg16.Visible = true;
                btnprg17.Visible = true;
            }
            if(var==3)
            {
                btnprg15.Visible = false;
            }
                
        }
        public void SetDisableBtn(int var1)
        {
            btnprg9.Visible = false;
            btnprg10.Visible = false;
            btnprg11.Visible = false;
            btnprg12.Visible = false;
            btnprg13.Visible = false;
            btnprg14.Visible = false;
            btnprg15.Visible = false;
            btnprg16.Visible = false;
            btnprg17.Visible = false;
            if (var1 == 1)
            {
                btnprg9.Visible = true;
                btnprg10.Visible = true;
                btnprg11.Visible = true;
                btnprg12.Visible = true;
                btnprg13.Visible = true;
            }
            if (var1 == 2)
            {
                btnprg9.Visible = true;
                btnprg10.Visible = true;
                btnprg11.Visible = true;
            }
            if(var1==4)
            {
                btnprg9.Visible = true;
                btnprg10.Visible = true;
                btnprg11.Visible = true;
                btnprg12.Visible = true;
            }
        }
        private void SelectPrg(int args)
        {
            if (combo_subject.Text == "C Programming Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                c_program cprg = new c_program();
                cprg.MdiParent = this;
                cprg.Show();
                Home.var_c = args;
            }
            else if (combo_subject.Text == "DBMS Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                dbms objdbms = new dbms();
                objdbms.MdiParent = this;
                objdbms.Show();
                Home.var_dbms = args;
            }
            else if (combo_subject.Text == "Data Structures Using C Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                ds objds = new ds();
                objds.MdiParent = this;
                objds.Show();
                Home.var_ds = args;
            }
            else if (combo_subject.Text == "Numerical Analysis Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                nt objnt = new nt();
                objnt.MdiParent = this;
                objnt.Show();
                Home.var_nt = args;
            }
            else if (combo_subject.Text == "C++ Using OOPs Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                cpp objcpp = new cpp();
                objcpp.MdiParent = this;
                objcpp.Show();
                Home.var_cpp = args;

            }
            else if (combo_subject.Text == "HTML & XML Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                html5 objhtml = new html5();
                objhtml.MdiParent = this;
                objhtml.Show();
                Home.var_ip = args;

            }
            else if (combo_subject.Text == "UNIX Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                unix objunix = new unix();
                objunix.MdiParent = this;
                objunix.Show();
                Home.var_unix = args;

            }
            else if (combo_subject.Text == "ADA Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                ada objada = new ada();
                objada.MdiParent = this;
                objada.Show();
                Home.var_ada = args;
            }
            else if (combo_subject.Text == "JAVA Programming Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                java objjava = new java();
                objjava.MdiParent = this;
                objjava.Show();
                Home.var_java = args;

            }
            else if (combo_subject.Text == "DOT NET Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                dotnet objdotnet = new dotnet();
                objdotnet.MdiParent = this;
                objdotnet.Show();
                Home.var_dotnet = args;
            }
            else if (combo_subject.Text == "Micro Processor Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                micropro objmicropro = new micropro();
                objmicropro.MdiParent = this;
                objmicropro.Show();
                Home.var_mp = args;
            }
            else if (combo_subject.Text == "PHP Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                php objphp = new php();
                objphp.MdiParent = this;
                objphp.Show();
                Home.var_php = args;
            }
            else if (combo_subject.Text == "Python Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                python objpy = new python();
                objpy.MdiParent = this;
                objpy.Show();
                Home.var_py = args;
            }
            else if (combo_subject.Text == "Computer Graphics Lab")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                cg objcg = new cg();
                objcg.MdiParent = this;
                objcg.Show();
                Home.var_cg = args;
            }
            else
            {
                MessageBox.Show("Select the Subject first !!");
            }
                
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SelectPrg(1);
        }

        private void btnprg2_Click(object sender, EventArgs e)
        {
            SelectPrg(2);
        }

        private void btnprg3_Click(object sender, EventArgs e)
        {
            SelectPrg(3);
        }

        private void btnprg4_Click(object sender, EventArgs e)
        {
            SelectPrg(4);
        }

        private void btnprg5_Click(object sender, EventArgs e)
        {
            SelectPrg(5);
        }

        private void btnprg6_Click(object sender, EventArgs e)
        {
            SelectPrg(6);
        }

        private void btnprg7_Click(object sender, EventArgs e)
        {
            SelectPrg(7);
        }

        private void btnprg8_Click(object sender, EventArgs e)
        {
            SelectPrg(8);
        }

        private void btnprg9_Click(object sender, EventArgs e)
        {
            SelectPrg(9);
        }

        private void btnprg10_Click(object sender, EventArgs e)
        {
            SelectPrg(10);
        }

        private void btnprg11_Click(object sender, EventArgs e)
        {
            SelectPrg(11);
        }

        private void btnprg12_Click(object sender, EventArgs e)
        {
            SelectPrg(12);
        }

        private void btnprg13_Click(object sender, EventArgs e)
        {
            SelectPrg(13);
        }

        private void btnprg14_Click(object sender, EventArgs e)
        {
            SelectPrg(14);
        }

        private void btnprg15_Click(object sender, EventArgs e)
        {
            SelectPrg(15);
        }

        private void btnprg16_Click(object sender, EventArgs e)
        {
            SelectPrg(16);
        }

        private void btnprg17_Click(object sender, EventArgs e)
        {
            SelectPrg(17);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void Home_Load_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            labelDate.Text = DateTime.Today.ToString("dd-MM-yyyy");
            About abt = new About();
            abt.MdiParent = this;
            abt.Show();
        }

        private void btncontent_Click(object sender, EventArgs e)
        {
            SelectPrg(100);
        }

        private void combo_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_subject.Text=="C Programming Lab")
            {
                SetEnableBtn(0);
            }
            else if (combo_subject.Text == "DBMS Lab")
            {
                SetDisableBtn(4);
            }
            else if (combo_subject.Text == "Data Structures Using C Lab")
            {
                SetEnableBtn(2);
            }
            else if (combo_subject.Text == "Numerical Analysis Lab")
            {
                SetDisableBtn(0);
            }
            else if (combo_subject.Text == "C++ Using OOPs Lab")
            {
                SetEnableBtn(1);
            }
            else if (combo_subject.Text == "HTML & XML Lab")
            {
                SetEnableBtn(3);
            }
            else if (combo_subject.Text == "UNIX Lab")
            {
                SetEnableBtn(0);
            }
            else if (combo_subject.Text == "ADA Lab")
            {
                SetEnableBtn(0);
            }
            else if (combo_subject.Text == "JAVA Programming Lab")
            {
                SetDisableBtn(4);
            }
            else if (combo_subject.Text == "DOT NET Lab")
            {
                SetEnableBtn(0);
            }
            else if (combo_subject.Text == "Micro Processor Lab")
            {
                SetDisableBtn(2);
            }
            else if (combo_subject.Text == "PHP Lab")
            {
                SetDisableBtn(1);
            }
            else if (combo_subject.Text == "Python Lab")
            {
                SetDisableBtn(2);
            }
            else if (combo_subject.Text == "Computer Graphics Lab")
            {
                SetDisableBtn(4);
            }
            else if (combo_subject.Text == "----Select----")
            {
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                About abt = new About();
                abt.MdiParent = this;
                abt.Show();
            }
            else
            {
                MessageBox.Show("Select the Subject First !!");
            }
        }
    }
}
