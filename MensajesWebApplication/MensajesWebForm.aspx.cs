using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace MensajesWebApplication
{
    public partial class MensajesWebForm : System.Web.UI.Page
    {
        MensajesClass Variable = new MensajesClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            
        }

        private void ObtenerDatos()
        {
            Variable.Email = EmailTextBox.Text;
            Variable.Asunto = AsuntoTextBox.Text;
            Variable.Mensaje = MensajeTextBox.Text;
        }

        protected void EnviarButton_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
        }
    }
}