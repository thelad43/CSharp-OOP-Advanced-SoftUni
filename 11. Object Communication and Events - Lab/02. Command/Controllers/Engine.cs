namespace _02._Command.Controllers
{
    using Controllers.Commands;
    using Controllers.Executors;
    using Controllers.Loggers;
    using Interfaces;
    using Models.Attackers;
    using Models.Targets;

    public class Engine : IRunnable
    {
        public void Run()
        {
            var combatLogger = new CombatLogger();
            var eventLogger = new EventLogger();

            combatLogger.SetSuccessor(eventLogger);

            var warrior = new Warrior("gosho", 10, combatLogger);
            var dragon = new Dragon("pesho", 100, 25, combatLogger);

            var executor = new CommandExecutor();
            var command = new TargetCommand(warrior, dragon);
            var attack = new AttackCommand(warrior);

            executor.ExecuteCommand(command);
            executor.ExecuteCommand(attack);
        }
    }
}