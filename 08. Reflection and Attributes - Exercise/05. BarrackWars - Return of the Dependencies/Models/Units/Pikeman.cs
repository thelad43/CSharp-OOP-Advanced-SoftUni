namespace _05._BarrackWars_Return_of_the_Dependencies.Models.Units
{
    public class Pikeman : Unit
    {
        private const int DefaultHealth = 30;
        private const int DefaultDamage = 15;

        public Pikeman()
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}