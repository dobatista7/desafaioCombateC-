namespace combateCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do primeiro campeão: ");
            Champion champion1 = Champion.CreateChampion();

            Console.WriteLine();
            Console.WriteLine("Digite os dados do segundo campeão: ");
            Champion champion2 = Champion.CreateChampion();

            Console.WriteLine();
            Console.WriteLine("Quantos turnos você deseja executar?");
            int turnos = int.Parse(Console.ReadLine());
            
        }
    }
}
