namespace UpiTarea2Progra2
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- ejercicio 1");
                Console.WriteLine("2- ejercicio 2");
                Console.WriteLine("3- ejercicio 3");
                Console.WriteLine("4- salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Ejercicio1();
                        break;
                    case 2: Ejercicio2();
                        break;
                    case 3: Ejercicio3();
                            break;
                    default:
                        break;
                }
            } while (opcion != 4); //mientras que la opcion sea diferente de 4
        }

        public static void Ejercicio1() //un metod 1
        {
            float precio = 0f;
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("Digite de precio de la camisa");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad");
            precio = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"Total a pagar: {cantidad * precio}");
            }

            if (cantidad >1 && cantidad <6)
            {
                total = (cantidad * precio) * 0.15f; //Calcular el 15 precio
                total = (cantidad * precio) - total;
                Console.WriteLine($"total a pagar: {total} con descuento del 15%");
            }

            if (cantidad >=6)
            {
                total = (cantidad * precio) * 0.2f;
                total = (cantidad * precio) - total;
                Console.WriteLine($"total a pagar: {total} con descuento de 20%");
            }

        }

        public static void Ejercicio2() //un metod 1
        {

                Console.WriteLine("Ingrese el número de estudiantes:");
                int numEstudiantes = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numEstudiantes; i++)
                {
                    Console.WriteLine($"\nEstudiante {i}:");
                    Console.Write("Carnet: ");
                    string carnet = Console.ReadLine();
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    double[] quices = new double[3];
                    double[] tareas = new double[3];
                    double[] examenes = new double[3];

                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Quiz {j + 1}: ");
                        quices[j] = double.Parse(Console.ReadLine());
                        Console.Write($"Tarea {j + 1}: ");
                        tareas[j] = double.Parse(Console.ReadLine());
                        Console.Write($"Examen {j + 1}: ");
                        examenes[j] = double.Parse(Console.ReadLine());
                    }

                    double porcentajeQuices = (quices[0] + quices[1] + quices[2]) / 3 * 0.25;
                    double porcentajeTareas = (tareas[0] + tareas[1] + tareas[2]) / 3 * 0.30;
                    double porcentajeExamenes = (examenes[0] + examenes[1] + examenes[2]) / 3 * 0.45;

                    double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;
                    string condicion = (promedioFinal >= 70) ? "Aprobado" : (promedioFinal >= 50) ? "Aplazado" : "Reprobado";

                    Console.WriteLine("\nReporte del estudiante:");
                    Console.WriteLine($"Carnet: {carnet}");
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"Porcentaje de Quices: {porcentajeQuices:P}");
                    Console.WriteLine($"Porcentaje de Tareas: {porcentajeTareas:P}");
                    Console.WriteLine($"Porcentaje de Examenes: {porcentajeExamenes:P}");
                    Console.WriteLine($"Promedio Final: {promedioFinal:F2}");
                    Console.WriteLine($"Condición del Estudiante: {condicion}\n");
                }
            
        }

        static void Ejercicio3()
        {
            Console.WriteLine("Ingrese la cantidad de artículos comprados: ");
            int cantidadArticulos = Convert.ToInt32(Console.ReadLine());

            double precioPorArticulo;

            if (cantidadArticulos <= 10)
            {
                precioPorArticulo = 20.0;
            }
            else
            {
                precioPorArticulo = 15.0;
            }

            double total = cantidadArticulos * precioPorArticulo;

            Console.WriteLine("Precio por artículo: $" + precioPorArticulo);
            Console.WriteLine("Total a pagar: $" + total);

            Console.ReadKey();
        }
    }
}