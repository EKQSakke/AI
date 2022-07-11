using UnityEngine;

namespace AINodes
{
    public class BooleanCondition : AICondition
    {
        public string variableKey;

        public override bool Check()
        {
            if (blackboard is null) return false;
            return (bool) blackboard.GetBoardProperty(variableKey).value;
        }
    }
}