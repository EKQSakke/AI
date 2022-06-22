namespace AINodes
{
    using UnityEngine;

    public class AITree : MonoBehaviour
    {
        public AIAgentBlackboard blackboard;
        [SerializeField] float timeout = 1f;
        [SerializeField] IExecutableNode root;
        float currentTime = 0;

        void OnEnable()
        {
            blackboard = GetComponentInChildren<AIAgentBlackboard>();
            root?.Execute();
        }

        void Update()
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
                StartTree();
        }

        void StartTree()
        {
            currentTime = timeout;
            root?.Execute();
        }

    }
}