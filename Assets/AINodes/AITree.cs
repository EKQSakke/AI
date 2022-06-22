using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AINodes
{
    using UnityEngine;

    public class AITree : MonoBehaviour
    {
        AIAgentBlackboard blackboard;
        [SerializeField] float timeout = 1f;
        [SerializeField] AINode rootNode;
        List<Task> tasks = new();
        float currentTime = 0;

        public AIAgentBlackboard Blackboard
        {
            get => blackboard;
            set => blackboard = value;
        }

        void Awake()
        {
            Blackboard = GetComponentInChildren<AIAgentBlackboard>();
        }

        private void OnEnable()
        {
            StartTree();
        }

        void FixedUpdate()
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0 && !tasks.Any(e => !e.IsCompleted))
                StartTree();
        }

        async void StartTree()
        {
            currentTime = timeout;
            
            if (rootNode is null)
                return;

            tasks.Add(rootNode.Execute());
        }
    }
}