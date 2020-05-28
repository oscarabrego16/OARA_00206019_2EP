using System;

namespace SourceCode.Modelo
{
    public class AddressDAO
    {
        public static void CrearNuevo( int idUser, String Address)
                        {
                            string sql = String.Format(
                                "INSERT INTO ADDRESS(idUser, address) VALUES({0}, '{1}');",
                                idUser,Address);
                
                            ConnectionDB.ExecuteNonQuery(sql);
                        }
                        public static void EliminarDir(int idDir)
                                 {
                                     string sql = String.Format("DELETE FROM ADDRESS WHERE idAddress = {0};",idDir);
                                     ConnectionDB.ExecuteNonQuery(sql);
                                 }
    }
}