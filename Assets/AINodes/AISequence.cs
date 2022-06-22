namespace AINodes
{
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using UnityEngine;

    public class AISequence : MonoBehaviour, IExecutableNode
    {
        public List<AIAction> actions = new();

        public async Task Execute()
        {
            foreach (var item in actions)
            {
                await item.Execute();
            }
        }
    }
}