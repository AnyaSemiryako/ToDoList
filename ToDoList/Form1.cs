using System.Threading.Tasks;

namespace ToDoList
{
    public partial class Form1 : Form
    {

        List<string> list = new List<string>();




        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            check.Items.Add(str);
            list.Add(str);
            textBox1.Clear();

        }

        private void check_SelectedIndexChanged(object sender, EventArgs e)
        {
            check.Items.Remove(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            check.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            check.Items.RemoveAt(check.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            check.Items.Clear();
            foreach (string str in list)
            {
                check.Items.Add(str);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}