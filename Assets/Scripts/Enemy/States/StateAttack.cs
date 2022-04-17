using System.Collections;

namespace Enemy.States
{
    public class StateAttack : State
    {
        private IEnumerator _running;
        
        public StateAttack(EnemyControl enemy, StateMachine machine) : base(enemy, machine)
        {
        }

        public override void Enter()
        {
            Enemy.Animator.Attack();
            Enemy.Movement.Stop();
        }

        public override void LogicUpdate()
        {
            if(Enemy.ManagerTransitions.CheckDistanceToWalkingCrouched())
                Machine.ChangeState(Enemy.States.WalkingCrouched);
        }

        public override void Exit()
        {
            Enemy.Movement.Resume();
        }
    }
}