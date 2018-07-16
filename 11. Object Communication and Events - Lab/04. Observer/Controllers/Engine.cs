namespace _04._Observer.Controllers
{
    using Controllers.Commands;
    using Controllers.Executors;
    using Controllers.Loggers;
    using Interfaces;
    using Models;
    using Models.Attackers;
    using Models.Targets;
    using System.Collections.Generic;

    public class Engine : IRunnable
    {
        public void Run()
        {
            var combatLogger = new CombatLogger();
            var eventLogger = new EventLogger();

            combatLogger.SetSuccessor(eventLogger);

            var warriorGosho = new Warrior("gosho", 10, combatLogger);
            var warriorPesho = new Warrior("pesho", 100, combatLogger);

            var group = new Group();

            group.AddMember(warriorGosho);
            group.AddMember(warriorPesho);

            var observers = new List<IObserver>();

            var dragon = new Dragon("SnowWhite", 200, 25, combatLogger, observers);

            var executor = new CommandExecutor();

            var groupTarget = new GroupTargetCommand(group, dragon);
            var groupAttack = new GroupAttackCommand(group);

            executor.ExecuteCommand(groupTarget);
            executor.ExecuteCommand(groupAttack);
        }
    }
}