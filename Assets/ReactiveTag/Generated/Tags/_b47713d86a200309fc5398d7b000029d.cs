using System;

namespace ReactiveTag.Generated.Tags
{
    public class _b47713d86a200309fc5398d7b000029d: Tag
    {
        private _4fffa26ab30c38fba0dbecd243537669 _wall;
        private _ac0199131a55d40c098f9c03af1ceaac _floor;

        public _b47713d86a200309fc5398d7b000029d(Guid id, string name, Tag parent = null): base(id, name, parent)
        {
            this._wall = new _4fffa26ab30c38fba0dbecd243537669(Guid.NewGuid(), "Wall", this);
            this._floor = new _ac0199131a55d40c098f9c03af1ceaac(Guid.NewGuid(), "Floor", this);

        }
        public _4fffa26ab30c38fba0dbecd243537669 Wall => this._wall;
        public _ac0199131a55d40c098f9c03af1ceaac Floor => this._floor;

    }
}
