﻿namespace _05._BarrackWars_Return_of_the_Dependencies.Models.Units
{
    public class Archer : Unit
    {
        private const int DefaultHealth = 25;
        private const int DefaultDamage = 7;

        public Archer()
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}