using System;

namespace ReactiveTag.Generated.Tags
{
    public class f99a1927b7146e89f2cd6971193e3e6f: Tag
    {
        private 1a62da621e4aeb66885e1d94f1293495 _red;

        public f99a1927b7146e89f2cd6971193e3e6f(Guid id, string name): base(id, name)
        {
            this._red = new 1a62da621e4aeb66885e1d94f1293495(Guid.NewGuid(), "Red", this);

        }
        public 1a62da621e4aeb66885e1d94f1293495 Red => this._red;

    }
}
