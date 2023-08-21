internal class Program
{
    public static void Main(string[] args)
    {
        string[] kurslar = new string[] 
        {
            "kurs1",
            "kurs2",
            "kurs3",
            "kurs4",
            "kurs5"
        };

        for (int i = 0; i < kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine("---");
        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }

        Console.WriteLine("---- footer");
    }
}