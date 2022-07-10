using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocargestSeguros
{

    public class BDMySQL
    {

        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader lector;

        public BDMySQL()
        {
            conexion = new MySqlConnection("Database=docargestseguros; Data Source=localhost; User Id=root; Password=admin");
            conexion.Open();
        }

        public bool inicioValido(string usuario, string contrasena)
        {
            comando = new MySqlCommand("select * from usuarios where usuario='"+usuario+"' and contrasena='"+contrasena+"'", conexion);

            lector = comando.ExecuteReader();

            bool valido = lector.Read();

            lector.Close();

            return valido;
        }

        public void insertarCliente(string dni, string nombre, string apellidos, MySqlDateTime fechaAlta, MySqlDateTime fechaNac, string codPostal, string direccion, int poblacion, int provincia, string telefono, string email)
        {
            try
            {
                comando = new MySqlCommand("insert into clientes (DNI, Nombre, Apellidos, FechaAlta, FechaNac, CodPostal, Direccion, Poblacion, Provincia, Telefono, Email) values ('" + dni + "', '" + nombre + "', '" + apellidos + "', '" + (fechaAlta.Year + "-" + fechaAlta.Month + "-" + fechaAlta.Day) + "', '" + (fechaNac.Year + "-" + fechaNac.Month + "-" + fechaNac.Day) + "', '" + codPostal + "', '" + direccion + "', " + poblacion + ", " + provincia + ", '" + telefono + "', '" + email + "')", conexion);

                comando.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error al añadir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void actualizarCliente(int codigo, string dni, string nombre, string apellidos, MySqlDateTime fechaNac, string codPostal, string direccion, int poblacion, int provincia, string telefono, string email)
        {
            comando = new MySqlCommand("update clientes set DNI='" + dni + "', Nombre='" + nombre + "', Apellidos='" + apellidos + "', FechaNac='" + (fechaNac.Year + "-" + fechaNac.Month + "-" + fechaNac.Day) + "', CodPostal='" + codPostal + "', Direccion='" + direccion + "', Poblacion=" + poblacion + ", Provincia=" + provincia + ", Telefono='" + telefono + "', Email='" + email + "' where Codigo=" + codigo, conexion);

            comando.ExecuteNonQuery();
        }

        public void cargarProvincias(ComboBox cProvincias)
        {
            comando = new MySqlCommand("select provincia from provincias", conexion);

            lector = comando.ExecuteReader();

            cProvincias.Items.Clear();

            while (lector.Read())
            {
                cProvincias.Items.Add(lector.GetValue(0));
            }

            lector.Close();

        }

        public void cargarClientes(DataGridView tablaClientes, ToolStripProgressBar b)
        {
            comando = new MySqlCommand("select Codigo, Nombre, Apellidos, Telefono, prov.provincia, mun.municipio from clientes c join provincias prov on c.Provincia=prov.id join municipios mun on c.Poblacion=mun.id", conexion);

            lector = comando.ExecuteReader();

            int max = 0;

            while (lector.Read())
            {
                max++;
            }

            b.Value = 0;
            b.Maximum = max;

            lector.Close();

            lector = comando.ExecuteReader();

            tablaClientes.Rows.Clear();

            while (lector.Read())
            {
                b.Value++;
                tablaClientes.Rows.Add(lector.GetValue(0), lector.GetValue(1), lector.GetValue(2), lector.GetValue(3), lector.GetValue(4), lector.GetValue(5));
            }

            lector.Close();

        }


        public void cargarMunicipios(ComboBox cMunicipios, int id)
        {
            comando = new MySqlCommand("select municipio from municipios where provincia=" + id, conexion);

            lector = comando.ExecuteReader();

            cMunicipios.Items.Clear();

            while (lector.Read())
            {
                cMunicipios.Items.Add(lector.GetValue(0));
            }

            lector.Close();

        }

        public string getMunicipio(int poblacion)
        {
            comando = new MySqlCommand("select municipio from municipios where id=" + poblacion, conexion);

            lector = comando.ExecuteReader();

            string r = "";

            if (lector.Read())
                r = lector.GetString(0);

            lector.Close();

            return r;
        }

        public int getIdMunicipio(string municipio)
        {
            comando = new MySqlCommand("select id from municipios where municipio='" + municipio + "'", conexion);

            lector = comando.ExecuteReader();

            int id = 0;

            if (lector.Read())
                id = lector.GetInt32(0);

            lector.Close();

            return id;

        }

        public string getProvincia(int provincia)
        {
            try
            {
                comando = new MySqlCommand("select provincia from provincias where id=" + provincia, conexion);

                lector = comando.ExecuteReader();

                string r = "";

                if (lector.Read())
                    r = lector.GetString(0);

                lector.Close();

                return r;
            }
            catch
            {
                return "";
            }
        }

        public MySqlDataReader getClienteFromId(string codigo)
        {
            try
            {
                comando = new MySqlCommand("select * from clientes where Codigo=" + codigo, conexion);

                lector = comando.ExecuteReader();

                return lector;
            }
            catch
            {
                return null;
            }
        }

        public void eliminarCliente(string codigo)
        {
            if (MessageBox.Show("¿Esta seguro de que quiere eliminar el cliente con el código " + codigo + "?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                comando = new MySqlCommand("delete from clientes where Codigo=" + codigo, conexion);

                comando.ExecuteNonQuery();
            }
        }

        public int getIdProvincia(string provincia)
        {
            comando = new MySqlCommand("select id from provincias where provincia='" + provincia + "'", conexion);

            lector = comando.ExecuteReader();

            int id = 0;

            if (lector.Read())
                id = lector.GetInt32(0);

            lector.Close();

            return id;

        }

    }
}
