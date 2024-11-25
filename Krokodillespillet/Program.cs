using System;

class KrokoChoice2000
{
    public static int poeng = 0;
    Random random = new Random();

    public void Start()
    {
        int tall = random.Next(1, 11);
        int tall2 = random.Next(1, 11);

        Console.WriteLine($"{tall}__{tall2}");
        Console.WriteLine("Skriv inn <, > eller =");

        var svar = Console.ReadLine();

        if (tall > tall2 && svar == ">")
        {
            Console.WriteLine("Rett svar!");
            poeng++;
        }
        else if (tall < tall2 && svar == "<")
        {
            Console.WriteLine("Rett svar!");
            poeng++;
        }
        else if (tall == tall2 && svar == "=")
        {
            Console.WriteLine("Rett svar!");
            poeng++;
        }
        else
        {
            Console.WriteLine("Feil svar!");
            poeng--;
        }

        Console.WriteLine($"Poeng: {poeng}");

        if (poeng == 5)
        {
            Console.Beep();
            Console.WriteLine("Du vant!");
        }
    }

    public static void LoopieDuke()
    {
        KrokoChoice2000 program = new KrokoChoice2000();
        while (poeng < 5)
        {
            program.Start();
        }
    }

    static void Main(string[] args)
    {
        LoopieDuke();
    }
}