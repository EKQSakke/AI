namespace AINodes
{
    using System.Threading.Tasks;
    using UnityEngine;

    public class AIAction : MonoBehaviour, IExecutableNode
    {
        public async Task Execute()
        {
            await Task.CompletedTask;
        }
    }
}
