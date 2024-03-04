namespace OPERACIONES_interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {


            //Declaracion de variables

            int valor1, valor2;

            //Entrada de datos

            valor1 = int.Parse(txt1.Text);
            valor2 = int.Parse(txt2.Text);

            //Proceso

            int resultado = valor1 + valor2;
            int re = valor1 - valor2;
            int sultado = valor1 * valor2;
            int tado = valor1 / valor2;

            //Salida de datos
            txt3.Text = resultado.ToString();
            text_resta.Text = re.ToString();
            text_multiplicacion.Text = sultado.ToString();
            text_division.Text = tado.ToString();
        }




        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            text_resta.Clear();
            text_multiplicacion.Clear();
            text_division.Clear();
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }




}

