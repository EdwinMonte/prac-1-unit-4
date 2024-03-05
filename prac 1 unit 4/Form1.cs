using prac_1_unit_4.Datos;
using prac_1_unit_4.Modelo;
using System.Data;

namespace prac_1_unit_4
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario dato = new Usuario();

        public int Edad { get; set; }

        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Edad");
            Grilla.DataSource = tabla;
        }
        private void Guardar()
        {
            UsuarioModel modelo = new UsuarioModel();
            {
                Name = txtnombre.Text;
                Edad = int.Parse(txtedad.Text);
            };
            dato.Guardar(modelo);
        }
            private void Consultar()
        {
            foreach (var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Edad"] = item.Edad;
                tabla.Rows.Add(fila);
            }
        }
        private void Limpiar()
        {
            txtnombre.Text = "";
            txtedad.Text = "";
        }
    }
}