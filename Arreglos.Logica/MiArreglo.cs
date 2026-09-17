using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //Campos o atributos 
         
        private int _tope;
        private int[] _arreglo;
          
        //Constructor
        public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[n];
            _tope = 0; 
        }
        //Propiedades
        public int N { get; }

        public bool Estalleno => _tope == N;
        public bool Estavacio => _tope == 0;

        //Metodos
        public void Llenar(int minimo, int maximo)
        {
            Random random = new Random();
            for(int i = 0; i<N; i++){
                _arreglo[i] = random.Next(minimo, maximo);
            }
            _tope = N;
        }
        public override string ToString()
        {
            if(Estavacio)
            {
                Console.WriteLine("El arreglo esta vacio");
            }
            String salida = String.Empty;
            for (int i=0; i<N; i++)
            {
                salida += $"{_arreglo[i]}\t";
            }

                return salida;
        }
    }
}
