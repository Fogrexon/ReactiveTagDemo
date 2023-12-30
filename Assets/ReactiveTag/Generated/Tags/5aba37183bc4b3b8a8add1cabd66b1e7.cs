using System;

namespace ReactiveTag.Generated.Tags
{
    public class 5aba37183bc4b3b8a8add1cabd66b1e7: Tag
    {
        private f99a1927b7146e89f2cd6971193e3e6f _red;
        private 3ddc2b0d6025353aef3bca2e447320c1 _blue;
        private 48a99f67780d31ee23ae7e8494b69b18 _green;

        public 5aba37183bc4b3b8a8add1cabd66b1e7(Guid id, string name): base(id, name)
        {
            this._red = new f99a1927b7146e89f2cd6971193e3e6f(Guid.NewGuid(), "Red", this);
            this._blue = new 3ddc2b0d6025353aef3bca2e447320c1(Guid.NewGuid(), "Blue", this);
            this._green = new 48a99f67780d31ee23ae7e8494b69b18(Guid.NewGuid(), "Green", this);

        }
        public f99a1927b7146e89f2cd6971193e3e6f Red => this._red;
        public 3ddc2b0d6025353aef3bca2e447320c1 Blue => this._blue;
        public 48a99f67780d31ee23ae7e8494b69b18 Green => this._green;

    }
}
