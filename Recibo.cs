using System;
using System.Collections.Generic;
using System.Text;

namespace grafica
{
    public class Recibo
    {
        //atributos
        public string codigo_barra, rama, poliza, endoso, importe, cuota;


        //constructor
        public Recibo(string barra)
        {
            codigo_barra = barra;

            rama = codigo_barra.Substring(20, 2);
            poliza = codigo_barra.Substring(22, 8);
            endoso = codigo_barra.Substring(34, 2);
            importe = codigo_barra.Substring(5, 7)+"."+codigo_barra.Substring(12, 2);
            cuota = codigo_barra.Substring(36, 2);

        }

        public String Rama { set { rama = value; } get { return rama; }}
        public String Poliza { set { poliza = value; } get { return poliza; } }
        public String Endoso { set { endoso = value; } get { return endoso; } }
        public String Importe { set { importe= value; } get { return importe; } }
        public String Cuota { set { cuota = value; } get { return cuota; } }
       
    }
}
