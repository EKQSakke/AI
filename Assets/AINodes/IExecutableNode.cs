namespace AINodes
{
    using System.Threading.Tasks;

    public interface IExecutableNode
    {
        public Task Execute();
    }
}