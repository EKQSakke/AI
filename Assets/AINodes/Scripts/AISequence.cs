namespace AINodes
{
    using System.Collections.Generic;

    public class AISequence : ExecutableNode
    {
        ///<summary>
        /// These should not include AISequence or AISelector nodes, to keep it simple
        ///</summary>
        public List<ExecutableNode> actions = new();

        public override void Execute()
        {
            foreach (var item in actions)
            {
                item.Execute();
            }
        }
    }
}