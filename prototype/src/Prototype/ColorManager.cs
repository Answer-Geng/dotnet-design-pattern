using System.Collections.Generic;

namespace Prototype
{
    class ColorManager
    {
        Dictionary<string, Color> colors = new Dictionary<string, Color>();
        public Color this[string key]
        {
            get { return colors[key]; }
            set { colors.Add(key, value); }
        }

    }
}
