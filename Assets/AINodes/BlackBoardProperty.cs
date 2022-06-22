using System;

namespace AINodes
{
    public struct BlackBoardProperty
    {
        public enum PropertyType
        {
            Int,
            Float,
            Bool,
            String
        }

        private string key;
        public object value;

        public PropertyType propertyType;

        public BlackBoardProperty(string key, object value) : this()
        {
            this.key = key;
            this.value = value;

            switch (value)
            {
                case int:
                    propertyType = PropertyType.Int;
                    break;
                case float:
                    propertyType = PropertyType.Float;
                    break;
                case bool:
                    propertyType = PropertyType.Bool;
                    break;
                case string:
                    propertyType = PropertyType.String;
                    break;
            }
        }

        public override string ToString()
        {
            return key + " - " + value;
        }
    }
}