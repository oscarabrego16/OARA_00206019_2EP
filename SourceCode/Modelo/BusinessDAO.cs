using System;

namespace SourceCode.Modelo
{
    public class BusinessDAO
    {
        public static void CrearNuevo(string name, string descrip)
                {
                    string sql = String.Format(
                        "INSERT INTO business(name,description) VALUES ('{0}','{1}');",
                        name, descrip);
        
                    ConnectionDB.ExecuteNonQuery(sql);
                }
        public static void EliminarBus(int id)
        {
            string sql = String.Format("DELETE FROM business WHERE idBusiness = '{0}';",id);
            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}