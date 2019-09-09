using System;

namespace ABMLista.Clases
{
    public class Lista
    {
        #region Propiedades
        private string[] lista = new string[1];
        private int ProximaPosicion = 0;
        #endregion

        #region Constructor
        #endregion
        #region Metodos
        public bool Agregar(string aTexto)
        {
            bool Resp = false;
            try
            {
                if (ProximaPosicion == lista.Length)
                {
                    this.AgregaRegistro(1);
                }

                lista[ProximaPosicion] = aTexto;
                ProximaPosicion++;
                Resp = true;
            }
            catch (Exception err)
            {
                throw err;
            }

            return Resp;
        }

        private void AgregaRegistro(int incremento)
        {
            string[] Temp = new string[lista.Length + incremento];
            lista = this.Copiar(lista, Temp);

        }
        private string[] Copiar(string[] Origen, string[] Destino)
        {
            for (int i = 0; i < ProximaPosicion; i++)
            {
                Destino[i] = Origen[i];
            }
            return Destino;
        }
        public string MostrarLista()
        {
            string Respuesta = "";
            if (ProximaPosicion > 0)
            {
                Respuesta = lista[0];
                for (int i = 1; i < ProximaPosicion; i++)
                {
                    Respuesta = Respuesta + "\r\n" + lista[i];
                }
            }
            return Respuesta;
        }
        public int BuscarPosicion(string Que)
        {
            int Resp = -1;
            for (int i = 0; i < this.lista.Length; i++)
            {//0 igual , -1 menor , 1 mayor para comparar
                //if (lista[i] == Que)
                if (lista[i].CompareTo(Que) == 0)
                {
                    Resp = i;
                    break;
                }


            }
            return Resp;
        }
        public string BorrarPosicion(string Que)
        {
            string Resp = "";
            int Pos = this.BuscarPosicion(Que);
            if (Pos == -1)
            {
                Resp = Que + "no ha sido encontrado";
            }
            else
            {
                for (int i = Pos; i < ProximaPosicion - 1; i++)
                {
                    this.lista[i] = this.lista[i + 1];
                }
                this.lista[ProximaPosicion - 1] = null;
                ProximaPosicion = ProximaPosicion - 1;
                AgregaRegistro(-1);
            }

            return Resp;
        }
        public string Ordenar()
        {
            string salida = "";
            string[] copia = new string[lista.Length];
            Copiar(lista, copia);
            if (copia.Length > 1)
            {
                for (int j = 0; j < copia.Length; j++)
                {
                    for (int i = 0; i < copia.Length; i++)
                    {
                        try
                        {
                            if (copia[i].CompareTo(copia[i + 1]) == 1)
                            {
                                //El que sigue es mayor
                                string Temp = copia[i];
                                copia[i] = copia[i + 1];
                                copia[i + 1] = Temp;

                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("revision completa);
                        }
                    }

                }
            }
            for (int i = 0; i < copia.Length; i++)
            {
                salida = salida + copia[i] + "\r\n";
            }

            return salida;
        }
        #endregion
    }
        
}
