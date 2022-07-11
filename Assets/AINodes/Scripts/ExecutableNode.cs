using System;
using UnityEngine.UI;

namespace AINodes
{
    using System.Threading.Tasks;
    using UnityEngine;

    public abstract class ExecutableNode : MonoBehaviour
    {
        public Outline outline;
        void Start()
        {
            outline = GetComponentInParent<Outline>();
        }

        public void TaskStart()
        {
            outline.enabled = true;
        }

        public void TaskStop()
        {
            outline.enabled = false;
        }

        public abstract void Execute();
    }
}