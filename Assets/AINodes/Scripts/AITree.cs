using System.Reflection;
using System.Collections.Generic;
namespace AINodes
{
    using System.Linq;
    using UnityEngine;

    public class AITree : MonoBehaviour
    {
        AIAgentBlackboard blackboard;
        AIFunctions functions;
        [SerializeField] float timeout = 1f;
        [SerializeField] AINode rootNode;
        float currentTime = 0;


        public AIAgentBlackboard Blackboard
        {
            get => blackboard;
            set => blackboard = value;
        }
        public AIFunctions Functions { get => functions; set => functions = value; }

        void Awake()
        {
            Blackboard = GetComponentInChildren<AIAgentBlackboard>();
            Functions = GetComponent<AIFunctions>();
            LoadFunctions();
        }

        void LoadFunctions()
        {
            foreach (var method in typeof(IAIFunctions).GetMethods())
            {
                var parameters = method.GetParameters();
                var parameterDescriptions = string.Join
                    (", ", method.GetParameters()
                                 .Select(x => x.ParameterType + " " + x.Name)
                                 .ToArray());

                Debug.Log($"{method.ReturnType}, {method.Name}, ({parameterDescriptions})");
            }

        }

        private void OnEnable()
        {
            StartTree();
        }

        void FixedUpdate()
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
                StartTree();
        }

        void StartTree()
        {
            currentTime = timeout;

            if (rootNode is null)
                return;

            rootNode.Execute();
        }
    }
}