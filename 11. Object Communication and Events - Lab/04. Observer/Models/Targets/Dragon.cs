namespace _04._Observer.Models.Targets
{
    using Controllers.Loggers;
    using Enums;
    using Interfaces;
    using System.Collections.Generic;

    public class Dragon : ITarget
    {
        private const string ThisDiedEvent = "{0} dies";

        private readonly string id;
        private int hp;
        private readonly int reward;
        private bool eventTriggered;
        private readonly Logger logger;
        private readonly IList<IObserver> observers;

        public Dragon(string id, int hp, int reward, Logger logger, IList<IObserver> observers)
        {
            this.id = id;
            this.hp = hp;
            this.reward = reward;
            this.logger = logger;
            this.observers = observers;
        }

        public bool IsDead { get => this.hp <= 0; }

        public void ReceiveDamage(int damage)
        {
            if (!this.IsDead)
            {
                this.hp -= damage;
            }

            if (this.IsDead && !this.eventTriggered)
            {
                this.logger.Handle(LogType.EVENT, ThisDiedEvent);
                this.eventTriggered = true;
            }
        }

        public override string ToString()
        {
            return this.id;
        }

        public void Register(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in this.observers)
            {
                observer.Update(this.reward);
            }
        }
    }
}