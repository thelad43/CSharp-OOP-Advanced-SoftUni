﻿namespace Skeleton
{
    using Interfaces;
    using System;

    public class Dummy : ITarget
    {
        private int health;
        private readonly int experience;

        public Dummy(int health, int experience)
        {
            this.health = health;
            this.experience = experience;
        }

        public int Health
        {
            get
            {
                return this.health;
            }
        }

        public void TakeAttack(int attackPoints)
        {
            if (this.IsDead())
            {
                throw new InvalidOperationException("Dummy is dead.");
            }

            this.health -= attackPoints;
        }

        public void TakeAttack()
        {
            throw new NotImplementedException();
        }

        public int GiveExperience()
        {
            if (!this.IsDead())
            {
                throw new InvalidOperationException("Target is not dead.");
            }

            return this.experience;
        }

        public bool IsDead()
        {
            return this.health <= 0;
        }
    }
}