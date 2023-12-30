using System;

namespace ReactiveTag.Generated.Tags
{
    public class 0f47cb052d3f540e7460ec925573cb06: Tag
    {
        private 9710b1f24673ff1917c1b58f68b48b04 _red;
        private 1ba57c9cd9f94637f0237d39c0d2c1e4 _blue;
        private c24d746688f270016259527b3cf8234d _green;

        public 0f47cb052d3f540e7460ec925573cb06(Guid id, string name): base(id, name)
        {
            this._red = new 9710b1f24673ff1917c1b58f68b48b04(Guid.NewGuid(), "Red", this);
            this._blue = new 1ba57c9cd9f94637f0237d39c0d2c1e4(Guid.NewGuid(), "Blue", this);
            this._green = new c24d746688f270016259527b3cf8234d(Guid.NewGuid(), "Green", this);

        }
        public 9710b1f24673ff1917c1b58f68b48b04 Red => this._red;
        public 1ba57c9cd9f94637f0237d39c0d2c1e4 Blue => this._blue;
        public c24d746688f270016259527b3cf8234d Green => this._green;

    }
}
