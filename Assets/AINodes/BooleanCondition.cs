using UnityEngine;

namespace AINodes
{
    public class BooleanCondition : AICondition
    {
        public string variableKey;

        AIAgentBlackboard bb;

        public override void SpecialInit() 
        {
            bb = GetComponentInParent<AITree>().Blackboard;
        }
        
        public override bool Check()
        {
            if (bb is null) return false;
            return (bool) bb.GetBoardProperty(variableKey).value;
        }
    }
}