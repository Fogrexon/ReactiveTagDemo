using System;

namespace ReactiveTag.Generated.Tags
{
    public class _8195fdf0fca645ca88bbe5b9c6309b3f: Tag
    {
        private _64879560153b421ca413550913622b3c _dynamic;
        private _c6d962d5b3504c94946dff20477176ff _static;
        private _6128e44741cb4ec882f16c98f6694953 _manager;
        private _b94286b90f744b9da0f9747fc50979c5 _effect;

        public _8195fdf0fca645ca88bbe5b9c6309b3f(string id, string name, Tag parent = null): base(id, name, parent)
        {
            this._dynamic = new _64879560153b421ca413550913622b3c("64879560153b421ca413550913622b3c", "Dynamic", this);
            this._static = new _c6d962d5b3504c94946dff20477176ff("c6d962d5b3504c94946dff20477176ff", "Static", this);
            this._manager = new _6128e44741cb4ec882f16c98f6694953("6128e44741cb4ec882f16c98f6694953", "Manager", this);
            this._effect = new _b94286b90f744b9da0f9747fc50979c5("b94286b90f744b9da0f9747fc50979c5", "Effect", this);

        }
        public _64879560153b421ca413550913622b3c Dynamic => this._dynamic;
        public _c6d962d5b3504c94946dff20477176ff Static => this._static;
        public _6128e44741cb4ec882f16c98f6694953 Manager => this._manager;
        public _b94286b90f744b9da0f9747fc50979c5 Effect => this._effect;

    }
}
