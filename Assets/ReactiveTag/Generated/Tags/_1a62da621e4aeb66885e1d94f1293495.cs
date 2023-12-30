using System;

namespace ReactiveTag.Generated.Tags
{
    public class _1a62da621e4aeb66885e1d94f1293495: Tag
    {
        private _fc75e90dadec782c2c0efc1fe2609f6e _fire;

        public _1a62da621e4aeb66885e1d94f1293495(Guid id, string name, Tag parent = null): base(id, name, parent)
        {
            this._fire = new _fc75e90dadec782c2c0efc1fe2609f6e(Guid.NewGuid(), "Fire", this);

        }
        public _fc75e90dadec782c2c0efc1fe2609f6e Fire => this._fire;

    }
}
