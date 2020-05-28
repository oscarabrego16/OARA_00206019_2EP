using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode.Modelo
{
    public class PedidosDAO
    {
        public static List<Pedidos> getEstadisticas()
        {
            string sql = "SELECT b.name AS \"Negocio\", sum(cp.cant) AS \"Total pedidos\" FROM BUSINESS b, "+
              "(SELECT p.idBusiness, p.name, count(ap.idProduct) AS \"cant\" " +
                  "FROM PRODUCT p, APPORDER ap WHERE p.idProduct = ap.idProduct " +
                  "GROUP BY p.idProduct  ORDER BY p.name ASC) AS cp " +
                  "WHERE b.idBusiness = cp.idBusiness GROUP BY b.idBusiness;";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<Pedidos> lista = new List<Pedidos>();
            foreach (DataRow fila in dt.Rows)
            {
                Pedidos f = new Pedidos();
                f.cantidad = Convert.ToInt32(fila[1].ToString());
                f.negocio = fila[0].ToString();

                lista.Add(f);
            }
            return lista;
        }
    }
}