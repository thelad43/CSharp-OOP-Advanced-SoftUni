namespace _04._BarrackWars_The_Commands_Strike_Back.Models.Units
{
    public class Swordsman : Unit
    {
        private const int DefaultHealth = 40;
        private const int DefaultDamage = 13;

        public Swordsman()
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}