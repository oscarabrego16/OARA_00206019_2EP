using System;
using System.Windows.Forms;

namespace SourceCode.Modelo
{
    public class AppOrderDAO
    {
         public static void CrearNuevo( int idProd, int idAddress)
                {
                    string sql = String.Format(
                        "INSERT INTO APPORDER(createDate, idProduct, idAddress)VALUES('{0}', {1}, {2});",
                        (DateTime.Now).ToShortDateString(),idProd,idAddress);
        
                    ConnectionDB.ExecuteNonQuery(sql);
                }
         public static void EliminarOrder(int idOrder)
         {
             string sql = String.Format("DELETE FROM apporder WHERE idorder = '{0}';",idOrder);
             ConnectionDB.ExecuteNonQuery(sql);
         }
    }
}