namespace Enemy.States
{
    public class StateWalkingCrouched : State
    {
        public StateWalkingCrouched(EnemyControl enemy, StateMachine machine) : base(enemy, machine)
        {
        }

        public override void Enter()
        {
            Enemy.Animator.WalkingCrouched();
            Enemy.Movement.SelectSpeedWalkingCrouched();
        }

        public override void LogicUpdate()
        {
            Enemy.Movement.SelectTargetPlayer();
            if (Enemy.ManagerTransitions.CheckDistanceToAttack())
            {
                Machine.ChangeState(Enemy.States.Attack);
            }
            else if (Enemy.ManagerTransitions.CheckDistanceToIdle())
            {
                Machine.ChangeState(Enemy.States.Idle);
            }
        }
    }
}