using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejecucionNav
{
    public partial class ejemplooperacion : Form
    {
        public ejemplooperacion()
        {
            InitializeComponent();
            string[] alias = { "codigo","nombre", "precio", "cantidad","total","estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.Green);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("ejemplooperaciones");
            navegador1.AsignarNombreForm("Cuentas");

            

        }

        private void ejemplooperacion_Load(object sender, EventArgs e)
        {
            navegador1.AsignarOperacionEnTiempoReal("cantidad", "Precio", "multiplicar", "total");
        }
    }
}
