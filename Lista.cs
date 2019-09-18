using System;

namespace ABMLista.Clases
{
    public class Lista
    {
        #region Propiedades
        private string[] lista = new string[1];
        private string[] listanota = new string[1];
        private int ProximaPosicion = 0;
        #endregion

        #region Constructor
        #endregion
        #region Metodos
        public bool Agregar(string aTexto,string anota)
        {
            bool Resp = false;
            try
            {
                if (ProximaPosicion == lista.Length)
                {
                    this.AgregaRegistro(1);
                    this.AgregaRegistronota(1);
                }

                lista[ProximaPosicion] = aTexto;
                listanota[ProximaPosicion] = anota;
                ProximaPosicion++;
                Resp = true;
            }
            catch (Exception err)
            {
                throw err;
            }

            return Resp;
        }

        public void AgregaRegistro(int incremento)
        {
            string[] Temp = new string[lista.Length + incremento];
            lista = this.Copiar(lista, Temp);
        }
        public void AgregaRegistronota(int incremento)
        {

            string[] Temp2 = new string[listanota.Length + incremento];
            listanota = this.Copiarnota(listanota, Temp2);

        }
        private string[] Copiar(string[] Origen, string[] Destino)
        {
            for (int i = 0; i < ProximaPosicion; i++)
            {
                Destino[i] = Origen[i];
            }
            return Destino;
        }
        private string[] Copiarnota(string[] Origen, string[] Destino)
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
            string resp1 = "";
            if (ProximaPosicion > 0)
            {
                Respuesta = lista[0]+listanota[0];
                resp1 = listanota[0];
                for (int i = 1; i < ProximaPosicion; i++)
                {
                    Respuesta = Respuesta +" " + lista[i]+ " "+ listanota[i]+ "\r\n";
                    
                }
            }
            return Respuesta;
            return resp1;
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
                if (listanota[i].CompareTo(Que) == 0)
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
                    this.listanota[i] = this.listanota[i + 1];
                }
                this.lista[ProximaPosicion - 1] = null;
                this.listanota[ProximaPosicion - 1] = null;
                ProximaPosicion = ProximaPosicion - 1;
                AgregaRegistro(-1);
                AgregaRegistronota(-1);
            }

            return Resp;
        }
        public string Ordenar()
        {
            string finalizado = "";
            string[] copia = new string[lista.Length];
            string[] copia2 = new string[listanota.Length];
            Copiar(lista, copia);
            Copiarnota(listanota, copia2);
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
                                string Temp2 = copia2[i];
                                copia2[i] = copia[i + 1];
                                copia2[i + 1] = Temp2;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("revision completa");
                        }
                    }

                }
            }
            for (int i = 0; i < copia.Length; i++)
            {
                finalizado = finalizado + copia[i] + "  "+ copia2[i]+ "\r\n";
            }
            //for (int i = 0; i < copia2.Length; i++)
            //{
            //    finalizado = finalizado + copia2[i];
            //}
            return finalizado;
        }
        #endregion
    }
        
}
