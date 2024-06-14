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
            Console.Write("Quantos turnos você deseja executar?  ");
            int turnos = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= turnos; i++)
            {
                champion1.TakeDamage(champion2.Attack);
                champion2.TakeDamage(champion1.Attack);

                Console.Write($"Resultado do turno{i}:");
                Console.WriteLine(champion1.Status());
                Console.WriteLine(champion2.Status());
                Console.WriteLine();

                if (champion1.Life == 0 || champion2.Life == 0)
                {
                    break;
                }
            }

            Console.WriteLine("FIM DO COMBATE");
            
        }
    }
}
