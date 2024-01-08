using System;

namespace ReactiveTag.Generated.Tags
{
    public class _64879560153b421ca413550913622b3c: Tag
    {
        private _0a4e1a9db3db49869a9032084bbdf1e0 _character;
        private _952be7b8be3f45a588ca6ac14b6a5919 _effecter;
        private _c06640166e7f45b5a2c0ba752dac6f59 _mover;

        public _64879560153b421ca413550913622b3c(string id, string name, Tag parent = null): base(id, name, parent)
        {
            this._character = new _0a4e1a9db3db49869a9032084bbdf1e0("0a4e1a9db3db49869a9032084bbdf1e0", "Character", this);
            this._effecter = new _952be7b8be3f45a588ca6ac14b6a5919("952be7b8be3f45a588ca6ac14b6a5919", "Effecter", this);
            this._mover = new _c06640166e7f45b5a2c0ba752dac6f59("c06640166e7f45b5a2c0ba752dac6f59", "Mover", this);

        }
        public _0a4e1a9db3db49869a9032084bbdf1e0 Character => this._character;
        public _952be7b8be3f45a588ca6ac14b6a5919 Effecter => this._effecter;
        public _c06640166e7f45b5a2c0ba752dac6f59 Mover => this._mover;

    }
}
