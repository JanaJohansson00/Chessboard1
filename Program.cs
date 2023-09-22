namespace Chessboard1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; // Används om rutorna i koden ej funkar.

            bool run = true; //Ser till att körningen är sann.

            while (run) // Sålänge detta är sant, gör det nedanför.
            {
                try // Försök köra koden
                {
                    int antal;
                    Console.WriteLine("Mata in en siffra"); // Ber användaren mata in en siffra.
                    string inmatat = Console.ReadLine(); // Hämtar värdet som användaren anger.
                    antal = Int32.Parse(inmatat); // Konverterar text till heltal.

                    string vit = "◼︎";
                    string svart = "◻︎"; // Dessa sparas i en variabel så att det kan skrivas ut i koden.

                    for (int rad = 0; rad < antal; rad++) // En for-loop för att skriva ut rader samt kolumner.
                    {
                        for (int kolumn = 0; kolumn < antal; kolumn++)
                        {
                            if (kolumn % 2 == 0 ^ rad % 2 == 0) //Om ena påståendet och endast ena påståendet är sant.
                            {
                                Console.Write(vit); // Write för att stanna på samma rad.
                            }
                            else
                            {
                                Console.Write(svart);
                            }

                        }
                        Console.WriteLine();
                    }
                    run = false; // Om allt har gått rätt, avsluta programmet.
                } catch (FormatException) // Om något går fel, kör detta.
                {
                    Console.WriteLine("Du kan bara ange siffror");
                }

               
            }

           
        }
    }

}