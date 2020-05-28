using System;

namespace SourceCode.Modelo
{
    public class ProductDAO
    {
        public static void CrearNuevo(int idNeg, string nombreProd)
                {
                    string sql = String.Format(
                        "INSERT INTO PRODUCT(idBusiness, name) VALUES({0}, '{1}');",
                        idNeg, nombreProd);
        
                    ConnectionDB.ExecuteNonQuery(sql);
                }
                public static void EliminarProd(int idProd)
                                {
                                    string sql = String.Format("DELETE FROM PRODUCT WHERE idProduct = {0};",idProd);
                                    ConnectionDB.ExecuteNonQuery(sql);
                                }
    }
}