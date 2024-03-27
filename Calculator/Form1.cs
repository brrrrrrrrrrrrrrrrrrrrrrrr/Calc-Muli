namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text); //Storing integer values textBox1/2 in variables "a" and "b" respectively.
                int b = int.Parse(textBox2.Text);
                int c; // Variable "c" will be used to store the result of calculations.

                if (radioButton1.Checked)
                {
                    c = a + b;
                    label4.Text = "Add = " + c.ToString(); // Add first and second number.
                }
                else if (radioButton2.Checked)
                {
                    c = a - b;
                    label4.Text = "Subtract = " + c.ToString(); // Subtract second from first number.
                }
                else if (radioButton3.Checked)
                {
                    c = a * b;
                    label4.Text = "Multiply = " + c.ToString(); // Multiply first and second number.
                }
                else if (radioButton4.Checked)
                {
                    if (b != 0) // Check for division by 0.
                    {
                        c = a / b;
                        label4.Text = "Divide = " + c.ToString(); // Divide first by second number.
                    }
                    else
                    {
                        label4.Text = "ERROR(Divide by 0)"; // Handle division by zero error.
                    }
                }
                else if (radioButton5.Checked)
                {
                    if (b != 0) // Check for division by 0.
                    {
                        c = a % b;
                        label4.Text = "Modulo = " + c.ToString(); // Mod first number and second number.
                    }
                    else
                    {
                        label4.Text = "ERROR(Modulo by 0)"; // Handle modulo by zero error.
                    }
                }
                else
                {
                    label4.Text = "Please select an operation."; // Prompt the user to select an operation.
                }
            }
            catch (FormatException)
            {
                label4.Text = "Invalid input. Please enter valid numbers."; // Handle invalid input format(No Input).
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; // Clears textbox 1.
            textBox2.Text = ""; // Clears textbox 2.
            label4.Text = "";   // Clears label4.
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green; //Makes button green when cursor is hovering
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver; //Makes button silver when cursor is hovering
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red; //Makes button red when cursor is hovering
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver; //Makes button silver when cursor is hovering
        }
    }
}
