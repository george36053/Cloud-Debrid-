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
namespace Debrid_Skeleton
{
    public partial class Debrid : Form
    {
        public Debrid()
        {
            InitializeComponent();
        }

        private void getLink_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a test of the Debrid!");
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            Account form2 = new Account();
            form2.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the end of the Debrid. Goodbye!");
            this.Close();
        }

        private void textBox_Link_TextChanged(object sender, EventArgs e)
        {

        }

        private void link_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}