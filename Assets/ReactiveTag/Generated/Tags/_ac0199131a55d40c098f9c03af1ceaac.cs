using System;

namespace ReactiveTag.Generated.Tags
{
    public class _ac0199131a55d40c098f9c03af1ceaac: Tag
    {
        private _5aba37183bc4b3b8a8add1cabd66b1e7 _red;
        private _fb1956e2e4f839d72e33ffae923b9647 _blue;
        private _6ddb0c3dd237406dcabf4c5e42fb25fc _green;

        public _ac0199131a55d40c098f9c03af1ceaac(Guid id, string name, Tag parent = null): base(id, name, parent)
        {
            this._red = new _5aba37183bc4b3b8a8add1cabd66b1e7(Guid.NewGuid(), "Red", this);
            this._blue = new _fb1956e2e4f839d72e33ffae923b9647(Guid.NewGuid(), "Blue", this);
            this._green = new _6ddb0c3dd237406dcabf4c5e42fb25fc(Guid.NewGuid(), "Green", this);

        }
        public _5aba37183bc4b3b8a8add1cabd66b1e7 Red => this._red;
        public _fb1956e2e4f839d72e33ffae923b9647 Blue => this._blue;
        public _6ddb0c3dd237406dcabf4c5e42fb25fc Green => this._green;

    }
}
