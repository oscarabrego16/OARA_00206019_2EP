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

        public static void UpdatePass(string newPass, AppUser user)
        {
            string sql = String.Format("UPDATE appuser SET password = '{0}' WHERE idUser = {1};",newPass, user.idUser);
            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}