using System;

namespace wizard_ninja_samurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            double critChance = new Random().NextDouble();

            if (critChance <= 0.2) {
                dmg += 10;
            }

            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }

        public void Steal(Human target)
        {
            target.Health -= 5;
            this.Health += 5;
        }
    }
}