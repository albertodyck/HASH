using System;
using System.Collections.Generic;
using System.Text;

namespace HASH
{
    public class ListaLigada
    {
        private Nodo nodoInicial;

        public ListaLigada(string llave, string dato)
        {
            nodoInicial = new Nodo(llave, dato);
        }

        public void AgregarNodo(string llave, string dato)
        {
            Nodo nodoActual = nodoInicial;

            while (nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
            }

            nodoActual.Enlace = new Nodo(llave, dato);
        }

        public Nodo Buscar(string llave)
        {
            //convertir
            FuncionHash();
            //posicionarse en vertical

            //no coincide la llave
            Nodo nodoBusqueda = nodoInicial;

            while (nodoBusqueda.Enlace != null)
            {
                nodoBusqueda = nodoBusqueda.Enlace;
                if (nodoBusqueda.Llave == llave)
                {
                    return nodoBusqueda;
                }
            }
            return null;
        }

        public int FuncionHash(string texto, int elementosArreglo)
        {
            try
            {
                Encoding ascii = Encoding.ASCII;
                Byte[] encodedBytes = ascii.GetBytes(texto);
                int sumatoria = 0;
                foreach (Byte b in encodedBytes)
                {
                    sumatoria += Convert.ToInt32(b.ToString());
                }
                return sumatoria % elementosArreglo;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error obteniendo hash {ex.Message}");
            }
        }

    }
}
