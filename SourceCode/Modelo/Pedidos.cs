namespace SourceCode.Modelo
{
    public class Pedidos
    {
        public string negocio { get; set; }
        public int cantidad { get; set; }

        public Pedidos()
        {
            negocio = "";
            cantidad = 0;
        }
    }
}