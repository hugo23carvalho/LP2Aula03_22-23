using System;

namespace GameInterfaces
{
    public abstract class Unit :IHasValue
    {
        private int movement;
        public virtual int Health { get; set; }
        public abstract float Value => 100f;

        protected Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move(Vector2 v)
        {
            // Assumindo vizinhança Von Neumann
            int d = Math.Abs(v.X) + Math.Abs(v.Y);

            // int d = (v.X >= 0 ? v.X : -v.X)
            //     + (v.Y >= 0 ? v.Y : -v.Y);

            Console.WriteLine(
                $"{this.GetType().Name} has moved {d} positions");
        }

        public override string ToString() =>
            $"HP={Health}, Val={Value}";
    }
}