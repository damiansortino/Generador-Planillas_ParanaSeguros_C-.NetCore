using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace grafica
{
    public class Planilla
    {
        private string Idplanilla;
        private decimal total = 0; 
        public List <Recibo> recibos= new List<Recibo>();



        public Planilla()
        {
            
        }
       
        public void Guardarplanilla()
        {
            TextWriter Escribe = new StreamWriter("planilla_nueva.csv");

            //encabezado de planilla
            Escribe.WriteLine("rama;poliza;endoso;importe;cuota");

            //resto del documento

            
            for (int i = 0; i<this.recibos.Count; i++)
            {
                Escribe.WriteLine(this.recibos[i].rama+";"+ this.recibos[i].poliza+";"+
                    this.recibos[i].endoso+";"+ this.recibos[i].importe+";"+ this.recibos[i].cuota);
                
            }
            
            
            Escribe.Close();
            MessageBox.Show("Su planilla ha sido generada con éxito");
        }

        public void Guardarplanilla2(string path)
        {
            
            TextWriter Escribe = new StreamWriter(path+"planilla_nueva.csv");

            //encabezado de planilla
            Escribe.WriteLine("rama;poliza;endoso;importe;cuota");

            //resto del documento


            for (int i = 0; i < this.recibos.Count; i++)
            {
                Escribe.WriteLine(this.recibos[i].rama + ";" + this.recibos[i].poliza + ";" +
                    this.recibos[i].endoso + ";" + this.recibos[i].importe + ";" + this.recibos[i].cuota);

            }


            Escribe.Close();
            MessageBox.Show("Su planilla ha sido generada con éxito");
        }


        public void addRecibo(Recibo rec)
        {
            recibos.Add(rec);
            decimal auxiliar = Convert.ToDecimal(rec.importe);
            total = total + (auxiliar) / 100;
        }
        
        public decimal Gettotal()
        {
            return total;
        }

        public bool Existerecibo(Recibo recibo)
        {
            bool bandera;

            for(int i=0; i<recibos.Count;i++)
            {
                if((recibos[i].poliza == recibo.poliza) && (recibos[i].cuota == recibo.cuota)
                    && (recibos[i].rama == recibo.rama) && (recibos[i].importe == recibo.importe)
                    && recibos[i].endoso == recibo.endoso)
                {
                    bandera = true;
                    return bandera;
                }

            }
            bandera = false;
            return bandera;
        }

    }
}





