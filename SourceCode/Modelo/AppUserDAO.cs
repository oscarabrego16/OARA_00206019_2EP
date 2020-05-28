using System;
using System.Data;

namespace SourceCode.Modelo
{
    public class AppUserDAO
    {
        public static AppUser GetUser(String nombre, String contra)
        {
            string sql = String.Format("SELECT * FROM appuser WHERE username = '{0}' AND password = '{1}';", nombre, contra);

            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            AppUser u = new AppUser();
            foreach (DataRow fila in dt.Rows)
            {
                u.idUser = Convert.ToInt32(fila[0].ToString());
                u.fullName = fila[1].ToString();
                u.userName = fila[2].ToString();
                u.password = fila[3].ToString();
                u.userType = Convert.ToBoolean(fila[4].ToString());
            }
            return u;
        }
        public static AppUser GetUser(String nombre)
                {
                    string sql = String.Format("SELECT * FROM appuser WHERE username = '{0}' ;", nombre);
        
                    DataTable dt = ConnectionDB.ExecuteQuery(sql);
        
                    AppUser u = new AppUser();
                    foreach (DataRow fila in dt.Rows)
                    {
                        u.idUser = Convert.ToInt32(fila[0].ToString());
                        u.fullName = fila[1].ToString();
                        u.userName = fila[2].ToString();
                        u.password = fila[3].ToString();
                        u.userType = Convert.ToBoolean(fila[4].ToString());
                    }
                    return u;
                }

        public static void UpdatePass(string newPass, AppUser user)
        {
            string sql = String.Format("UPDATE appuser SET password = '{0}' WHERE idUser = {1};",newPass, user.idUser);
            ConnectionDB.ExecuteNonQuery(sql);
        }
        public static void CrearNuevo(string fullname, string username, bool usertype)
        {
            string sql = String.Format(
                "INSERT INTO appuser(fullname,username,password,usertype) VALUES ('{0}','{1}','{1}','{2}');",
                fullname, username, usertype);

            ConnectionDB.ExecuteNonQuery(sql);
        }
        public static void EliminarUser(string username)
                {
                    string sql = String.Format("DELETE FROM appuser WHERE username = '{0}';",username);
                    ConnectionDB.ExecuteNonQuery(sql);
                }
    }
}