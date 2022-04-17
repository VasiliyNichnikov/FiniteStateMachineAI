using Player;
using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    [RequireComponent(typeof(NavMeshAgent), typeof(Animator))]
    public class EnemyControl : MonoBehaviour
    {
        public EnemyAnimator Animator { get; private set; }
        public KeeperOfStates States { get; private set; }
        public EnemyMovement Movement { get; private set; }
        public ManagerTransitions ManagerTransitions { get; private set; }

        private void Start()
        {
            Transform playerTransform = FindObjectOfType<ThisPlayer>().transform;
            
            Animator = new EnemyAnimator(GetComponent<Animator>());
            Movement = new EnemyMovement(GetComponent<NavMeshAgent>(), playerTransform);
            ManagerTransitions = new ManagerTransitions(this, playerTransform);
            States = new KeeperOfStates(this);
        }

        private void Update()
        {
            States.UpdateStateMachine();
        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(transform.position, 10);
        }
    }
}