using ReactiveTag;
using UnityEngine;

namespace ReactiveTag.Generated.Tags
{
    public class ReactiveTagRoot: Tag
    {
        private static fd27088378bd055494f836b4d6dcd146 _dynamic;
        public static fd27088378bd055494f836b4d6dcd146 Dynamic { get { 
            if (_dynamic is null)
            {
                _dynamic = new fd27088378bd055494f836b4d6dcd146(Guid.NewGuid(), "Dynamic", this);
            }
            return _dynamic;
        } }
        private static b47713d86a200309fc5398d7b000029d _static;
        public static b47713d86a200309fc5398d7b000029d Static { get { 
            if (_static is null)
            {
                _static = new b47713d86a200309fc5398d7b000029d(Guid.NewGuid(), "Static", this);
            }
            return _static;
        } }

    }
}
