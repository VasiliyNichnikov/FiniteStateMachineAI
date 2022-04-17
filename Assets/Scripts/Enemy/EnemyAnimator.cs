using MyUtils;
using UnityEngine;

namespace Enemy
{
    public class EnemyAnimator
    {
        private Animator _animator;
        
        public EnemyAnimator(Animator animator)
        {
            _animator = animator;
        }

        public void Idle()
        {
            _animator.SetFloat(EnemyAnimationKeystore.Basic, 0);
        }

        public void Attack()
        {
            _animator.SetFloat(EnemyAnimationKeystore.Basic, 0.51f);
        }

        public void WalkingSlowly()
        {
            _animator.SetFloat(EnemyAnimationKeystore.Basic, 1);
            _animator.SetFloat(EnemyAnimationKeystore.Walk, 0);
        }

        public void WalkingCrouched()
        {
            _animator.SetFloat(EnemyAnimationKeystore.Basic, 1);
            _animator.SetFloat(EnemyAnimationKeystore.Walk, 1);
        }
        
    }
}