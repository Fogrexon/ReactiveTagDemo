using System;

namespace ReactiveTag.Generated.Tags
{
    public class 1a62da621e4aeb66885e1d94f1293495: Tag
    {
        private fc75e90dadec782c2c0efc1fe2609f6e _fire;

        public 1a62da621e4aeb66885e1d94f1293495(Guid id, string name): base(id, name)
        {
            this._fire = new fc75e90dadec782c2c0efc1fe2609f6e(Guid.NewGuid(), "Fire", this);

        }
        public fc75e90dadec782c2c0efc1fe2609f6e Fire => this._fire;

    }
}
