﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combateCSharp
{
    internal class Champion
    {
        public string Name { get; private set; }

        public int Life { get; private set; }
        public int Attack { get; private set; }
        public int Armor { get; private set; }
        
       public Champion (string name, int life, int attack, int armor)
        {
            Name = name;
            Life = life;
            Attack = attack;
            Armor = armor;            
        }

        public void TakeDamage(int attack)
        {
            int damage = Math.Max(1, attack - Armor);
            Life = Math.Max(0, Life - damage);
        }

        public string Status()
        {
            if (Life == 0)
            {
                return $"{Name}: {Life} de vida (morreu)";
            }
            else
            {
                return $"{Name}: {Life} de vida";
            }
        }

        public static Champion CreateChampion()
        {
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Vida inicial: ");
            int life = int.Parse(Console.ReadLine());

            Console.Write("Ataque: ");
            int attack = int.Parse(Console.ReadLine());

            Console.Write("Armadura: ");
            int armor = int.Parse(Console.ReadLine());

            return new Champion(name, life, attack, armor);

        }

    }
}
