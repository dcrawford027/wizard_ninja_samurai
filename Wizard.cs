using System;

namespace wizard_ninja_samurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            Health = 50;
        }

        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.Health -= dmg;
            this.Health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{Name} healed {dmg} points of health!");
            return target.Health;
        }

        public void Heal(Human target) 
        {
            int heal = Intelligence * 10;
            target.Health += heal;
        }
    }

}