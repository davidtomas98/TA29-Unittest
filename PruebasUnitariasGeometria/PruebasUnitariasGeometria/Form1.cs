using System;
using System.Drawing;
using System.Windows.Forms;
using Geometria;

namespace PruebasUnitariasGeometria
{
    public partial class Form1 : Form
    {
        private Label lblFigura;
        private ComboBox cmbFigura;
        private Label lblMedida1;
        private TextBox txtMedida1;
        private Label lblMedida2;
        private TextBox txtMedida2;
        private Label lblMedida3;
        private TextBox txtMedida3;
        private Button btnCalcular;
        private Label lblResultado;

        public Form1()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            // Crear controles de interfaz gráfica
            lblFigura = new Label();
            lblFigura.Text = "Selecciona una figura:";
            lblFigura.Location = new Point(20, 20);

            cmbFigura = new ComboBox();
            cmbFigura.Items.AddRange(new string[] { "Cuadrado", "Círculo", "Triángulo", "Rectángulo", "Pentágono", "Rombo", "Romboide", "Trapecio" });
            cmbFigura.SelectedIndex = 0;
            cmbFigura.Location = new Point(150, 20);

            lblMedida1 = new Label();
            lblMedida1.Text = "Medida 1:";
            lblMedida1.Location = new Point(20, 60);

            txtMedida1 = new TextBox();
            txtMedida1.Location = new Point(150, 60);

            lblMedida2 = new Label();
            lblMedida2.Text = "Medida 2:";
            lblMedida2.Location = new Point(20, 100);

            txtMedida2 = new TextBox();
            txtMedida2.Location = new Point(150, 100);

            lblMedida3 = new Label();
            lblMedida3.Text = "Medida 3:";
            lblMedida3.Location = new Point(20, 140);

            txtMedida3 = new TextBox();
            txtMedida3.Location = new Point(150, 140);



            btnCalcular = new Button();
            btnCalcular.Text = "Calcular";
            btnCalcular.Location = new Point(20, 180);
            btnCalcular.Click += btnCalcular_Click;

            lblResultado = new Label();
            lblResultado.Location = new Point(20, 220);

            // Suscribir el evento SelectedIndexChanged del ComboBox para controlar la visibilidad del tercer control de medida
            cmbFigura.SelectedIndexChanged += cmbFigura_SelectedIndexChanged;


            // Agregar controles a la ventana
            Controls.Add(lblFigura);
            Controls.Add(cmbFigura);
            Controls.Add(lblMedida1);
            Controls.Add(txtMedida1);
            Controls.Add(lblMedida2);
            Controls.Add(txtMedida2);
            Controls.Add(lblMedida3);
            Controls.Add(txtMedida3);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);

            // Al principio, solo mostrar la medida 1
            lblMedida1.Visible = true;
            txtMedida1.Visible = true;
            lblMedida2.Visible = false;
            txtMedida2.Visible = false;
            lblMedida3.Visible = false;
            txtMedida3.Visible = false;
        }

        private void cmbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            string figuraSeleccionada = cmbFigura.SelectedItem.ToString();


            // Mostrar o ocultar los controles de medida según la figura seleccionada
            if (figuraSeleccionada == "Cuadrado" || figuraSeleccionada == "Círculo")
            {
                lblMedida1.Visible = true;
                txtMedida1.Visible = true;
                lblMedida2.Visible = false;
                txtMedida2.Visible = false;
                lblMedida3.Visible = false;
                txtMedida3.Visible = false;
            }
            else if (figuraSeleccionada == "Trapecio")
            {
                lblMedida1.Visible = true;
                txtMedida1.Visible = true;
                lblMedida2.Visible = true;
                txtMedida2.Visible = true;
                lblMedida3.Visible = true;
                txtMedida3.Visible = true;
            }
            else
            {
                lblMedida1.Visible = true;
                txtMedida1.Visible = true;
                lblMedida2.Visible = true;
                txtMedida2.Visible = true;
                lblMedida3.Visible = false;
                txtMedida3.Visible = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string figuraSeleccionada = cmbFigura.SelectedItem.ToString();
                int medida1 = Convert.ToInt32(txtMedida1.Text);


                Geometria.Geometria geometria = new Geometria.Geometria();
                double areaCalculada = 0;

                switch (figuraSeleccionada)
                {
                    case "Cuadrado":
                        areaCalculada = geometria.areacuadrado(medida1);
                        break;
                    case "Círculo":
                        areaCalculada = geometria.areaCirculo(medida1);
                        break;
                    case "Triángulo":
                        int medida2 = Convert.ToInt32(txtMedida2.Text);
                        areaCalculada = geometria.areatriangulo(medida1, medida2);
                        break;
                    case "Rectángulo":
                        medida2 = Convert.ToInt32(txtMedida2.Text);
                        areaCalculada = geometria.arearectangulo(medida1, medida2);
                        break;
                    case "Pentágono":
                        medida2 = Convert.ToInt32(txtMedida2.Text);
                        areaCalculada = geometria.areapentagono(medida1, medida2);
                        break;
                    case "Rombo":
                        medida2 = Convert.ToInt32(txtMedida2.Text);
                        areaCalculada = geometria.arearombo(medida1, medida2);
                        break;
                    case "Romboide":
                        medida2 = Convert.ToInt32(txtMedida2.Text);
                        areaCalculada = geometria.arearomboide(medida1, medida2);
                        break;
                    case "Trapecio":
                        int medida3 = Convert.ToInt32(txtMedida3.Text);
                        medida2 = Convert.ToInt32(txtMedida2.Text);
                        areaCalculada = geometria.areatrapecio(medida1, medida2, medida3);
                        break;
                }

                lblResultado.Text = $"El área es: {areaCalculada}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa valores válidos para las medidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
