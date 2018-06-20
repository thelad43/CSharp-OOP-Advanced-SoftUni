﻿namespace _04._Recharge.Models
{
    using Interfaces;

    public class Robot : Worker, IRechargeable
    {
        private readonly int capacity;
        private int currentPower;

        public Robot(string id, int capacity)
            : base(id)
        {
            this.capacity = capacity;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        public int CurrentPower
        {
            get
            {
                return this.currentPower;
            }
            set
            {
                this.currentPower = value;
            }
        }

        public new void Work(int hours)
        {
            if (hours > this.currentPower)
            {
                hours = this.currentPower;
            }

            base.Work(hours);
            this.currentPower -= hours;
        }

        public void Recharge()
        {
            this.currentPower = this.capacity;
        }
    }
}