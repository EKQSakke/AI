using System.Threading.Tasks;
using UnityEngine.UI;

namespace AINodes
{
    public class AIActionWait : ExecutableNode
    {
        public override async Task Execute()
        {
            TaskStart();
            await Task.Delay(1000);
            TaskStop();
        }
    }
}