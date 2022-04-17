using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    public class EnemyMovement
    {
        private Transform _playerTransform;
        private NavMeshAgent _agent;

        public EnemyMovement(NavMeshAgent agent, Transform playerTransform)
        {
            _agent = agent;
            _playerTransform = playerTransform;
        }

        public void Stop()
        {
            _agent.isStopped = true;
        }

        public void Resume()
        {
            _agent.isStopped = false;
        }

        public void SelectTargetPlayer()
        {
            _agent.SetDestination(_playerTransform.position);
        }
        
        public void SelectSpeedWalkingSlowly()
        {
            _agent.speed = 2.0f;
        }
        
        public void SelectSpeedWalkingCrouched()
        {
            _agent.speed = 0.5f;
        }
    }
}