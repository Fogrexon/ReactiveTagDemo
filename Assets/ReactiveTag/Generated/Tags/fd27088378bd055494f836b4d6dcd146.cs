using System;

namespace ReactiveTag.Generated.Tags
{
    public class fd27088378bd055494f836b4d6dcd146: Tag
    {
        private 0f47cb052d3f540e7460ec925573cb06 _ball;
        private f7f0ebeb9984ea86b85b21c8377c628c _cube;

        public fd27088378bd055494f836b4d6dcd146(Guid id, string name): base(id, name)
        {
            this._ball = new 0f47cb052d3f540e7460ec925573cb06(Guid.NewGuid(), "Ball", this);
            this._cube = new f7f0ebeb9984ea86b85b21c8377c628c(Guid.NewGuid(), "Cube", this);

        }
        public 0f47cb052d3f540e7460ec925573cb06 Ball => this._ball;
        public f7f0ebeb9984ea86b85b21c8377c628c Cube => this._cube;

    }
}
