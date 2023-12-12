namespace PrenotazioniRistorante2
{
    internal class Program
{
    static void Main(string[] args)
    {
        int tavoli2 = 3;
        int tavoli4 = 3;
        int tavoli6 = 4;
        int tavoliTot = tavoli2 + tavoli4 + tavoli6;
        for (int i = 0; i < tavoliTot;)
        {
            
            Console.WriteLine("Quante persone");
            int persone = Convert.ToInt32(Console.ReadLine());
            if (persone <= 2)
            {
                if (tavoli2 == 0 && tavoli4 == 0 && tavoli6 == 0)
                {
                        Console.WriteLine("non ci sono nemmeno più tavoli da 6...");
                        i = tavoliTot;
                }
                else if (tavoli2 == 0 && tavoli4 == 0)
                {
                        Console.WriteLine("Oh..");
                        Thread.Sleep(1000);
                        Console.WriteLine("non ci sono più tavoli da 4...");
                        Thread.Sleep(1000);
                        Console.WriteLine("ti assegnamo a un tavolo da 6");
                        tavoli6--;
                        tavoliTot = tavoli2 + tavoli4 + tavoli6;
                        Thread.Sleep(500);
                        Console.WriteLine("rimangono " + tavoliTot + " tavoli");
                }
                else if (tavoli2 == 0)
                {
                        Console.WriteLine("Oh..");
                        Thread.Sleep(1000);
                        Console.WriteLine("non ci sono più tavoli da 2...");
                        Thread.Sleep(1000);
                        Console.WriteLine("ti assegnamo a un tavolo da 4");
                        tavoli4--;
                        tavoliTot = tavoli2 + tavoli4 + tavoli6;
                        Thread.Sleep(500);
                        Console.WriteLine("rimangono " + tavoliTot + " tavoli");
                }
                else
                {
                        Console.WriteLine("Perfetto!");
                        Thread.Sleep(1000);
                    Console.WriteLine("Assegnato al tavolo da 2");
                    tavoli2--;
                    tavoliTot = tavoli2 + tavoli4 + tavoli6;
                        Thread.Sleep(500);
                        Console.WriteLine("rimangono " + tavoliTot + " tavoli");
                }
            }
            else if (persone > 2 && persone <= 4)
            {
                    if (tavoli4 == 0 && tavoli6 == 0)
                    {
                        Console.WriteLine("non ci sono nemmeno più tavoli da 6...");
                        i = tavoliTot;
                    }
                    else if (tavoli4 == 0)
                    {
                        Console.WriteLine("Oh..");
                        Thread.Sleep(1000);
                        Console.WriteLine("non ci sono più tavoli da 4");
                        Thread.Sleep(1000);
                        Console.WriteLine("ti assegnamo a un tavolo da 6");
                        tavoli6--;
                        tavoliTot = tavoli2 + tavoli4 + tavoli6;
                        Thread.Sleep(500);
                        Console.WriteLine("rimangono " + tavoliTot + " tavoli");
                    }
                    else
                    {
                        Console.WriteLine("Perfetto!");
                        Thread.Sleep(1000);
                        Console.WriteLine("Assegnato al tavolo da 4");
                        tavoli4--;
                        tavoliTot = tavoli2 + tavoli4 + tavoli6;
                        Thread.Sleep(500);
                        Console.WriteLine("rimangono " + tavoliTot + " tavoli");
                    }
            }
            else if (persone > 4 && persone <= 6)
            {
                Console.WriteLine("Assegnato al tavolo da 6");
                tavoli6--;
                tavoliTot = tavoli2 + tavoli4 + tavoli6;
                Thread.Sleep(500);
                Console.WriteLine("rimangono " + tavoliTot + " tavoli");
            }
            else if (persone > 6)
            {
                Console.WriteLine("Troppe persone, ciao ciao");
            }
            if (persone == 69)
                {
                    Console.WriteLine("EASTER EGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG!!");
                    Thread.Sleep(500);
                    Console.WriteLine("WHOOOO!!");
                    Thread.Sleep(500);
                    Console.WriteLine("WHOOOO!!");
                    Thread.Sleep(500);
                    Console.WriteLine("WHOOOO!!");
                    Thread.Sleep(500);
                    Console.WriteLine("WHOOOO!!");
                    Thread.Sleep(500);
                    Console.WriteLine("WHOOOO!!");
                    int habbart = 0;
                    while (habbart <= 696969)
                    {
                        Console.Write("CAVALLO - ");
                        habbart++;
                    }
                }
                Console.WriteLine();
        }
            Thread.Sleep(1000);
            Console.WriteLine("Oh no..");
            Thread.Sleep(1000);
            Console.WriteLine("abbiamo finito i tavoli");
            Thread.Sleep(1000);
            Console.WriteLine("grazie mille!");
            Thread.Sleep(1000);
            Console.WriteLine("Arrivederci!!");
            Thread.Sleep(2000);
    }
}
}