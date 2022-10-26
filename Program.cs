internal class Program
{
    private static void Main(string[] args)
    {
        // Deklarera en lista

        List<string> resultat = new List<string>();

        // Deklarera en loop utan värde
        string? menyLoop = "";


        do // ----> Loopar menyn
        {


            // Meny och Välkommen

            Console.WriteLine("Välkommen till Miniräknaren!\n");
            Console.WriteLine("Välj din operatör");
            Console.WriteLine("-----------------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Se senaste resultat");
            Console.WriteLine("6. Avsluta programmet...\n");
            Console.WriteLine("Välj ditt alternativ: ");
            string? menyVal = Console.ReadLine();
            
           
            // Menyvalen (1-6)

            switch (menyVal)
            {
                // Menyval 1, räkna med +
                case "1":
                    Console.Clear();
                    Console.WriteLine("Du har valt Addition");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Välj första talet: ");
                    double tal1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Välj andra talet: ");
                    double tal2 = double.Parse(Console.ReadLine());                      // Konverta tal2 till en double
                    double talet = tal1 + tal2;                                         // Deklarera "talet"
                    string? taletText = $"{tal1} + {tal2} = {talet.ToString()}";        // konvertera talet till en text-sträng
                    Console.Clear();
                    Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");           // Beräkningen vad användaren matar in
                    resultat.Add(taletText);                                        // Lägg till resultatet till listan 

                    // ifsats för att fortsätta/avsluta program
                    Console.Write("\nVill du fortsätta?(y/n):");
                    string? svar = Console.ReadLine();
                    Console.Clear();


                    if (svar == "y")
                    {
                        break;
                    }
                    else if (svar == "n")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Prova igen!\n");
                    }
                    break;


                // Menyval 2, räkna med -
                case "2":
                    Console.Clear();
                    Console.WriteLine("Du har valt Subtraktion");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Välj första talet: ");
                    double tal3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Välj andra talet: ");
                    double tal4 = double.Parse(Console.ReadLine());
                    double talet1 = tal3 - tal4;
                    string? taletText1 = $"{tal3} - {tal3} = {talet1.ToString()}";
                    resultat.Add(taletText1);
                    Console.Clear();
                    Console.WriteLine($"{tal3} - {tal4} = {tal3 - tal4}");
                    Console.Write("\nVill du fortsätta?(y/n):");
                    string? svar1 = Console.ReadLine();
                    Console.Clear();
                    if (svar1 == "y")
                    {
                        break;
                    }
                    else if (svar1 == "n")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Prova igen!\n");
                    }
                    break;

                // Menyval 3, Räkna med *
                case "3":
                    Console.Clear();
                    Console.WriteLine("Du har valt Multiplikation");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Välj första talet: ");
                    double tal5 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Välj andra talet: ");
                    double tal6 = double.Parse(Console.ReadLine());
                    double talet2 = tal5 * tal6;
                    string? taletText2 = $"{tal5} * {tal6} = {talet2.ToString()}";
                    resultat.Add(taletText2);
                    Console.Clear();
                    Console.WriteLine($"{tal5} * {tal6} = {tal5 * tal6}");
                    Console.Write("\nVill du fortsätta?(y/n):");
                    string? svar2 = Console.ReadLine();
                    Console.Clear();
                    if (svar2 == "y")
                    {
                        break;
                    }
                    else if (svar2 == "n")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Prova igen\n");
                    }
                    break;

                // Menyval 4, Räkna med /
                case "4":

                    Console.Clear();
                    Console.WriteLine("Du har valt Division");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Välj första talet: ");
                    double tal7 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Välj andra talet: ");
                    double tal8 = double.Parse(Console.ReadLine());
                    double talet3 = tal7 / tal8;
                    string? taletText3 = $"{tal7} / {tal8} = {talet3.ToString()}";
                    resultat.Add(taletText3);
                    Console.Clear();

                    // Checka så inmatningen inte är 0/0 vid division.
                    if (tal8 == 0)
                    {
                        Console.WriteLine("oj, något blev fel");

                    }
                    else
                    {
                        Console.WriteLine($"{tal7} / {tal8} = {tal7 / tal8}");

                    }
                    Console.Write("\nVill du fortsätta?(y/n):");
                    string? svar4 = Console.ReadLine();
                    Console.Clear();
                    if (svar4 == "y")
                    {
                        break;
                    }
                    else if (svar4 == "n")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Prova igen!\n");
                    }
                    break;

                // Menyval 5, Se senaste resultatet
                case "5":
                    Console.Clear();
                    Console.WriteLine("Senaste resulat: ");
                    Console.WriteLine("--------------------");

                    // Loop för att skriva ut tidigare beräkningar från listan
                    foreach (string tal in resultat)
                    {
                        Console.WriteLine(tal);
                    }
                    Console.Write("\nVill du fortsätta?(y/n):");
                    string? svar5 = Console.ReadLine();
                    Console.Clear();
                    if (svar5 == "y")
                    {
                        break;
                    }
                    else if (svar5 == "n")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Prova igen!\n");
                    }
                    break;

                // Menyval 6, Avsluta progammet
                case "6":
                    Console.Clear();
                    Console.WriteLine("Du har valt att avsluta programmet...");
                    Environment.Exit(0);
                    break;

                    // Förbättringar: Implementera en try/catch för en säkrare felhantering av programmet. 
                    // Kunde även lagt till en loop i varje case för att hålla sig kvar i case, istället för att komma tillbak till menyn.
                    // En mer sammansatt meny utan att göra 10st Console.Writeline, för en snyggare kod.
                    // Försökt göra en metod för att anropa Y/N istället för att ha en if/else i varje case och korta ner koden.



            }

        } while (true);   // do-while loop
    }
}