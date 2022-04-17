namespace Enemy.States
{
    public abstract class State
    {
        protected EnemyControl Enemy;
        protected StateMachine Machine;
        
        protected State(EnemyControl enemy, StateMachine machine)
        {
            Enemy = enemy;
            Machine = machine;
        }
        
        public virtual void Enter()
        {
        }
        
        public virtual void LogicUpdate()
        {
        }
        
        public virtual void Exit()
        {
        }
    }
}