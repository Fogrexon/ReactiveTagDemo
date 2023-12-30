using System;

namespace ReactiveTag.Generated.Tags
{
    public class _4fffa26ab30c38fba0dbecd243537669: Tag
    {
        private _459b4177955837a3ca6473ad97660ecf _red;
        private _0b40020952672ad3ce8bc05e00d8377e _blue;
        private _a3f03d87020b5331dab76c905ba78a8e _green;

        public _4fffa26ab30c38fba0dbecd243537669(Guid id, string name, Tag parent = null): base(id, name, parent)
        {
            this._red = new _459b4177955837a3ca6473ad97660ecf(Guid.NewGuid(), "Red", this);
            this._blue = new _0b40020952672ad3ce8bc05e00d8377e(Guid.NewGuid(), "Blue", this);
            this._green = new _a3f03d87020b5331dab76c905ba78a8e(Guid.NewGuid(), "Green", this);

        }
        public _459b4177955837a3ca6473ad97660ecf Red => this._red;
        public _0b40020952672ad3ce8bc05e00d8377e Blue => this._blue;
        public _a3f03d87020b5331dab76c905ba78a8e Green => this._green;

    }
}
