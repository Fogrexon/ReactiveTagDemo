using System;

namespace ReactiveTag.Generated.Tags
{
    public class b47713d86a200309fc5398d7b000029d: Tag
    {
        private 4fffa26ab30c38fba0dbecd243537669 _wall;
        private ac0199131a55d40c098f9c03af1ceaac _floor;

        public b47713d86a200309fc5398d7b000029d(Guid id, string name): base(id, name)
        {
            this._wall = new 4fffa26ab30c38fba0dbecd243537669(Guid.NewGuid(), "Wall", this);
            this._floor = new ac0199131a55d40c098f9c03af1ceaac(Guid.NewGuid(), "Floor", this);

        }
        public 4fffa26ab30c38fba0dbecd243537669 Wall => this._wall;
        public ac0199131a55d40c098f9c03af1ceaac Floor => this._floor;

    }
}
