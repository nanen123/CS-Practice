using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        delegate void EnemyAttack(Enemy enemy, PLAYER player);

        public class Enemy
        {
            public int hp;
            public int dam;
        }

        public class PLAYER
        {
            public int dam;
            public int hp;
        }

        static void Main(string[] args)
        {
            PLAYER Player = new PLAYER() { hp = 3, dam = 1 };
            Enemy Enemy = new Enemy() { hp = 3, dam = 5 };

            EnemyAttack attack = (enemy, player) =>
            {
                if(enemy.dam >= player.hp)
                {
                    Console.WriteLine("플레이어 사망");
                }
                else
                {
                    Console.WriteLine(player.hp - enemy.dam);

                }
            };

            attack(Enemy, Player);
        }
    }
}
