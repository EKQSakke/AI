namespace AINodes
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using UnityEngine;

    public class AISelector : ExecutableNode
    {
        [SerializeField] List<AINode> targetNodes = new();

        public override void Execute()
        {
            foreach (var node in targetNodes)
            {
                if (!node.Check())
                    continue;

                TaskStart();
                node.Execute();
                Invoke("TaskStop", 0.3f);
                return;
            }
        }
    }
}