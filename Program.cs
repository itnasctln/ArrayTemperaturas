//vamos a crear un programa para porder cargar un array de 31 dias, con las temperaturas-

using System;
namespace revemosarray
{
    class Program
    {
        static void Main(string[] args)
        {
            //vamos a crear 3 arrays de 31 espacios, para guardar la informacion
            //de las temperaturas de un mes, registradas a la mañana, tarde y noche.

            double[] temperaturaMañana = new double[31];
            double[] temperaturaTarde = new double[31];
            double[] temperaturaNoche = new double[31];


            //vamos a hacer una carga en un dia especifico, primero consultamos un
            //a que vector le agregaremos la informacion (mañana,tarde,noche),
            //luego consultamos en que dia (indice), y por ultimo la temperatura.

            Console.WriteLine("Iniciamos el programa para cargar temperaturas");

            //variable para el switch
            int selectorSwitch = 0;
            int diaSeleccionado = 0;
            double temperaturaIngresada = 0.0;

            Console.WriteLine("para cargar temperaturas de la mañana, ingrese 1");
            Console.WriteLine("para cargar temperaturas de la tarde, ingrese 2");
            Console.WriteLine("para cargar temperaturas de la noche, ingrese 3");

            selectorSwitch = int.Parse(Console.ReadLine());

            
            switch (selectorSwitch)
            {
                case 1:
                   // Código si variable == TEMPERATURA MAÑANA
                    Console.WriteLine("que día quiere cargar?(1-31)");
                    diaSeleccionado = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la temperatura");
                    temperaturaIngresada = double.Parse(Console.ReadLine());
                    temperaturaMañana[diaSeleccionado - 1] = temperaturaIngresada;
                    Console.WriteLine("ustede cargo la temperatura " + temperaturaMañana[diaSeleccionado - 1] + " en el dia " + diaSeleccionado);
                    break;

                case 2:
                    // Código si variable == valor2 TEMPERATURA TARDE
                    Console.WriteLine("que día quiere cargar?(1-31)");
                    diaSeleccionado = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la temperatura");
                    temperaturaIngresada = double.Parse(Console.ReadLine());
                    temperaturaTarde[diaSeleccionado - 1] = temperaturaIngresada;
                    Console.WriteLine("ustede cargo la temperatura " + temperaturaTarde[diaSeleccionado - 1] + " en el dia " + diaSeleccionado);
                    break;

                case 3:
                    // Código si variable == valor3 TEMPERATURA NOCHE
                    Console.WriteLine("que día quiere cargar?(1-31)");
                    diaSeleccionado = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la temperatura");
                    temperaturaIngresada = double.Parse(Console.ReadLine());
                    temperaturaNoche[diaSeleccionado - 1] = temperaturaIngresada;
                    Console.WriteLine("ustede cargo la temperatura " + temperaturaNoche[diaSeleccionado - 1] + " en el dia " + diaSeleccionado);
                    break;

                default:
                    Console.WriteLine("no es una opcion valida, saliendo del programa");
                    break;
            }

        }

    }
}