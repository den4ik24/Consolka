using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace консолька
{
   public class NPC
    {
        public string name;

        public NPC(string name)
        {
            this.name = name;
        }

        public virtual void Talk()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("- Здоровеньки булы");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" - неприветливо сказал он, не поднимая головы от стола - \n" +
                "чем он там занимался, не было видно, и Вы решили поздоровавшись тихонько отойти и не мешать ему");
            Console.ForegroundColor = ConsoleColor.White;
        } 

    }

    public class NPCasker: NPC
    {
        public NPCasker(string name) : base(name)
        {
            
        }

        public override void Talk()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("- Что ты хочешь узнать ?\nЯ всех и все в округе знаю. За недорого сторгуемся");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class NPCtrader : NPC
    {
        public NPCtrader(string name) : base(name)
        {
            
        }

        public override void Talk()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("- Добрый день!\nЧто ты хочешь приобрести?\nУ нас в лавке большой выбор разнообразного товара");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class NPCblacksmith : NPC
    {
        public NPCblacksmith(string name) : base(name)
        {

        }

        public override void Talk()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" - Здорова!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("сказал кузнец, утирая пот со лба. Он отвлекся от наковальни и уставился на Вас.\n" +
                "В руке у него был нереально большой молот, казалось что и три человека его не поднимут,\nно кузнец держал его одной рукой!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" - У нас лучшие мечи");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("обратился он к Вам");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" - Или тебе нужно подковать лошадь?");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class NPCherbalist : NPC
    {
        public NPCherbalist(string name) : base(name)
        {

        }

        public override void Talk()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("- Какие травы тебе нужны ?");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("- Спросила  женщина из-за прилавка, заваленного разными корешками. Сверху свисали связки сушенных мухоморов\n " +
                "По виду прямо ведьма из сказок - длинный нос, торчащий зуб и прищуренный взгляд.\n" +
                "Вы не решились ничего брать у нее. А то вдруг в козлёночка обратит? ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class NPCknight : NPC
    {
        public NPCknight(string name) : base(name)
        {

        }

        public override void Talk()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Вы видите задумчивого рыцаря, около входа в Трактир. Он как раз подходит к своей лошади на привязи рядом. \n" +
                "И Вы решаете к нему обратиться, но не успеваете. Увидев приближающуюся вашу фигуру он первым начинает разговор:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("- Ты знаешь, где можно совершить подвиг ? \n - Ведь я не смогу жениться на Жозефине не свершив во имя Её множества подвигов.\n" +
                "Он начинает долго рассказывать про свою даму сердца, и вы сославшись на занятость спешите покинуть его. ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class NPCnobleman : NPC
    {
        public NPCnobleman(string name) : base(name)
        {

        }

        public override void Talk()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" -С дороги, чернь");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" - кричит Дворянин пролетая мимо вас на лошади, окатив Вас брызгами из-под копыт");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class NPCdrink : NPC
    {
        public NPCdrink(string name) : base(name)
        {

        }

        public override void Talk()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" - П-п-ривет. Ты не знаешь какой сегодня день ?");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Вы пожимаете плечами и ускоряете шаг, проходя мимо. Вы понимаете, что добится чего либо путного от него не получится");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class NPCmaster : NPC
    {
        public NPCmaster(string name) : base(name)
        {

        }

        public override void Talk()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" - Здрав буди путник! Не желаешь поесть, выпить и отдохнуть с дороги ?");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Вы сильно устали после перехода через болота, и не мешало бы и отдохнуть, НО! \n" +
                "видя странные бурые пятна на полу трактира и грязный стакан, который Трактирщик протирал засаленным халатом, Вы не решились даже зайти внутрь.\n" +
                " Не говоря о том, что бы что-либо заказать или остаться переночевать. После такой ночевки неизвестно, останешся ли живым вообще...");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class NPCchildren : NPC
    {
        public NPCchildren(string name) : base(name)
        {

        }

        public override void Talk()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Увидев приближающегося Вас дети бросились врасыпную." +
                "\n Только один малыш испугавшись застыл на месте, и начал громко верещать.\n" +
                "Вы же, не желая неприятостей, решили просто отойти от него подальше");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
