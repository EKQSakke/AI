namespace AINodes
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class AISequence : ExecutableNode
    {
        public List<AIAction> actions = new();

        public override async Task Execute()
        {
            foreach (var item in actions)
            {
                await item.Execute();
            }
        }
    }
}