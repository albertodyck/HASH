namespace HASH
{
    public class Nodo
    {
        private string dato;

        private string llave;

        private Nodo enlace;

        public string Dato { get => dato; set => dato = value; }
        public string Llave { get => llave; set => llave = value; }
        public Nodo Enlace { get => enlace; set => enlace = value; }

        public Nodo(string llave, string dato, Nodo enlace = null)
        {
            this.dato = dato;
            this.llave = llave;
            this.enlace = enlace;
        }
    }
}
