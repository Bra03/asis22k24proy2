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
        public string CampoCondicional { get; set; } // Nuevo campo condicional
        public string ValorCondicional { get; set; } // Nuevo valor condicional

        public OperacionCampo(string tablaOrigen, string campoOrigen, string tablaDestino, string campoDestino, string operacion, string campoCondicional, string valorCondicional)
        {
            TablaOrigen = tablaOrigen;
            CampoOrigen = campoOrigen;
            TablaDestino = tablaDestino;
            CampoDestino = campoDestino;
            Operacion = operacion;
            CampoCondicional = campoCondicional;  // Asignamos el campo condicional
            ValorCondicional = valorCondicional;  // Asignamos el valor condicional
        }
    }

}
