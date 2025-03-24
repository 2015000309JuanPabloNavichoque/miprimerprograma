namespace proyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);

            for (int cont = 0; cont < 10; cont++)
            {
                int multiplicacion;
                multiplicacion = num1 * cont;
                dataGridView1.Rows.Add(num1, cont, multiplicacion);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
