using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class MensajesClass : ClaseMaestra
    {
        ConexionDB Conexion = new ConexionDB();
        public int MensajeId { get; set; }
        public string Email { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }

        public MensajesClass()
        {
            this.MensajeId = 0;
            this.Email = "";
            this.Asunto = "";
            this.Mensaje = ""; 
        }

        public MensajesClass(int mensajeid, string email, string asunto, string mensaje)
        {
            this.MensajeId = mensajeid;
            this.Email = email;
            this.Asunto = asunto;
            this.Mensaje = mensaje;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                Conexion.Ejecutar(String.Format("Insert into Mensajes (Email, Asunto, Mensaje) Values ('{0}', '{1}', '{2}')", this.Email, this.Asunto, this.Mensaje));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = Conexion.ObtenerDatos("Select * from Mensajes Where MensajeId=" + IdBuscado);
                if (dt.Rows.Count > 0)
                {
                    this.MensajeId = (int)dt.Rows[0]["MensajeId"];
                    this.Email = dt.Rows[0]["Email"].ToString();
                    this.Asunto = dt.Rows[0]["Asunto"].ToString();
                    this.Mensaje = dt.Rows[0]["Mensaje"].ToString();;
                }
            }
            catch (Exception ex) { throw ex; }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
