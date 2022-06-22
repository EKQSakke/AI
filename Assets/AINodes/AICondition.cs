using System;

namespace AINodes
{
    using UnityEngine;
    using UnityEngine.UI;

    public abstract class AICondition : MonoBehaviour
    {
        Image image;

        void Start()
        {
            Init();
            SpecialInit();
        }

        public void Init()
        {
            image = GetComponent<Image>();
        }

        private void Update()
        {
            if (image is null)
                return;
            
            image.color = Check() ? Color.green : Color.red;
        }

        public abstract bool Check();

        public abstract void SpecialInit();
    }
}