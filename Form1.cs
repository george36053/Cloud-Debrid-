namespace Debrid_Skeleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getLink_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a test of the Debrid!");
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
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