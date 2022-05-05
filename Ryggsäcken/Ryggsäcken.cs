using System;

namespace Ryggsäcken
{

    class Program
    {

        static void Main(string[] args)
        {
             //Deklarerar en string variabel med namnet läggTillFöremål, som vid programmets start tilldelas värdet ingenting,
             //detta för att om användaren väljer menyval2 vid programmets start så visas det att ryggsäcken är tom från början,
             //när användaren senare väljer att stoppa i något föremål i ryggsäcken så tilldelas det värdet.
            string läggTillFöremål = "ingenting";

            //Deklarerar en bool variabel med namnet visaMeny, den är sann så länge som användaren inte avslutar programmet,
            //genom att ange menyval 4 som avslutar programmet. 
            bool visaMeny = true;

            //Använder en while loop som loopar menyn till dess att variablen visaMeny blir falsk,
            //dvs om användaren väljer att avsluta.
            while (visaMeny == true)                
            {
                
                //Skriver ut meny strukturen till konsolfönstret.
                Console.WriteLine("******* Välkommen till ryggsäcken *******");
                Console.WriteLine("Välj alternativ i menyn med hjälp av siffrorna.");
                Console.WriteLine("[1] Lägg till ett föremål i ryggsäcken.");
                Console.WriteLine("[2] Visa innehållet i ryggsäcken.");
                Console.WriteLine("[3] Töm ryggsäcken på innehåll.");
                Console.WriteLine("[4] Avsluta programmet.");
                Console.Write("Val: ");
                
                
                //Deklarerar en variabel med namnet användarensVal som tilldelas menyval från användarens input.
                string användarensVal = Console.ReadLine();

                //Använder mig av en switch för att hantera de olika menyvalen som användaren kan göra, jag tycker att det,
                //blir tydligare med switch än med if sats. 
                switch (användarensVal)
                {
                    //Menyval 1: Användaren väljer att lägga till något i sin ryggsäck.
                    case "1":

                        //Jag har valt att använda en tom Console.ReadLine för att få lite luft mellan texten. 
                        Console.WriteLine();
                        Console.Write("Vilket föremål vill du lägga i ryggsäcken? : ");
                        //Tilldelar användarens föremål till variabeln läggTillFöremål.
                        läggTillFöremål = Console.ReadLine();
                        //Jag valde att lägga till en Console.Clear för att rensa konsolfänstret efter att,
                        //användaren har lagt till sitt föremål i ryggsäcken. 
                        Console.Clear();
                            break;

                    //Menyval 2: Användaren väljer att visa innehållet i sin ryggsäck. 
                    case "2":

                        //Jag har valt att använda en tom Console.ReadLine för att få lite luft mellan texten.
                        Console.WriteLine();
                        //Skriver ut ryggsäckens innehåll till konsolfönstret.
                        Console.WriteLine("Ryggsäcken innehåller: " + läggTillFöremål);
                        //Jag har valt att använda en tom Console.ReadLine för att få lite luft mellan texten.
                        Console.WriteLine();
                            break;
                    //Menyval 3: Användaren väljer att tömma sin ryggsäck på innehåll.
                    case "3":

                        //Jag har valt att använda en tom Console.ReadLine för att få lite luft mellan texten.
                        Console.WriteLine();
                        Console.WriteLine("Ryggsäcken töms nu på innehåll! ");
                        //Jag har valt att använda en tom Console.ReadLine för att få lite luft mellan texten.
                        Console.WriteLine();
                        //Variabeln läggTillFöremål tilldelas ett tomt värde efter att användaren har valt att tömma ryggsäcken.
                        läggTillFöremål = "";
                            break;
                    //Menyval 4: Användaren väljer att avsluta programmet
                    case "4":

                        //Jag har valt att använda en tom Console.ReadLine för att få lite luft mellan texten.
                        Console.WriteLine();
                        Console.WriteLine("Programmet avslutas nu, hej då!");
                        //bool variabeln visaMeny tilldelas värdet false och bryter loopen,
                        //när användaren väljer att avsluta programmet.
                        visaMeny = false;
                            break;
                    //Använder default för felhantering av menyval, dvs om användaren ej anger ett korrekt menyval. 
                    default:

                        //Jag har valt att använda en tom Console.ReadLine för att få lite luft mellan texten.
                        Console.WriteLine();
                        Console.WriteLine("Felaktigt val: ");
                        Console.WriteLine("Välj alternativ i menyn med hjälp av siffrorna: ");
                        //Jag har valt att använda en tom Console.ReadLine för att få lite luft mellan texten.
                        Console.WriteLine();
                            break;
                }
                              
            }            
        }
    }

}