using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Vista_Navegador
{
    public class OperacionCampo
    {
        public string TablaOrigen { get; set; }
        public string CampoOrigen { get; set; }
        public string TablaDestino { get; set; }
        public string CampoDestino { get; set; }
        public string Operacion { get; set; }
        public string CampoDescriptivo { get; set; } // Este es el campo que faltaba

        public OperacionCampo(string tablaOrigen, string campoOrigen, string tablaDestino, string campoDestino, string operacion, string campoDescriptivo)
        {
            TablaOrigen = tablaOrigen;
            CampoOrigen = campoOrigen;
            TablaDestino = tablaDestino;
            CampoDestino = campoDestino;
            Operacion = operacion;
            CampoDescriptivo = campoDescriptivo;  // Asignamos el valor del campo descriptivo
        }
    }

}
