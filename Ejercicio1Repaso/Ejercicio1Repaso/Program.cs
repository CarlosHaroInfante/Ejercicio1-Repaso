namespace Ejercicio1Repaso
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Cuantos minutos has trabajado este mes: ");
            int min = Convert.ToInt32(Console.ReadLine());




            int dias = min / (8 * 60);
            int horas = min % (8 * 60) / 60;
            int minutos = min % 60;

            string trabajo = "Has trabajado ";

            if (dias > 0)
            {
                Console.WriteLine(trabajo + dias + " dias");

            }
            else{
                Console.WriteLine(trabajo + dias + " dia");
            }

            if( horas > 0)
            {
                Console.WriteLine(trabajo + horas + " horas");
            }
            else
            {
                Console.WriteLine(trabajo + horas + " hora");
            }

            if (minutos > 0)
            {
                Console.WriteLine(trabajo + minutos + " minutos");
            }
            else
            {
                Console.WriteLine(trabajo + minutos + " minuto");
            }


        }
    }


}
