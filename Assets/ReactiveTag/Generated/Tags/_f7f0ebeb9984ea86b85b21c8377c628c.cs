using System;

namespace ReactiveTag.Generated.Tags
{
    public class _f7f0ebeb9984ea86b85b21c8377c628c: Tag
    {
        private _8ee7261344b18c0c9d8c07d6a58bea9d _red;
        private _182e9a1842da73b96ec2d91cbad6594d _blue;
        private _a49b09cca15031a99a4802ed6155c950 _green;

        public _f7f0ebeb9984ea86b85b21c8377c628c(Guid id, string name, Tag parent = null): base(id, name, parent)
        {
            this._red = new _8ee7261344b18c0c9d8c07d6a58bea9d(Guid.NewGuid(), "Red", this);
            this._blue = new _182e9a1842da73b96ec2d91cbad6594d(Guid.NewGuid(), "Blue", this);
            this._green = new _a49b09cca15031a99a4802ed6155c950(Guid.NewGuid(), "Green", this);

        }
        public _8ee7261344b18c0c9d8c07d6a58bea9d Red => this._red;
        public _182e9a1842da73b96ec2d91cbad6594d Blue => this._blue;
        public _a49b09cca15031a99a4802ed6155c950 Green => this._green;

    }
}
