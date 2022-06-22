namespace AINodes
{
    using System.Threading.Tasks;

    public class AIAction : ExecutableNode
    {
        public override async Task Execute()
        {
            await Task.CompletedTask;
        }
    }
}
