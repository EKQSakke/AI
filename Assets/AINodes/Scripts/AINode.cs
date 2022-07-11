namespace AINodes
{
    using System.Threading.Tasks;
    using UnityEngine;
    using Utilities;

    public class AINode : MonoBehaviour
    {
        AICondition[] conditions;
        ExecutableNode executableNode;
        AITree tree;

        private void OnEnable()
        {
            tree = GetComponentInParent<AITree>();
            executableNode = GetComponentInChildren<ExecutableNode>();
            conditions = this.GetComponentsInMyChildren<AICondition>();
            OrderNodes();
        }

        public void OnMouseDrag()
        {
            Debug.LogError("Dragging has not been implemented yet!");
        }

        public void Execute()
        {
            Debug.Log("Executing: " + gameObject.name);
            executableNode.Execute();
        }

        public bool Check()
        {
            if (conditions is null || conditions.Length == 0)
                return true;

            foreach (var item in conditions)
            {
                if (!item.Check())
                    return false;
            }
            return true;
        }


        void OrderNodes()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                if (transform.GetChild(i).TryGetComponent<ExecutableNode>(out var executable))
                {
                    executable.transform.SetAsLastSibling();
                }
            }
        }
    }
}