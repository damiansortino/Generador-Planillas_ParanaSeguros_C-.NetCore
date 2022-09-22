using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace grafica
{
    public partial class Grafica : Form
    {
        int contadorbarraincorrecta = 0;


        public Grafica()
        {
            InitializeComponent();
        }

        


        private void Grafica_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //crear una planilla

        Planilla planilla1 = new Planilla();
        



        private void barra_KeyPress(object sender, KeyPressEventArgs e)
        {
           //texto de campo seleccionado

            if (String.IsNullOrEmpty(barra.Text))
            {
                barra.SelectionStart = 0;
                barra.SelectionLength = barra.Text.Length;
            }



            if ((int)e.KeyChar == (int)Keys.Enter)  //validación Enter en texbox barra

            {
                //validacion de 40 caracteres
                if (barra.TextLength == 40)
                {
                    Recibo recibo = new Recibo(barra.Text);

                    rama_label.Text = recibo.rama;
                    poliza_label.Text = recibo.poliza;
                    endoso_label.Text = recibo.endoso;
                    importe_label.Text = "$ "+recibo.importe;
                    cuota_label.Text = recibo.cuota;
                    
                    if(planilla1.Existerecibo(recibo))
                    {
                        label9.Text = "Error!";
                        label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        label9.ForeColor = System.Drawing.Color.Maroon;
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
                        MessageBox.Show("Este recibo ya se encuentra en su planilla");
                    }
                    else
                    {
                        planilla1.addRecibo(recibo);
                        label9.Text = "Lectura correcta";
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = false;
                        label9.ForeColor = System.Drawing.Color.Lime;

                        pictureBox1.Visible = true;
                    }
                 
                    muestra_lista.DataSource = null;
                    muestra_lista.DataSource = planilla1.recibos;

                    string specifier;
                    CultureInfo culture;
                    specifier = "C";
                    culture = CultureInfo.CreateSpecificCulture("en-US");
                    total_label.Text = planilla1.Gettotal().ToString(specifier, culture);

                    // muestra panel y label siguiente
                    panel_recibos.Visible = true;
                    label_sigbarra.Visible = true;
                    muestra_lista.Visible = true;


                        
                   //hace foco en barra nuevamente
                    barra.Focus();

                    //texto seleccionado de barra
                    barra.SelectionStart = 0;
                    barra.SelectionLength = barra.Text.Length;

                    e.Handled = true;
                }

                else
                {
                    MessageBox.Show("barra incorrecta, vuelva a intentarlo");
                    barra.Focus();
                    barra.SelectionStart = 0;
                    barra.SelectionLength = barra.Text.Length;

                    contadorbarraincorrecta++;
                    if (contadorbarraincorrecta == 3)
                        { MessageBox.Show("Puede que su código de barras se encuentre" +
                            " muy dañado y deba ingresarlo manualmente"); }
                    barra.Focus();
                    barra.SelectionStart = 0;
                    barra.SelectionLength = barra.Text.Length;
                }
            }
        }

        

        private void Btn_generarplanilla_Click(object sender, EventArgs e)
        {
            planilla1.Guardarplanilla();
        }

    }
}