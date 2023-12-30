using System;

namespace ReactiveTag.Generated.Tags
{
    public class 4fffa26ab30c38fba0dbecd243537669: Tag
    {
        private 459b4177955837a3ca6473ad97660ecf _red;
        private 0b40020952672ad3ce8bc05e00d8377e _blue;
        private a3f03d87020b5331dab76c905ba78a8e _green;

        public 4fffa26ab30c38fba0dbecd243537669(Guid id, string name): base(id, name)
        {
            this._red = new 459b4177955837a3ca6473ad97660ecf(Guid.NewGuid(), "Red", this);
            this._blue = new 0b40020952672ad3ce8bc05e00d8377e(Guid.NewGuid(), "Blue", this);
            this._green = new a3f03d87020b5331dab76c905ba78a8e(Guid.NewGuid(), "Green", this);

        }
        public 459b4177955837a3ca6473ad97660ecf Red => this._red;
        public 0b40020952672ad3ce8bc05e00d8377e Blue => this._blue;
        public a3f03d87020b5331dab76c905ba78a8e Green => this._green;

    }
}
