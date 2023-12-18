namespace Desafio1NombreApellido
{
    public partial class Form1 : Form
    {
        public string? name_1;
        public string? lastname_1;
        public int? dni_1;
        public int? age_1;
        public double? height_1;

        int result;

        public Form1()
        {
            InitializeComponent();
        }

        private void student1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name_1 = "David";
            lastname_1 = "Cicconi";
            dni_1 = 37447255;
            age_1 = 28;
            height_1 = 1.70;

            name.Text = $"Name: {name_1}";
            lastname.Text = $"Lastname: {lastname_1}";
            dni.Text = $"DNI: {dni_1}";
            age.Text = $"Age: {age_1} ";
            height.Text = $"Height {height_1}";
        }

        private void label_student1(object sender, EventArgs e)
        {

        }

        private void name1_Click_1(object sender, EventArgs e)
        {

        }

        private void lastname1_Click(object sender, EventArgs e)
        {

        }

        private void dni1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2;

            if(int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                result = num1 + num2;
                label3.Text = $"The result is: {result}";
                label3.Visible = true;
            } else
            {
                label3.Text = "Error: You've to put numbers in text boxs.";
                label3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            name_1 = "David";
            lastname_1 = "Cicconi";
            const string surname = "The Dev";

            label4.Text = $"{name_1} '{surname}' {lastname_1}.";
            label4.Visible = true;  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
