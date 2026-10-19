using System;

class Program
{
    static void Main()
    {
        string[] nombres = new string[3];
        double[,] notas = new double[3, 5]; 
        int[] cantNotas = new int[3];       
        int total = 0;
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("1. Ingresar Calificaciones\n2. Ver Promedio\n3. Salir\nOpción:");
            
            if (int.TryParse(Console.ReadLine(), out int op))
            {
                switch (op)
                {
                    case 1: 
                        if (total >= 3) { Console.WriteLine("Límite de 3 alcanzado."); break; }
                        
                        Console.Write("Nombre: "); 
                        nombres[total] = Console.ReadLine()?.Trim() ?? "";

                        Console.Write("Cantidad de notas: ");
                        int.TryParse(Console.ReadLine(), out cantNotas[total]);

                        for (int i = 0; i < cantNotas[total]; i++)
                        {
                            Console.Write($"Nota {i + 1}: ");
                            double.TryParse(Console.ReadLine(), out notas[total, i]); 
                        }
                        total++;
                        Console.WriteLine("¡Guardado exitosamente!");
                        break;

                    case 2: 
                        if (total == 0) { Console.WriteLine("No hay estudiantes registrados."); break; }
                        
                        Console.Write("Nombre a buscar: "); 
                        string busq = Console.ReadLine()?.Trim() ?? "";
                        int idx = -1;

                        for (int i = 0; i < total; i++)
                            if (nombres[i] == busq) idx = i;

                        if (idx != -1)
                        {
                            double suma = 0;
                            for (int i = 0; i < cantNotas[idx]; i++) suma += notas[idx, i];
                            Console.WriteLine($"Estudiante: {nombres[idx]} | Promedio: {suma / cantNotas[idx]:F2}");
                        }
                        else Console.WriteLine("Estudiante no encontrado.");
                        break;

                    case 3: 
                        salir = true;
                        break;

                    default: 
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else 
            {
                Console.WriteLine("Entrada inválida.");
            }

            if (!salir)
            {
                Console.WriteLine("\nPresiona Enter para continuar...");
                Console.ReadLine();
            }
        }
    }
}