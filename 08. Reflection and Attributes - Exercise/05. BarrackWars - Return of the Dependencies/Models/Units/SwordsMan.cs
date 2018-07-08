﻿namespace _05._BarrackWars_Return_of_the_Dependencies.Models.Units
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