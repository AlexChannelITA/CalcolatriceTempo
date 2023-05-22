using System;

namespace LibreriaTempo
{
    public class Tempo
    {
        public static void Calcolatrice()
        {
            try
            {
                string de2 = "Y";
                do
                {
                    string dev;
                    do
                    {
                        Console.WriteLine("Salve dimmi intanto che orario vorresti sapere: \n-Secondi \n-Minuti \n-Ore \n-Giorni \n-Settimane \n-Mesi \n-Anni");

                        dev = Console.ReadLine();
                    } while (dev == "");


                    Console.WriteLine("Per convenzione si utilizera l'orario di partenza 'Ore? \nDimmi quante ore:");

                    double tempo = int.Parse(Console.ReadLine());

                    switch (dev)
                    {
                        case "Secondi":
                            tempo = tempo * 3600;
                            Console.WriteLine($"Il tuo tempo trasformato in {dev} è {tempo}");
                            break;
                        case "Minuti":
                            tempo = tempo * 60;
                            Console.WriteLine($"Il tuo tempo trasformato in {dev} è {tempo}");
                            break;
                        case "Ore":
                            Console.WriteLine($"Il tuo tempo trasformato in {dev} è {tempo}");
                            break;
                        case "Giorni":
                            tempo = tempo / 24;
                            Console.WriteLine($"Il tuo tempo trasformato in {dev} è {tempo}");
                            break;
                        case "Settimane":
                            tempo = tempo / 168;
                            Console.WriteLine($"Il tuo tempo trasformato in {dev} è {tempo}");
                            break;
                        case "Mesi":
                            tempo = tempo / 730;
                            Console.WriteLine($"Il tuo tempo trasformato in {dev} è {tempo}");
                            break;
                        case "Anni":
                            tempo = tempo / 8760;
                            Console.WriteLine($"Il tuo tempo trasformato in {dev} è {tempo}");
                            break;
                    }

                    Console.WriteLine("Vuoi continuare? \n-SI: Y \n-NO:N");
                    de2 = Console.ReadLine();
                } while (de2 == "Y" || de2 == "y");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
