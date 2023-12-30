using System;

namespace ReactiveTag.Generated.Tags
{
    public class _fd27088378bd055494f836b4d6dcd146: Tag
    {
        private _0f47cb052d3f540e7460ec925573cb06 _ball;
        private _f7f0ebeb9984ea86b85b21c8377c628c _cube;

        public _fd27088378bd055494f836b4d6dcd146(Guid id, string name, Tag parent = null): base(id, name, parent)
        {
            this._ball = new _0f47cb052d3f540e7460ec925573cb06(Guid.NewGuid(), "Ball", this);
            this._cube = new _f7f0ebeb9984ea86b85b21c8377c628c(Guid.NewGuid(), "Cube", this);

        }
        public _0f47cb052d3f540e7460ec925573cb06 Ball => this._ball;
        public _f7f0ebeb9984ea86b85b21c8377c628c Cube => this._cube;

    }
}
