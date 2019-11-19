using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dentalsof
{

    class conexion
    {  
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        private DataSet ds;
        public DataTable MostrarDatos()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from tratamientos", cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];        
        }
        public conexion()
        {
            try
            {
                //cn = new SqlConnection("Data Source=DIANA;Initial Catalog=DENTALSOFT;Integrated Security=True");
              // new SqlConnection(@"Data Source=SHAREPOINT\SHAREPOINTDB;Initial Catalog=XXXXXXDATA;Integrated Security=False;Persist Security Info=True
                cn = new SqlConnection("Data Source=LAPTOP-11JL0HU6\\PRUEBA;Initial Catalog=DENTALSOFT;Integrated Security=True");
                //cn = new SqlConnection("Data source = LAPTOP-DO8KFJPU; Initial catalog = DENTALSOFT; Integrated security = true");
                cn.Open();

                //MessageBox.Show("Conectado");
                //"Data source = DESKTOP-AJ6PA22; Initial catalog = DENTALSOFT; Integrated security = true"
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó con la base de datos" + ex.ToString());

            }
            cn.Close();
        }

        //Diana
        public void seleccionar(ComboBox combobox)
        {

            cn.Open();
            cmd = new SqlCommand("Select * from PACIENTE_NUEVO", cn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                combobox.Items.Add(dr[1].ToString());
            }
            cn.Close();
            combobox.Items.Insert(0, "--Seleccione un nombre--");
            combobox.SelectedIndex = 0;
        }
        public void seleccionar_tratamiento(ComboBox combobox)
        {

            cn.Open();
            cmd = new SqlCommand("Select * from tratamientos", cn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                combobox.Items.Add(dr[1].ToString());
            }
            cn.Close();
            combobox.Items.Insert(0, "--Seleccione un tratamiento--");
            combobox.SelectedIndex = 0;
        }
        public string [] cargar_info(string nombre)
        {
            cn.Open();
            cmd = new SqlCommand("Select * from PACIENTE_NUEVO where nom_paciente = '" + nombre + "'", cn);
            dr = cmd.ExecuteReader();
            string [] resultado = null;
            while (dr.Read())
            {
                string[] valores = { dr[0].ToString(), dr[5].ToString() };
                resultado = valores;
            }
            cn.Close();
            return resultado;
        }

        public string[] cargar_costo_tratamiento(string nombre)
        {
            cn.Open();
            cmd = new SqlCommand("Select costo_tratamiento from tratamientos where nom_tratamiento = '" + nombre + "'", cn);
            dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores = { dr[0].ToString() };
                resultado = valores;
            }
            cn.Close();
            return resultado;
        }
        public string[] cargar_tratamiento(string nombre)
        {
            cn.Open();
            cmd = new SqlCommand("Select costo_tratamiento from tratamientos where nom_paciente = '" + nombre + "'", cn);
            dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores = { dr[2].ToString()};
                resultado = valores;
            }
            cn.Close();
            return resultado;
        }

        public string[] cargar_DatosGenerales(string nombre)
        {
            cn.Open();
            cmd = new SqlCommand("Select * from PACIENTE_NUEVO where nom_paciente = '" + nombre + "'", cn);
            dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores = 
                { 
                    dr[0].ToString(), 
                    dr[1].ToString(), 
                    dr[2].ToString(), 
                    dr[3].ToString(), 
                    dr[4].ToString(), 
                    dr[5].ToString(), 
                    dr[6].ToString(),
                    dr[7].ToString(),
                    dr[8].ToString(),
                    dr[9].ToString(),
                    dr[10].ToString(),
                    dr[11].ToString(),
                    dr[12].ToString(),
                    dr[13].ToString()
                };
                resultado = valores;
            }
            cn.Close();
            return resultado;

        }
        public string[] cargar_historialclinico(string nombre)
        {
            cn.Open();
            cmd = new SqlCommand("Select * from historialclinico where nom_paciente = '" + nombre + "'", cn);
            dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores = 
                {  
                    dr[3].ToString(), 
                    dr[4].ToString(), 
                    dr[5].ToString(), 
                    dr[6].ToString(),
                    dr[7].ToString(),
                    dr[8].ToString(),
                    dr[9].ToString(),
                    dr[10].ToString(),
                    dr[11].ToString(),
                    dr[12].ToString(),
                    dr[14].ToString(),
                    dr[15].ToString(),
                    dr[16].ToString(),
                    dr[17].ToString(),
                    dr[18].ToString(),
                    dr[19].ToString(),
                    dr[20].ToString(),
                    dr[21].ToString(),
                    dr[22].ToString(),
                    dr[23].ToString(),
                    dr[24].ToString(),
                    dr[25].ToString(),
                    dr[26].ToString(),
                    dr[27].ToString(),
                    dr[28].ToString(),
                    dr[29].ToString(),
                    dr[30].ToString(),
                    dr[31].ToString(),
                    dr[32].ToString(),
                    dr[33].ToString(),
                    dr[34].ToString(),
                    dr[35].ToString(),
                    dr[36].ToString(),
                    dr[37].ToString(),
                    dr[38].ToString(),
                    dr[39].ToString(),
                    dr[40].ToString(),
                    dr[41].ToString(),
                    dr[42].ToString(),
                    dr[43].ToString(),
                    dr[44].ToString()
                };
                resultado = valores;
            }
            cn.Close();
            return resultado;

        }
        public string insertarCliente(string nombre, string fecha, int edad, string sexo, string telefono, string direccion, string fechaNacimiento, string civil, float estatura, float peso, string ocupacion, string correo, string descripcion)
        {    
            string salida = "Se guardó correctamente";
            try 
            {
                cn.Open();
                String query = "Insert into PACIENTE_NUEVO(nom_paciente,Fregistro_paciente,edad_paciente,sexo_paciente,telf_paciente,direc_paciente,Fnacimiento_paciente,Edocivil_paciente,estatura_paciente,peso_paciente,ocupacion_paciente,correo_paciente,info_paciente) values('"+nombre+"','"+fecha+"',"+edad+",'"+sexo+"','"+telefono+"','"+direccion+"','"+fechaNacimiento+"','"+civil+"','"+estatura+"','"+peso+"','"+ocupacion+"','"+correo+"','"+descripcion+"')";
                cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            cn.Close();
            return salida;
        }
        public string insertarTratamiento(string nombre, string costo)
        {
            string salida = "Se guardó correctamente";
            try
            {
                cn.Open();
                String query = "Insert into tratamientos(nom_tratamiento,costo_tratamiento) values('" + nombre + "','" + costo + "')";
                cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            cn.Close();
            return salida;
        }
        public string ActualizarDatosCliente(string nombre, int edad, string sexo, string telefono, string direccion, string fechaNacimiento, string civil, float estatura, float peso, string ocupacion, string correo, string descripcion)
        {
            string salida = "Se actualizaron los datos correctamente.";
            try
            {
                cn.Open();
                cmd = new SqlCommand("Update PACIENTE_NUEVO set nom_paciente ='" + nombre + "', edad_paciente=" + edad + ", sexo_paciente ='" + sexo + "', telf_paciente ='" + telefono + "', direc_paciente ='" + direccion + "', Fnacimiento_paciente ='" + fechaNacimiento + "', Edocivil_paciente ='" + civil + "', estatura_paciente ='" + estatura + "', peso_paciente ='" + peso + "', ocupacion_paciente ='" + ocupacion + "', correo_paciente ='" + correo + "', info_paciente ='" + descripcion + "' where nom_paciente = '" + nombre + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizó: " + ex.ToString();
            }
            cn.Close();
            return salida;
        }
        public string ActualizarHistorial(string nombre, string Diabetes, string Presion, string Hemofilia, string Epilepsia, string Hepatitis, string Hemorragia, string Operaciones, string Tratamiento_medico, string Embarazo, string Hijos, string Tipo_parto, string A_diabetes, string A_presion, string A_enf_corazon, string A_epilepsia, string A_cancer, string Fuma, string C_alcohol, int cuantas_comidad, string dieta, string Cepilla_dientes, string Utiliza_hilo_dental, string Utiliza_enjuage_bucal, string Ultimo_examen_dental, string Motivos_consulta_hoy, string Desde_cuando_diabetes, string Desde_cuando_presion, string Desde_cuando_epilepsia, string Desde_cuando_operacion, string Desde_cuando_hemofilia, string Desde_cuando_hemorragias, string Desde_cuando_hepatitis, string De_que_tratamiento, string Desde_cuando_tratamiento, string Tx_diabetes, string Tx_presion, string Tx_hemofilia, string Tx_epilepsia, string Tx_hepatitis, string Tx_hemorragia, string Tx_operaciones)
        {
            string salida = "Se actualizaron los datos correctamente.";
            try
            {
                cn.Open();
                cmd = new SqlCommand("Update historialclinico set DIABETES ='" + Diabetes + "', PRESION ='" + Presion + "', HEMOFILIA ='" + Hemofilia + "', EPILEPSIA ='" + Epilepsia + "', HEPATITIS ='" + Hepatitis + "', HEMORRAGIA ='" + Hemorragia + "', OPERACIONES ='" + Operaciones + "', tratamiento_medico ='" + Tratamiento_medico + "', embarazo ='" + Embarazo + "', hijos ='" + Hijos + "', tipo_parto ='" + Tipo_parto + "', A_DIABETES ='" + A_diabetes + "', A_PRESION ='" + A_presion + "', A_ENF_CORAZON ='" + A_enf_corazon + "', A_EPILEPSIA ='" + A_epilepsia + "', A_CANCER ='" + A_cancer + "', FUMA ='" + Fuma + "', C_ALCOHOL ='" + C_alcohol + "', CUANTAS_COMIDAS ='" + cuantas_comidad + "', DIETAS ='" + dieta + "', CEPILLA_DIENTES ='" + Cepilla_dientes + "', UTILIZA_HILO_DENTAL ='" + Utiliza_hilo_dental + "', UTILIZA_ENJUAGUE_BUCAL ='" + Utiliza_enjuage_bucal + "', ULTIMO_EXAMEN_DENTAL ='" + Ultimo_examen_dental + "', MOTIVOS_CONSULTA_HOY ='" + Motivos_consulta_hoy + "', desde_cuando_diabetes ='" + Desde_cuando_diabetes + "', desde_cuando_presion ='" + Desde_cuando_presion + "', desde_cuando_epilepsia ='" + Desde_cuando_epilepsia + "', desde_cuando_operaciones ='" + Desde_cuando_operacion + "', desde_cuando_hemofilia ='" + Desde_cuando_hemofilia + "', desde_cuando_hemorragia ='" + Desde_cuando_hemorragias + "', desde_cuando_hepatitis ='" + Desde_cuando_hepatitis + "', de_que_tratamiento='" + De_que_tratamiento + "', desde_cuando_tratamiento='" + Desde_cuando_tratamiento + "', tx_diabetes='" + Tx_diabetes + "', tx_presion='" + Tx_presion + "', tx_hemofilia='" + Tx_hemofilia + "', tx_epilepsia='" + Tx_epilepsia + "', tx_hepatitis='" + Tx_hepatitis + "', tx_hemorragia='" + Tx_hemorragia + "' where nom_paciente = '" + nombre + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizó: " + ex.ToString();
            }
            cn.Close();
            return salida;
        } 
        public List<String> obtenerDatosClientes()
        {
            var pacientes = new List<String>();
            try
            {
                cn.Open();
                String query = "Select nom_paciente from PACIENTE_NUEVO";
                Console.WriteLine(query);
                cmd = new SqlCommand(query, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MessageBox.Show(dr.GetString(0));
                    pacientes.Add(dr.GetString(0));
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar correctamente" + ex.ToString());
            }
            return pacientes;
        }
        public List<String> obtenerNombresClientes()
        {
            var pacientes = new List<String>();
            try
            {
                cn.Open();
                String query = "Select nom_paciente from PACIENTE_NUEVO";
                Console.WriteLine(query);
                cmd = new SqlCommand(query, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pacientes.Add(dr.GetString(0));
                    
                }
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar correctamente" + ex.ToString());
            }
            return pacientes;

        }
        public int personaRegistrada(string nombre)
        {
            int contador = 0;

            try
            {
                cn.Open();
                cmd = new SqlCommand("Select * from PACIENTE_NUEVO where nom_paciente = '" + nombre + "' ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar correctamente" + ex.ToString());
            }
            cn.Close();
            return contador;
        }
        public int historial_Registrado(int id)
        {
            int contador = 0;
            
            try
            {
                cn.Open();
                cmd = new SqlCommand("Select * from historialclinico where clave_paciente = " + id + " ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar correctamente" + ex.ToString());
            }
            cn.Close();
            return contador;
        }
        public string guardarHistorial(string nombre, int clave, string Diabetes, string Presion, string Hemofilia, string Epilepsia, string Hepatitis, string Hemorragia, string Operaciones, string Tratamiento_medico, string Embarazo, string Hijos, string Tipo_parto, string A_diabetes, string A_presion, string A_enf_corazon, string A_epilepsia, string A_cancer, string Fuma, string C_alcohol, int cuantas_comidad, string dieta, string Cepilla_dientes, string Utiliza_hilo_dental, string Utiliza_enjuage_bucal, string Ultimo_examen_dental, string Motivos_consulta_hoy, string Desde_cuando_diabetes, string Desde_cuando_presion, string Desde_cuando_epilepsia, string Desde_cuando_operacion, string Desde_cuando_hemofilia, string Desde_cuando_hemorragias, string Desde_cuando_hepatitis, string De_que_tratamiento, string Desde_cuando_tratamiento, string Tx_diabetes, string Tx_presion, string Tx_hemofilia, string Tx_epilepsia, string Tx_hepatitis, string Tx_hemorragia, string Tx_operaciones)
        {
            string salida = "Se guardó correctamente";
            try
            {
                cn.Open();
                String query = "Insert into historialclinico(nom_paciente,clave_paciente,DIABETES,PRESION,HEMOFILIA,EPILEPSIA,HEPATITIS,HEMORRAGIA,OPERACIONES,tratamiento_medico,embarazo,hijos,tipo_parto,A_DIABETES,A_PRESION,A_ENF_CORAZON,A_EPILEPSIA,A_CANCER,FUMA,C_ALCOHOL,CUANTAS_COMIDAS,DIETAS,CEPILLA_DIENTES,UTILIZA_HILO_DENTAL,UTILIZA_ENJUAGUE_BUCAL,ULTIMO_EXAMEN_DENTAL,MOTIVOS_CONSULTA_HOY,desde_cuando_diabetes,desde_cuando_presion,desde_cuando_epilepsia,desde_cuando_operaciones,desde_cuando_hemofilia,desde_cuando_hemorragia,desde_cuando_hepatitis,de_que_tratamiento,desde_cuando_tratamiento,tx_diabetes,tx_presion,tx_hemofilia,tx_epilepsia,tx_hepatitis,tx_hemorragia,tx_operaciones) values('" + nombre + "'," + clave + ",'" + Diabetes + "','" + Presion + "','" + Hemofilia + "','" + Epilepsia + "','" + Hepatitis + "','" + Hemorragia + "','" + Operaciones + "','" + Tratamiento_medico + "','" + Embarazo + "','" + Hijos + "','" + Tipo_parto + "','" + A_diabetes + "','" + A_presion + "','" + A_enf_corazon + "','" + A_epilepsia + "','" + A_cancer + "','" + Fuma + "','" + C_alcohol + "'," + cuantas_comidad + ",'" + dieta + "','" + Cepilla_dientes + "','" + Utiliza_hilo_dental + "','" + Utiliza_enjuage_bucal + "','" + Ultimo_examen_dental + "','" + Motivos_consulta_hoy + "','" + Desde_cuando_diabetes + "','" + Desde_cuando_presion + "','" + Desde_cuando_epilepsia + "','" + Desde_cuando_operacion + "','" + Desde_cuando_hemofilia + "','" + Desde_cuando_hemorragias + "','" + Desde_cuando_hepatitis + "','" + De_que_tratamiento + "','" + Desde_cuando_tratamiento + "','" + Tx_diabetes + "','" + Tx_presion + "','" + Tx_hemofilia + "','" + Tx_epilepsia + "','" + Tx_hepatitis + "','" + Tx_hemorragia + "','" + Tx_operaciones + "' )";
                cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            cn.Close();
            return salida;
        }
        public int historial_Registrado2(string nombre)
        {
            int contador = 0;

            try
            {
                cn.Open();
                cmd = new SqlCommand("Select * from historialclinico where nom_paciente = '" + nombre + "' ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar correctamente" + ex.ToString());
            }
            cn.Close();
            return contador;
        }
        public int buscarCostoTratamiento(string costo)
        {
            int contador = 0;

            try
            {
                cn.Open();
                cmd = new SqlCommand("Select costo_tratamiento from tratamientos where nom_tratamiento = '" + costo + "' ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar correctamente" + ex.ToString());
            }
            cn.Close();
            return contador;
        }

        //Mercedes
        public DataTable BuscarTratamientos(string nom_tratamiento)
        {

            cn.Open();
            SqlCommand cmd = new SqlCommand(String.Format("Select * from tratamientos where nom_tratamiento like '%{0}%'", nom_tratamiento), cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];

        }
        //public String InsertarTratamientos(String nom_tratamiento, String costo_tratamiento)
        //{
        //    try
        //    {
        //        cn.Open();
        //        String query = "Insert into tratamientos(nom_tratamientos, costo_tratamientos) values('" + nom_tratamiento + "','" + costo_tratamiento + "' )";
        //        SqlCommand comando = new SqlCommand(query, cn);
        //        SqlDataReader registros = comando.ExecuteReader();
        //        String respuesta = "Cliente Registrado";
        //        while (registros.Read())
        //        {
        //            respuesta = registros.GetString(0);
        //        }
        //        return respuesta;
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //        throw;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}
        public bool EliminarTratamientos(string clave_tratamiento)
        {

            cn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from tratamientos where clave_tratamiento = '{0}'", clave_tratamiento), cn);
            int filasafectadas = cmd.ExecuteNonQuery();
            cn.Close();
            if (filasafectadas > 0) return true;
            else return false;


        }
        public bool ActualizarTratamientos(string clave_tratamiento, string nom_tratamiento, string costo_tratamiento)
        {

            cn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Update tratamientos set nom_tratamiento = '{0}', costo_tratamiento = '{1}' where clave_tratamiento= {2}", new string[] { nom_tratamiento, costo_tratamiento, clave_tratamiento }), cn);
            int filasafectadas = cmd.ExecuteNonQuery();
            cn.Close();
            if (filasafectadas > 0) return true;
            else return false;


        }
        public DataTable Buscarexpediente(string nom_paciente)
        {

            cn.Open();
            SqlCommand cmd = new SqlCommand(String.Format("select  a.fecha_cita, b.nom_tratamiento,b.descripcion_tratamiento, b.total from agenda a  inner join costos b on b.nom_paciente = a.nom_paciente where a.nom_paciente like '%{0}%' and b.nom_paciente like '%{0}%'", nom_paciente), cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];

        }
     
        public string insertarCosto(string nombre, string nom_tratamiento, string descripcion, string extra, string total)
        {
            string salida = "Se guardó correctamente";
            try
            {
                cn.Open();
                String query = "Insert into costos(nom_paciente,nom_tratamiento,costo_extra,total,descripcion_tratamiento) values('" + nombre + "','" + nom_tratamiento + "'," + extra + ",'" + total + "','" + descripcion + "')";
                cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            cn.Close();
            return salida;
        }

        //carlos 
        public List<String> obtenerHoras(String dia)
        {
            var dias = new List<String>();
            try
            {
                var diaFormato = formatoFecha(dia);
                cn.Open();
                String query = "Select hora_cita from agenda WHERE fecha_cita = '" + diaFormato + "'";
                Console.WriteLine(query);
                cmd = new SqlCommand(query, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dias.Add(dr["hora_cita"].ToString().Substring(0,(dr["hora_cita"].ToString().Length-3)));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar correctamente" + ex.ToString());
            }
            finally {
                cn.Close();
            }
            
            return dias;
        }
        public List<agenda> obtenerCitas(String fecha)
        {
            try
            {
                var listaCitas = new List<agenda>();
                var fechaFormateada = formatoFecha(fecha);
                
                String query = "Select nom_paciente, hora_cita, nom_tratamiento,fecha_cita,telf_paciente,costo_tratamiento from agenda WHERE fecha_cita = '" + fechaFormateada + "' order by hora_cita asc";
                Console.Write(query);
                cn.Open();
                cmd = new SqlCommand(query, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var citaEncontrada = new agenda(
                        dr["nom_paciente"].ToString(),
                        dr["nom_tratamiento"].ToString(),
                        dr["hora_cita"].ToString(),
                        dr["telf_paciente"].ToString(),
                        dr["fecha_cita"].ToString(),
                        dr["costo_tratamiento"].ToString()
                    );
                    listaCitas.Add(citaEncontrada);
                }
                return listaCitas;
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo consultar correctamente" + ex.ToString());
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public Boolean primeraVez(string nombre)
        {
            try
            {
                cn.Open();
                String query = "Select count(*) as cantidad from historialclinico WHERE nom_paciente = '" + nombre + "'";
                cmd = new SqlCommand(query, cn);
                Console.WriteLine(query);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["cantidad"].ToString().Equals("0"))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                if (dr.Read())
                {

                    return false;
                }
                else
                {
                    return true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar correctamente" + ex.Message);
                return false;
            }
            finally
            {
                dr.Close();
            }
        }  
        public List<String> obtenerTratamientos()
        {
            var tratamientos = new List<String>();
            try
            {
                cn.Open();
                String query = "Select nom_tratamiento from tratamientos";
                Console.WriteLine(query);
                cmd = new SqlCommand(query, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tratamientos.Add(dr.GetString(0));
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar correctamente" + ex.ToString());
            }
            return tratamientos;
        }
        public string agendarCita(string nombre, string tel, string dia, string hora, string tratamiento, string costo)
        {
            string salida = "Se agendó correctamente";
            try
            {
                cn.Open();
                dia = formatoFecha(dia);
                String query = "Insert into agenda(nom_paciente, telf_paciente, fecha_cita, nom_tratamiento,hora_cita,costo_tratamiento) values('" + nombre + "','" + tel + "','" + dia + "','" + tratamiento + "','" + hora + "','" + costo + "')";
                Console.WriteLine(query);
                cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            return salida;

        }
        public string formatoFecha(string fecha)
        {
            string[] separador = fecha.Split('/');
            if (separador.Length == 3)
            {
                string fechaNueva = separador[2] + "-" + separador[1] + "-" + separador[0];
                return fechaNueva;
            }
            else
            {
                return fecha;
            }
        }

        //Brenda
        public DataTable MostrarDatosCosto()
        {

            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from costos", cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];

        }
        public DataTable Buscarcosto(string nom_paciente)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(String.Format("Select *  from costos where nom_paciente like '%{0}%'", nom_paciente), cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];
        }

    }
}
