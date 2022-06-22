namespace AINodes
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using UnityEngine;

    public class AISelector : MonoBehaviour, IExecutableNode
    {
        public AITree tree;

        List<AINode> targetNodes = new();
        
        public async Task Execute()
        {
            foreach (var node in targetNodes)
            {
                if (!node.Check())
                    return;

                foreach (var execNode in node.executableNodes)
                {
                    await execNode.Execute();
                }
                return;
            }
        }
    }
}