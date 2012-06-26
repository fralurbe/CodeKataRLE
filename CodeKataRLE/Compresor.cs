using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKataRLE
{
    class Compresor
    {
        private string entrada;
        private char[] achar;
        private StringBuilder sb;

        public string salida { get; set; }
        
        public Compresor(string entrada)
        {
            this.entrada = entrada;
            achar = new char[entrada.Length];
            achar = entrada.ToCharArray();
            sb = new StringBuilder();
            Comprime();
        }

        public void Comprime()
        {            
            int i = 0;
            int repeticiones;
            while (i < entrada.Length)
            {
                repeticiones = CuentaRepeticiones(achar[i], i);                
                AñadeSalida(repeticiones, achar[i]);
                i += repeticiones;
                repeticiones = 0;                
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }

        private int Auxiliar(char c, int i)
        {            
            char auxj = achar[i++];
            int cont = 1;
            while (c == auxj && i < entrada.Length)
            {             
                cont++;
                auxj = achar[i++];
            }
            return cont;
        }

        private int CuentaRepeticiones(char c, int i)
        {
            int cont = 0;
            while (c == achar[i])
            {
                cont++;
                i++;
                if (i == entrada.Length||cont == 5) break;
            }
            
            return cont;
        }

        private void AñadeSalida(int rep,char c)
        {           
            sb.Append(rep.ToString());
            sb.Append(c);
        }        
    }
}