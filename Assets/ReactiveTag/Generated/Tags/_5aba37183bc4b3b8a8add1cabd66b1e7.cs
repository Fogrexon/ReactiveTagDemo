using System;

namespace ReactiveTag.Generated.Tags
{
    public class _5aba37183bc4b3b8a8add1cabd66b1e7: Tag
    {
        private _f99a1927b7146e89f2cd6971193e3e6f _red;
        private _3ddc2b0d6025353aef3bca2e447320c1 _blue;
        private _48a99f67780d31ee23ae7e8494b69b18 _green;

        public _5aba37183bc4b3b8a8add1cabd66b1e7(Guid id, string name, Tag parent = null): base(id, name, parent)
        {
            this._red = new _f99a1927b7146e89f2cd6971193e3e6f(Guid.NewGuid(), "Red", this);
            this._blue = new _3ddc2b0d6025353aef3bca2e447320c1(Guid.NewGuid(), "Blue", this);
            this._green = new _48a99f67780d31ee23ae7e8494b69b18(Guid.NewGuid(), "Green", this);

        }
        public _f99a1927b7146e89f2cd6971193e3e6f Red => this._red;
        public _3ddc2b0d6025353aef3bca2e447320c1 Blue => this._blue;
        public _48a99f67780d31ee23ae7e8494b69b18 Green => this._green;

    }
}
