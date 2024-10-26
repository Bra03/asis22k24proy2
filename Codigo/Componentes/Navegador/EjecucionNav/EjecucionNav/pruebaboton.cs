﻿using System;
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
    public partial class pruebaboton : Form
    {
        public pruebaboton()
        {
            InitializeComponent();
            string[] alias = { "Codigo", "TipoCuenta", "Grupo cuenta", "Nombre", "Cargo-Mes", "Abono-Mes", "Saldo-Anterior", "Saldo-Actual", "Cargo-Acumulado", "Abono-Acumulado", "Cuenta padre", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("tbl_cuentas");
            navegador1.AsignarNombreForm("Cuentas");
           
            navegador1.AsignarComboConTabla("tbl_tipocuenta", "PK_id_tipocuenta", "nombre_tipocuenta", 1);
            navegador1.AsignarComboConTabla("tbl_encabezadoclasecuenta", "Pk_id_encabezadocuenta", "nombre_tipocuenta", 1);
            navegador1.AsignarComboConTabla("tbl_cuentas", "Pk_id_cuenta", "nombre_cuenta", 1);

            navegador1.AsignarForaneas("tbl_tipocuenta", "serie_tipocuenta", "Pk_id_tipocuenta", "PK_id_tipocuenta");
            navegador1.AsignarForaneas("tbl_encabezadoclasecuenta", "nombre_tipocuenta", "Pk_id_encabezadocuenta","Pk_id_encabezadocuenta");

            navegador1.AsignarVarios(true);
            // navegador1.AsignarForaneas("tbl_cuentas", "nombre_cuenta", "Pk_id_cuenta_enlace", "Pk_id_cuenta");
        }
    }
}