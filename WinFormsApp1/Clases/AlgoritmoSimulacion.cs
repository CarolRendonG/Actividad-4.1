using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    public class AlgoritmoSimulacion
    {
        public AlgoritmoSimulacion() { }    
        public List<int> GenerarValores(int mini, int maxi, int num)
        {
            List<int> listaSalida = new List<int>();
            Random random = new Random();
            int i = 0;

            while (listaSalida.Count < num)
            {
                if (i % 2 == 0)
                {
                    int valorCalculado = 5 * (i + 1);
                    if (valorCalculado >= mini && valorCalculado <= maxi)
                    {
                        listaSalida.Add(valorCalculado);
                    }
                }
                else
                {
                    int valorAleatorio = random.Next(mini, maxi + 1);
                    listaSalida.Add(valorAleatorio);
                }
                i++;
            }

            return listaSalida; // Retorna la lista de valores generados
        }

    }

}
