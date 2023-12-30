using System;

namespace ReactiveTag.Generated.Tags
{
    public class _0f47cb052d3f540e7460ec925573cb06: Tag
    {
        private _9710b1f24673ff1917c1b58f68b48b04 _red;
        private _1ba57c9cd9f94637f0237d39c0d2c1e4 _blue;
        private _c24d746688f270016259527b3cf8234d _green;

        public _0f47cb052d3f540e7460ec925573cb06(Guid id, string name, Tag parent = null): base(id, name, parent)
        {
            this._red = new _9710b1f24673ff1917c1b58f68b48b04(Guid.NewGuid(), "Red", this);
            this._blue = new _1ba57c9cd9f94637f0237d39c0d2c1e4(Guid.NewGuid(), "Blue", this);
            this._green = new _c24d746688f270016259527b3cf8234d(Guid.NewGuid(), "Green", this);

        }
        public _9710b1f24673ff1917c1b58f68b48b04 Red => this._red;
        public _1ba57c9cd9f94637f0237d39c0d2c1e4 Blue => this._blue;
        public _c24d746688f270016259527b3cf8234d Green => this._green;

    }
}
