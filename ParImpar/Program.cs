internal class Program
{
    private static void Main(string[] args)
    {
        int n1;

        Console.WriteLine("Digite um número: ");
        n1 = int.Parse(Console.ReadLine());

        if (n1 %2 == 0) {
            Console.WriteLine("O número digitado é PAR");
        } else {
            Console.WriteLine("O número é IMPAR");
                }
    }
}