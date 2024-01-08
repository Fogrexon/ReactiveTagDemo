using System;

namespace ReactiveTag.Generated.Tags
{
    public class _0a4e1a9db3db49869a9032084bbdf1e0: Tag
    {
        private _df22bbccecbd4ebfa253f0525c7a8384 _enemy;
        private _a5f84ef6a96e4ab999ff938712ee0f00 _player;

        public _0a4e1a9db3db49869a9032084bbdf1e0(string id, string name, Tag parent = null): base(id, name, parent)
        {
            this._enemy = new _df22bbccecbd4ebfa253f0525c7a8384("df22bbccecbd4ebfa253f0525c7a8384", "Enemy", this);
            this._player = new _a5f84ef6a96e4ab999ff938712ee0f00("a5f84ef6a96e4ab999ff938712ee0f00", "Player", this);

        }
        public _df22bbccecbd4ebfa253f0525c7a8384 Enemy => this._enemy;
        public _a5f84ef6a96e4ab999ff938712ee0f00 Player => this._player;

    }
}
