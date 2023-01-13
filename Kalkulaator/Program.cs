namespace Kalkulaator;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kalkulaator");
        Console.WriteLine("Palun sisesta esimene arv");
        float firstNr = int.Parse(Console.ReadLine());

        Console.WriteLine("Palun sisesta tehe: ");
        string operation = Console.ReadLine();

        Console.WriteLine("Palun sisesta teine arv");
        float secondNr = int.Parse(Console.ReadLine());



        try
        {
            switch (operation)
            {
                case "+":
                    float resultAdd = firstNr + secondNr;
                    Console.WriteLine("Kahe numbri liitmisel on vastus: " + resultAdd);
                    break;

                case "-":
                    float resultsub = firstNr - secondNr;
                    Console.WriteLine("Kahe numbri lahutamisel on vastus: " + resultsub);
                    break;

                case "*":
                    float resultmult = firstNr * secondNr;
                    Console.WriteLine("Kahe numbri korrutamisel on vastus: " + resultmult);
                    break;

                case "/":
                    float resultdiv = firstNr / secondNr;
                    Console.WriteLine("Kahe numbri jagamisel on vastus: " + resultdiv);
                    break;
                            
                default:
                    break;

            }
        }
        catch (FormatException)//numbrilise v''rtuse kontroll
        {
            Console.WriteLine("Vale numbri formaat. Kas sa ei saa siis aru.");
            //throw;
        }
        catch (OverflowException)
        {
            Console.WriteLine("ERROR. Sisestatud number on liiga suur.");
        }
    }
}