using System;

namespace revemosarray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays para las temperaturas del mes
            double[] temperaturaMañana = new double[31];
            double[] temperaturaTarde = new double[31];
            double[] temperaturaNoche = new double[31];

            string opcion = "";
            //con el while permitimos que el usuario tenga la opcion de volver al menu siempre y finalizarlo con "x"
            while (opcion != "x")
            {
                Console.WriteLine("=== MENU PRINCIPAL ===");
                Console.WriteLine("a) Leer informacion");
                Console.WriteLine("b) Cargar informacion");
                Console.WriteLine("x) Salir");
                Console.Write("Elija una opcion: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    //selector leer informacion o cargar mes/dia especifico
                    case "a":
                        Console.WriteLine("Selecciono leer informacion");
                        Console.WriteLine("Ingrese M (mañana), T (tarde) o N (noche): ");
                        string turno = Console.ReadLine();

                        Console.WriteLine("¿Que dia quiere leer? (1-31): ");
                        int diaLeer = int.Parse(Console.ReadLine());

                        int indiceLeer = diaLeer - 1; // corrección de índice
                        
                        //selector de que turno queremos escribit
                        switch (turno)
                        {
                            case "M":
                                Console.WriteLine("La temperatura de la mañana del dia " + diaLeer + " es " + temperaturaMañana[indiceLeer]);
                                break;
                            case "T":
                                Console.WriteLine("La temperatura de la tarde del dia " + diaLeer + " es " + temperaturaTarde[indiceLeer]);
                                break;
                            case "N":
                                Console.WriteLine("La temperatura de la noche del dia " + diaLeer + " es " + temperaturaNoche[indiceLeer]);
                                break;
                            default:
                                Console.WriteLine("No valido");
                                break;
                        }
                        break;

                    
                    case "b":
                        Console.WriteLine("¿Desea cargar un mes completo o un dia especifico?");
                        Console.WriteLine("A) Mes completo");
                        Console.WriteLine("B) Dia especifico");
                        string subopcion = Console.ReadLine();

                        //selector todas las temperaturas o dia especifico.
                        switch (subopcion)
                        {
                            case "A":
                                Console.WriteLine("Cargando temperaturas para todo el mes...");
                                for (int i = 0; i < 31; i++)
                                {
                                    Console.Write("Dia " + (i + 1) + " - Mañana: ");
                                    temperaturaMañana[i] = double.Parse(Console.ReadLine());

                                    Console.Write("Dia " + (i + 1) + " - Tarde: ");
                                    temperaturaTarde[i] = double.Parse(Console.ReadLine());

                                    Console.Write("Dia " + (i + 1) + " - Noche: ");
                                    temperaturaNoche[i] = double.Parse(Console.ReadLine());
                                }
                                Console.WriteLine("Carga completa finalizada.");
                                break;

                            case "B":
                                Console.WriteLine("Ingrese el dia que desea cargar (1-31): ");
                                int diaCargar = int.Parse(Console.ReadLine());
                                int indiceCargar = diaCargar - 1;

                                Console.WriteLine("1) Mañana  2) Tarde  3) Noche");
                                int turnoCarga = int.Parse(Console.ReadLine());

                                Console.Write("Ingrese la temperatura: ");
                                double temp = double.Parse(Console.ReadLine());

                                switch (turnoCarga)
                                {
                                    case 1:
                                        temperaturaMañana[indiceCargar] = temp;
                                        break;
                                    case 2:
                                        temperaturaTarde[indiceCargar] = temp;
                                        break;
                                    case 3:
                                        temperaturaNoche[indiceCargar] = temp;
                                        break;
                                }
                                Console.WriteLine("Temperatura cargada correctamente.");
                                break;

                            default:
                                Console.WriteLine("Opcion invalida.");
                                break;
                        }
                        break;

                    case "x":
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }

                Console.WriteLine(); // linea en blanco para separar
            }
        }
    }
}