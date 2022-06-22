namespace AINodes
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using UnityEngine;

    public class AISelector : ExecutableNode
    {
        [SerializeField] List<AINode> targetNodes = new();

        public override async Task Execute()
        {
            foreach (var node in targetNodes)
            {
                if (!node.Check())
                    continue;

                TaskStart();
                await node.Execute();
                TaskStop();
                return;
            }
        }
    }
}