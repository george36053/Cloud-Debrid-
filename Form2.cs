using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debrid_Skeleton
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void createAccount_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks! A confirmation email was sent to you.");
        }

        private void returnHome_button_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void exisitingAccount_button_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
