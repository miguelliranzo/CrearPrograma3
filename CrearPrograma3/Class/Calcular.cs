

namespace CrearPrograma3.Class
{
    public class Calcular
    {
        public void Calcular3() { 
           
            try {
                int num1 = 0;
                int num2 = 0;
                int num3 = 0;
                int num4 = 0;

                Console.WriteLine("Incerre el primer numero:");
                num1= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Incerre el segundo numero:");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Incerre el tercero numero:");
                num3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Incerre el cuarto numero:");
                num4= Convert.ToInt32(Console.ReadLine());

                var suma = num1 + num2 + num3 + num4;
                var promedio = suma / 10;

                Console.WriteLine($"El valor de la suma es {suma}, y el valor del promedio es {promedio}");



            } catch (Exception ex) { Console.WriteLine($"Ocurrio un erro al realizar el calculo {ex}"); }
        
        }
    }
}
