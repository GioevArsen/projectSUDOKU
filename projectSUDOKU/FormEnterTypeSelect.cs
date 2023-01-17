using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectSUDOKU
{
    public partial class FormEnterTypeSelect : Form
    {
        public string[] types = { "keys", "numpad", "mouse" };
        public static string type;


        public FormEnterTypeSelect()
        {
            InitializeComponent();
        }

        


        private void buttonKEYS_Click(object sender, EventArgs e)
        {
            type = "keys";
            this.Close();
        }

        private void buttonNUMPAD_Click(object sender, EventArgs e)
        {
            type = "numpad";
            this.Close();
        }

        private void FormEnterTypeSelect_Load(object sender, EventArgs e)
        {
            
        }


        // - in process
        private void buttonMOUSECLICK_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке");
        }
    }
}
