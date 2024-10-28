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
    public partial class compras : Form
    {
        public compras()
        {
            InitializeComponent();
            string[] alias = { "codigo", "Fecha", "Cliente", "Total", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("facturae");


            navegador1.AsignarComboConTabla("clientes", "Pk_id_cliente", "nombre_cliente", 1);  // ComboBox para clientes
            navegador1.AsignarComboConTabla("inventario", "INVCODIGO", "INVCODIGO", 1);

            navegador1.AsignarForaneas("clientes", "nombre_cliente", "Fk_CLI_CODIGO", "Pk_id_cliente");
            navegador1.AsignarNombreForm("FACTURAS");
            // Configuración de los alias para las tablas adicionales

            List<string> tablas = new List<string> { "facturad"};
            navegador1.AsignarTablas(tablas);

            string[] aliasfacturadetalle = { "INVCODIGO", "FACDCANTIDAD", "FACDPRECIO" };
            navegador1.AsignarAliasExtras("facturad", aliasfacturadetalle);
            List<string> tablascomponentes = new List<string> { "facturad" };
            navegador1.AsignarTablaComponentes(tablascomponentes);

            

          //  navegador1.AsignarOperacion("facturad", "FACDCANTIDAD", "inventario", "INVCANTIDAD", "restar", "INVCODIGO", "INVCODIGO");

           // navegador1.AsignarOperacionTransaccion("inventario","INVCANTIDAD","existencias","EXISALDO","copiar", "INVCODIGO","INVCODIGO");
            //navegador1.AsignarOperacion("inventario", "FACDCANTIDAD", "existencias", "EXISALDO", "restar", "INVCODIGO");
        }

        private void compras_Load(object sender, EventArgs e)
        {
            navegador1.AsignarOperacionEnTiempoReal("FACDCANTIDAD","FACDPRECIO","multiplicar","FACTOTAL");
        }
    }
}
