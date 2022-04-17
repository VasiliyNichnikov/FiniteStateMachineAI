using Enemy.States;

namespace Enemy
{
    public class KeeperOfStates
    {
        public StateIdle Idle { get; private set; }
        public StateWalkingSlowly WalkingSlowly { get; private set; }
        public StateWalkingCrouched WalkingCrouched { get; private set; }
        public StateAttack Attack { get; private set; }

        private readonly StateMachine _stateMachine;

        public KeeperOfStates(EnemyControl enemy)
        {
            _stateMachine = new StateMachine();
            Idle = new StateIdle(enemy, _stateMachine);
            WalkingSlowly = new StateWalkingSlowly(enemy, _stateMachine);
            WalkingCrouched = new StateWalkingCrouched(enemy, _stateMachine);
            Attack = new StateAttack(enemy, _stateMachine);
            
            _stateMachine.Initialize(Idle);
        }

        public void UpdateStateMachine()
        {
            _stateMachine?.LogicUpdate();
        }
    }
}