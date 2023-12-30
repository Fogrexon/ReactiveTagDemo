using System;

namespace ReactiveTag.Generated.Tags
{
    public class f7f0ebeb9984ea86b85b21c8377c628c: Tag
    {
        private 8ee7261344b18c0c9d8c07d6a58bea9d _red;
        private 182e9a1842da73b96ec2d91cbad6594d _blue;
        private a49b09cca15031a99a4802ed6155c950 _green;

        public f7f0ebeb9984ea86b85b21c8377c628c(Guid id, string name): base(id, name)
        {
            this._red = new 8ee7261344b18c0c9d8c07d6a58bea9d(Guid.NewGuid(), "Red", this);
            this._blue = new 182e9a1842da73b96ec2d91cbad6594d(Guid.NewGuid(), "Blue", this);
            this._green = new a49b09cca15031a99a4802ed6155c950(Guid.NewGuid(), "Green", this);

        }
        public 8ee7261344b18c0c9d8c07d6a58bea9d Red => this._red;
        public 182e9a1842da73b96ec2d91cbad6594d Blue => this._blue;
        public a49b09cca15031a99a4802ed6155c950 Green => this._green;

    }
}
