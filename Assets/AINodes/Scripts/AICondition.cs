using System;
namespace AINodes

{
    using UnityEngine;
    using UnityEngine.UI;

    public abstract class AICondition : MonoBehaviour
    {
        Image image;

        public AIAgentBlackboard blackboard;

        void Start()
        {
            image = GetComponent<Image>();
            blackboard = GetComponentInParent<AITree>().Blackboard;
        }

        private void Update()
        {
            if (image is null)
                return;
            
            image.color = Check() ? Color.green : Color.red;
        }

        public abstract bool Check();
    }
}