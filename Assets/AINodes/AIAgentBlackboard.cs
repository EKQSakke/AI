using System.Text;
using TMPro;

namespace AINodes
{
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;

    public class AIAgentBlackboard : MonoBehaviour
    {
        // This work as a "blackboard" for ai.
        // gets hp, ammo, etc conditions from some source

        public Dictionary<string, object> values = new();

        TMP_Text bbText;

        void OnEnable()
        {
            bbText = GetComponentInChildren<TMP_Text>();
            values.Add("Hello", true);
            values.Add("World", true);
            values.Add("Penis", false);
        }

        void Update()
        {
            var sb = new StringBuilder();

            foreach (var item in GetProperties())
            {
                sb.Append(item.ToString());
                sb.Append("\n");
            }

            bbText.text = sb.ToString();
        }

        public List<BlackBoardProperty> GetProperties()
        {
            var props = new List<BlackBoardProperty>();
            foreach (var item in values)
                props.Add(new BlackBoardProperty(item.Key, item.Value));

            return props;
        }

        public BlackBoardProperty GetBoardProperty(string key)
        {
            return GetProperties().First(e => e.key == key);
        }
    }
}
