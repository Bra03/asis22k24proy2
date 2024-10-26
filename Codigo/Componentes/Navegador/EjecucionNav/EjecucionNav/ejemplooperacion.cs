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
            /* string[] alias = { "codigo","nombre", "precio", "cantidad","total","estado" };
             navegador1.AsignarAlias(alias);
             navegador1.AsignarSalida(this);
             navegador1.AsignarColorFondo(Color.Green);
             navegador1.AsignarColorFuente(Color.BlueViolet);
             navegador1.ObtenerIdAplicacion("1000");
             navegador1.AsignarAyuda("1");
             navegador1.ObtenerIdUsuario("admin");
             navegador1.AsignarTabla("ejemplooperaciones");
             navegador1.AsignarNombreForm("Cuentas");*/
            string[] alias = { "codigo", "Fecha", "Cliente", "Total", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("facturae");
            navegador1.AsignarVarios(true);
            navegador1.AsignarTablaVarios("facturad");
            navegador1.AsignarComboConTabla("clientes", "Pk_id_cliente", "nombre_cliente", 1);  // ComboBox para clientes
            navegador1.AsignarComboConTabla("inventario", "INVCODIGO", "INVCODIGO", 1);

            navegador1.AsignarForaneas("clientes", "nombre_cliente", "Fk_CLI_CODIGO", "Pk_id_cliente");
            navegador1.AsignarNombreForm("FACTURAS");
            // Configuración de los alias para las tablas adicionales

            List<string> tablas = new List<string> { "facturad" };
            
            navegador1.AsignarTablas(tablas);

            string[] aliasfacturadetalle = { "INVCODIGO", "FACDCANTIDAD", "FACDPRECIO" };
            navegador1.AsignarAliasExtras("facturad", aliasfacturadetalle);
            List<string> tablascomponentes = new List<string> { "facturad" };
            navegador1.AsignarTablaComponentes(tablascomponentes);


        }

        private void ejemplooperacion_Load(object sender, EventArgs e)
        {
            //navegador1.AsignarOperacionEnTiempoReal("cantidad", "Precio", "multiplicar", "total");
        }
    }
}
