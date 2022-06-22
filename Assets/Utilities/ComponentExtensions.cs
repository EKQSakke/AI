namespace Utilities
{
    using System.Collections.Generic;
    using UnityEngine;

    public static class ComponentExtensions
    {
        public static T[] GetComponentsInMyChildren<T>(this Component parentComponent)
        {
            var list = new List<T>();
            var transform = parentComponent.transform;
            for (int i = 0; i < transform.childCount; i++)
            {
                var child = transform.GetChild(i);
                if (child.TryGetComponent(out T component))
                {
                    list.Add(component);
                }
            }

            return list.ToArray();
        }
    }
}