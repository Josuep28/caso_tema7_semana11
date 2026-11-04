using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso_tema7_semana11
{
    internal class Program
    {
        static public void numeros_naturales() 
        {
            Console.Write("Ingresar numero de N: ");
            int N = int.Parse(Console.ReadLine());
            int S = 0;
            for (int c = 1; c <= N; c++) 
            {
                S = S + c;
            }
            Console.WriteLine("La suma es: " + S);
        }
        static public int sumaNN_con_recursividad(int N) 
        {
            if (N == 1) 
            {
                return 1;
            }
                return N + sumaNN_con_recursividad(N - 1);
            
        }
        static public int sumaNP_con_recursividad(int N)
        {
            if (N==2)
            {
                return 2;
            }
            return N + sumaNP_con_recursividad(N - 2);
        }
        static public int sumaNF_con_recursividad(int N)
        {
            if (N == 0 || N==1)
            {
                return 1;
            }
            return N * sumaNF_con_recursividad(N - 1);
        }
        static public long factorial(int N) 
        {
            if (N == 1) 
            {
                return 1;
            }
            return N * factorial(N - 1);
        }
        static public long potencia(int B, int E) 
        {
            if (E == 0) 
            {
                return 1;
            }
            return B * potencia(B, E - 1);
        }
        static public void numeros_pares() 
        {
            Console.Write("Ingresar numero de N: ");
            int N = int.Parse(Console.ReadLine());
            int S = 0;
            for (int c = 2; c <= N; c++) 
            {
                if (c % 2 == 0) 
                {
                    S = S + c;
                }
            }
        }
        static public void Conteo_regresivo(int N) 
        {
            if (N < 0) 
            {
                return;
            }
            Console.WriteLine(N);
            Conteo_regresivo(N - 1);
        }
        static public int suma_arreglos(int[] numeros, int indice) 
        {
            if (indice >= numeros.Length) 
            {
                return 0;
            }
            return numeros[indice] + suma_arreglos(numeros, indice + 1);
        }
        static void Main(string[] args)
        {
            int opc;
            bool valor = true;
            while (valor) 
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine("\tMENU DE OPCIONES:");
                Console.WriteLine("************************************************************");
                Console.WriteLine("[1]Suma de N numeros naturales: ");
                Console.WriteLine("[2]Suma de N numeros naturales con recursividad: ");
                Console.WriteLine("[3]Suma de N numeros pares con recursividad: ");
                Console.WriteLine("[4]Factorial: ");
                Console.WriteLine("[5]Potencia: ");
                Console.WriteLine("[6]Conteo regresivo: ");
                Console.WriteLine("[7]Arreglos: ");
                Console.WriteLine("[8]Salir: ");
                Console.WriteLine("************************************************************");
                opc =int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        numeros_naturales(); break;
                    case 2:
                        Console.Write("Ingresar numero N: ");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es: " + sumaNN_con_recursividad(N));
                        break;
                    case 3:
                        Console.Write("Ingresar numero N: ");
                        int N1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma de pares es: " + sumaNP_con_recursividad(N1*2));
                        break;
                    case 4:
                        Console.Write("Ingresar Num: ");
                        int N2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La factorial es: " + factorial(N2));
                        break;
                    case 5:
                        Console.Write("Ingresar base: ");
                        int B = int.Parse(Console.ReadLine());
                        Console.Write("Ingresar exponente: ");
                        int E=int.Parse(Console.ReadLine());
                        Console.WriteLine(B + "^" + E + "=" + potencia(B, E));
                        break;
                    case 6:
                        int N3;
                        N3= int.Parse(Console.ReadLine());
                        Conteo_regresivo(N3);
                        break;
                    case 7:
                        int[] numeros = { 10, 15, 20, 25, 30 };
                        Console.WriteLine("La suma de los elementos del arreglo es: " + suma_arreglos(numeros, 0));
                        break;
                    case 8:
                        valor = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida: ");
                        break;

                }
                Console.ReadKey();
            }
            //Console.WriteLine("Conteo regreseivo: " + Conteo_regresivo(20));
            //Console.WriteLine("La sigueinte potencia es: "+ potencia(2, 5));
            //Console.WriteLine("Factorial de 5 es: "+ sumaNF_con_recursividad(5));
            Console.ReadKey();
        }
    }
}
