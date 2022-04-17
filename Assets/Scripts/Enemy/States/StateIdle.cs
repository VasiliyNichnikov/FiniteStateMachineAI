namespace Enemy.States
{
    public class StateIdle : State
    {
        public StateIdle(EnemyControl enemy, StateMachine machine) : base(enemy, machine)
        {
        }

        public override void Enter()
        {
            Enemy.Animator.Idle();
            Enemy.Movement.Stop();
        }

        public override void LogicUpdate()
        {
            if (Enemy.ManagerTransitions.CheckDistanceToWalkingSlowly())
            {
                Machine.ChangeState(Enemy.States.WalkingSlowly);
            }
        }

        public override void Exit()
        {
            Enemy.Movement.Resume();
        }
    }
}