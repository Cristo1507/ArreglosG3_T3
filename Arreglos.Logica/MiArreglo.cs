using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public void Llenar()
        {
            Llenar(1, 100);
        }

        //Metodo de llenar con parametros
        public void Llenar(int minimo, int maximo)
        {
            Random random = new Random();
            for(int i = 0; i<N; i++){
                _arreglo[i] = random.Next(minimo, maximo);
            }
            _tope = N;
        }
        //Metodo ordenar (burbuja)
        public void Ordenar()
        {
            Ordenar(true);
        }

        public void Ordenar(bool ascendente)
        {
            for(int i=0; i<_tope; i++)
            { 
              for(int j = i+1; j < _tope; j++)
                {
                    if (ascendente)
                    {


                        if (_arreglo[i] > _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                    else
                    {
                        if (_arreglo[i] < _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                }

            }


        }
        //Metodo cambiar
        public void Cambiar(ref int a, ref int b)
        {
            int auxiliar = a;
            a = b;
            b = auxiliar;

        }

        //Metodo agregar
        public void Agregar(int numero)
        {
            if (Estalleno)
            {
                throw new Exception("El arreglo esta lleno");
            }
            _arreglo[_tope] = numero;
            _tope++;

        }

        //Metodo insertar
        public void Insertar (int numero, int posicion)
        {
            if (Estalleno)
            {
                throw new Exception("El arreglo esta lleno");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }
            for(int i= _tope; i > posicion; i--)
            {
                _arreglo[i] = _arreglo[i - 1];
            }

            _arreglo[posicion] = numero;
            _tope++;
        }

        //Metodo Eliminar
        public void Eliminar(int posicion)
        {
            if (Estavacio)
            {
                throw new Exception("El arreglo esta vacio");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }
            for (int i = posicion; i < _tope-1; i++)
            {
                _arreglo[i] = _arreglo[i + 1];
            }
            _tope--;

        }

        //Metodo ToString
        public override string ToString()
        {
            if(Estavacio)
            {
                Console.WriteLine("El arreglo esta vacio");
            }
            int contador = 0;
            String salida = String.Empty;
            for (int i=0; i<_tope; i++)
            {

                salida += $"{_arreglo[i]}\t";
                contador++;

                if (contador>9)
                {
                    contador = 0;
                   // salida = salida + "\n";
                    salida += "\n";
                }
            }

                return salida;
        }
    }
}
