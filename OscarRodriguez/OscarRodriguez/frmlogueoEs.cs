using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OscarRodriguez.Modelo;
using OscarRodriguez.Vista;

namespace OscarRodriguez
{
    public partial class logueoEs : Form
    {
        public logueoEs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities2 ne = new notasEstudiantesEntities2())
            {
                var lista = from estu in ne.estudiante
                            where estu.usuario == txtUsuario.Text
                            && estu.contrasena == txtContrasena.Text
                            select estu;


                if (lista.Count() > 0) {

                    MessageBox.Show("el usuario es correcto");
                }
                else
                {
                    MessageBox.Show("el usuario es incorrecto intente con otro");
                }

                //var lista = from estudiante in ne.estudiante
                //            where estudiante.usuario == txtUsuario.Text
                //            && estudiante.usuario == txtContrasena.Text
                //            select estudiante;


                //if (lista.Count() > 0) {
                //    Form1 usua = new Form1();
                //    usua.Show();
                //}
                //else
                //{
                //    MessageBox.Show("el usuario no existe intente con otro");
                //}
           


            }
        }
    }
}
