using System;

namespace ReactiveTag.Generated.Tags
{
    public class ac0199131a55d40c098f9c03af1ceaac: Tag
    {
        private 5aba37183bc4b3b8a8add1cabd66b1e7 _red;
        private fb1956e2e4f839d72e33ffae923b9647 _blue;
        private 6ddb0c3dd237406dcabf4c5e42fb25fc _green;

        public ac0199131a55d40c098f9c03af1ceaac(Guid id, string name): base(id, name)
        {
            this._red = new 5aba37183bc4b3b8a8add1cabd66b1e7(Guid.NewGuid(), "Red", this);
            this._blue = new fb1956e2e4f839d72e33ffae923b9647(Guid.NewGuid(), "Blue", this);
            this._green = new 6ddb0c3dd237406dcabf4c5e42fb25fc(Guid.NewGuid(), "Green", this);

        }
        public 5aba37183bc4b3b8a8add1cabd66b1e7 Red => this._red;
        public fb1956e2e4f839d72e33ffae923b9647 Blue => this._blue;
        public 6ddb0c3dd237406dcabf4c5e42fb25fc Green => this._green;

    }
}
