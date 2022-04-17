using UnityEngine;

namespace Enemy
{
    public class ManagerTransitions
    {
        private Transform _playerTransform;

        private Transform _thisTransform;
        private float _distanceBetweenEnemyAndPlayer => Vector3.Distance(_playerTransform.position, _thisTransform.position);

        public ManagerTransitions(EnemyControl enemy, Transform playerTransform)
        {
            _thisTransform = enemy.transform;
            _playerTransform = playerTransform;
        }
        
        public bool CheckDistanceToWalkingSlowly()
        {
            return CheckDistanceReduction(10);
        }

        public bool CheckDistanceToWalkingCrouched()
        {
            return CheckDistanceIncrease(3.5f);
        }

        public bool CheckDistanceToAttack()
        {
            return CheckDistanceReduction(2.5f);
        }

        public bool CheckDistanceToIdle()
        {
            return CheckDistanceIncrease(10.0f);
        }
        
        private bool CheckDistanceReduction(float minDistance)
        {
            return _distanceBetweenEnemyAndPlayer <= minDistance;
        }

        private bool CheckDistanceIncrease(float minDistance)
        {
            return _distanceBetweenEnemyAndPlayer >= minDistance;
        }
    }
}