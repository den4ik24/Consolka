using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace консолька
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string exit = "";
                do
                {
                                                       
                    Console.WriteLine("Вы оказались в небольшой деревушке на окраине болот. Сразу за домами начинается густая стена непроходимого леса.\n" +
                        "Вы видите перед собой несколько скошенных домов - это и вся деревня." +
                        "\nВдоль одной кривой улицы - по видимому главной, т.к. других и не наблюдается - расположены Таверна и магазинчики. " +
                        "\n Попробуем подойти к одному из виднеющихся на улице людей. ");
                    Console.WriteLine();

                    List<NPC> NPCS = new List<NPC>();
                    NPCS.Add(new NPC("Крестьянин, сидящий за столом"));
                    NPCS.Add(new NPCasker("Проныра, грызет семечки возле Таверны. Его маленькие и хитрые глазки так и зыркают по сторонам"));
                    NPCS.Add(new NPCtrader("Торговец, сидит на ступенях мелкой лавки у дороги"));
                    NPCS.Add(new NPCblacksmith("Кузнец, звон металла о металл раздается из кузни"));
                    NPCS.Add(new NPCherbalist("Травник, его длинный нос торчит над прилавком напротив Таверны "));
                    NPCS.Add(new NPCknight("Рыцарь в ржавых доспехах, выходящий из Таверны"));
                    NPCS.Add(new NPCnobleman("Расфуфыренный Дворянин, скачущий на гнедом жеребце, вдоль улицы по лужам"));
                    NPCS.Add(new NPCdrink("Пьяница, валяющийся за углом Таверны. Похоже завсегдатай заведения"));
                    NPCS.Add(new NPCmaster("Хозяин таверны, протирающий стакан у входа в своё заведение"));
                    NPCS.Add(new NPCchildren("Стайка детей, играющих в зоровенной луже посреди дороги"));

                    int i = 0;
                    foreach (var npc in NPCS)
                    {
                       
                        Console.WriteLine( i + " - " + npc.name);
                        i++;
                        
                    }
                    Console.WriteLine();
                    Console.WriteLine("К кому вы хотите обратиться?");
                    NPCS[Convert.ToInt32(Console.ReadLine())].Talk();
                    exit = Console.ReadLine();
                }
                while (exit != "exit");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Вы ввели не число. {ex.Message}");
            }
            finally
            {
                Console.ReadKey();
            }

            
        }
    }
}
