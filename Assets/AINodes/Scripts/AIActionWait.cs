using System.Threading.Tasks;
using UnityEngine.UI;

namespace AINodes
{
    public class AIActionWait : ExecutableNode
    {
        public override void Execute()
        {
            TaskStart();
            Invoke("TaskStop", .3f);
        }
    }
}