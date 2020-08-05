using System;

namespace wizard_ninja_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard zamzadar = new Wizard("Zamzadar");
            Ninja shadowMan = new Ninja("Shadow Man");
            Samurai hanzou = new Samurai("Hanzou");

            zamzadar.Attack(shadowMan);
            shadowMan.Attack(hanzou);
            hanzou.Attack(zamzadar);

            zamzadar.Heal(hanzou);
            shadowMan.Steal(zamzadar);
            hanzou.Meditate();
        }
    }
}
