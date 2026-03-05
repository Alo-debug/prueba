namespace Prueba_WinForm
{
    public partial class Form1 : Form
    {
        public int Count { get; set; }
        public Form1()
        {
            InitializeComponent();
            Count = 0;
            InicializarBoton();
        }
        private void InicializarBoton()
        {
            Button btnMostrarEtiqueta = new Button();
            btnMostrarEtiqueta.Text = "Mostrar";
            btnMostrarEtiqueta.Size = new Size(500, 250);
            btnMostrarEtiqueta.Location = new Point(50, 150);
            //components es una lista interna de los formularios que tienen todos los componentes
            btnMostrarEtiqueta.Click += Mostrar_Etiqueta;
            btnMostrarEtiqueta.Click += btn1_Click;
            this.Controls.Add(btnMostrarEtiqueta);

        }



        private void Mostrar_Etiqueta(object sender, EventArgs e)
        {
            Label lbEtiqueta = new Label();
            lbEtiqueta.ForeColor = Color.Red;
            lbEtiqueta.Text = "Soy una Etiqueta";
            lbEtiqueta.Size = new Size(100, 50);
            lbEtiqueta.Location = new Point(250, 50);
            this.Controls.Add(lbEtiqueta);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Count++;
            btn1.Text = Count.ToString();
        }
    }
}
