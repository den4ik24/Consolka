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
            Console.WriteLine("Здоровеньки булы\n" +
                " - неприветливо сказал он, не поднимая головы от стола - \n" +
                "чем он там занимался, не было видно, и Вы решили поздоровавшись тихонько отойти и не мешать ему");
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
            Console.WriteLine("Что ты хочешь узнать ?\nЯ всех и все в округе знаю. За недорого сторгуемся");
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
            Console.WriteLine("Добрый день!\nЧто ты хочешь приобрести?\nУ нас в лавке большой выбор разнообразного товара");
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
            Console.WriteLine("Здорова! \n- сказал кузнец, утирая пот. Он отвлекся от наковальни и уставился на Вас.\n" +
                "" +
                " В руке у него был нереально большой молот, казалось что и три человека его не поднимут,\n но кузнец держал его одной рукой!\n" +
                "У нас лучшие мечи - обратился он к Вам - Или тебе нужно подковать лошадь?");
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
            Console.WriteLine("Какие травы тебе нужны ? - Спросила  женщина из-за прилавка, заваленного разными корешками");
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
            Console.WriteLine("Вы видите задумчивого рыцаря, около входа в Трактир. Он как раз подходит к своей лошади на привязи рядом. \n" +
                "И Вы решаете к нему обратиться, но не успеваете. Увидев приближающуюся вашу фигуру он первым начинает разговор:\n" +
                "Ты знаешь, где можно совершить подвиг ? \n Ведь я не смогу жениться на Жозефине не свершив во имя Её множества подвигов. ");
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
            Console.WriteLine(" -С дороги, чернь - кричит Дворянин пролетая мимо вас на лошади, окатив Вас брызгами из-под копыт");
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
            Console.WriteLine(" П-п-ривет. Ты не знаешь какой сегодня день ? \n" +
                "Вы пожимаете плечами и ускоряете шаг, проходя мимо. Вы понимаете, что добится чего либо путного от него не получится");
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
            Console.WriteLine(" Здрав буди путник! Не желаешь поесть, выпить и отдохнуть с дороги ? Вы сильно устали после перехода через болота, и не мешало бы и отдохнуть, НО! \n" +
                "видя странные бурые пятна на полу трактира и грязный стакан, который Трактирщик протирал засаленным халатом, Вы не решились даже зайти внутрь.\n" +
                " Не говоря о том, что бы что-либо заказать или остаться переночевать. После такой ночевки неизвестно, останешся ли живым вообще...");
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
            Console.WriteLine(" Увидев приближающегося Вас дети бросились врасыпную." +
                "\n Только один малыш испугавшись застыл на месте, и начал громко верещать.\n" +
                "Вы же, не желая неприятостей, решили просто отойти от него подальше");
        }
    }
}
