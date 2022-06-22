 namespace AINodes
{
    using System;
    using UnityEngine;
    using System.Collections.Generic;

    public class AINode : MonoBehaviour
    {
        public IAICondition[] conditions;
        public IExecutableNode[] executableNodes;
        AITree tree;

        private void OnEnable()
        {
            tree = GetComponentInParent<AITree>();
            executableNodes = GetComponents<IExecutableNode>();
            conditions = GetComponents<IAICondition>();
        }

        public void OnMouseDrag()
        {
            throw new NotImplementedException();
        }

        public bool Check()
        {
            if (conditions.Length == 0)
                return true;

            foreach (var item in conditions)
            {
                if (!item.Check())
                    return false;
            }
            return true;
        }
    }
}