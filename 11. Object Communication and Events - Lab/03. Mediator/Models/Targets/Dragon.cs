namespace _03._Mediator.Models.Targets
{
    using Controllers.Loggers;
    using Enums;
    using Interfaces;

    public class Dragon : ITarget
    {
        private const string ThisDiedEvent = "{0} dies";

        private readonly string id;
        private int hp;
        private readonly int reward;
        private bool eventTriggered;
        private readonly Logger logger;

        public Dragon(string id, int hp, int reward, Logger logger)
        {
            this.id = id;
            this.hp = hp;
            this.reward = reward;
            this.logger = logger;
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
    }
}