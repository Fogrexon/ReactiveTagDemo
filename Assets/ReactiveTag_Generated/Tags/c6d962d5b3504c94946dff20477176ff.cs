using System;

namespace ReactiveTag.Generated.Tags
{
    public class _c6d962d5b3504c94946dff20477176ff: Tag
    {
        private _ae7d849b8809481aa566fe2979b18384 _wall;
        private _ca25db537b2449cfb28001ad6fd85fc2 _floor;

        public _c6d962d5b3504c94946dff20477176ff(string id, string name, Tag parent = null): base(id, name, parent)
        {
            this._wall = new _ae7d849b8809481aa566fe2979b18384("ae7d849b8809481aa566fe2979b18384", "Wall", this);
            this._floor = new _ca25db537b2449cfb28001ad6fd85fc2("ca25db537b2449cfb28001ad6fd85fc2", "Floor", this);

        }
        public _ae7d849b8809481aa566fe2979b18384 Wall => this._wall;
        public _ca25db537b2449cfb28001ad6fd85fc2 Floor => this._floor;

    }
}
