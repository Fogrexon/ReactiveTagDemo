using System;

namespace ReactiveTag.Generated.Tags
{
    public class _f99a1927b7146e89f2cd6971193e3e6f: Tag
    {
        private _1a62da621e4aeb66885e1d94f1293495 _red;

        public _f99a1927b7146e89f2cd6971193e3e6f(Guid id, string name, Tag parent = null): base(id, name, parent)
        {
            this._red = new _1a62da621e4aeb66885e1d94f1293495(Guid.NewGuid(), "Red", this);

        }
        public _1a62da621e4aeb66885e1d94f1293495 Red => this._red;

    }
}
