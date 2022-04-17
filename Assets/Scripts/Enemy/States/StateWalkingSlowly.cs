namespace Enemy.States
{
    public class StateWalkingSlowly : State
    {
        public StateWalkingSlowly(EnemyControl enemy, StateMachine machine) : base(enemy, machine)
        {
        }

        public override void Enter()
        {
            Enemy.Animator.WalkingSlowly();
            Enemy.Movement.SelectSpeedWalkingSlowly();
        }

        public override void LogicUpdate()
        {
            Enemy.Movement.SelectTargetPlayer();
            if (Enemy.ManagerTransitions.CheckDistanceToWalkingCrouched())
            {
                Machine.ChangeState(Enemy.States.WalkingCrouched);
            }
        }
    }
}