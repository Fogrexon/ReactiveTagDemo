using System;

namespace ReactiveTag.Generated.Tags
{
    public class _6ff8b6157a34441faffcdfc640975e23: Tag
    {
        private _7cc4336c95394bd9872b0c9af28c9e99 _passive;
        private _04f6e693bd674433adf90707bd850655 _trigger;

        public _6ff8b6157a34441faffcdfc640975e23(string id, string name, Tag parent = null): base(id, name, parent)
        {
            this._passive = new _7cc4336c95394bd9872b0c9af28c9e99("7cc4336c95394bd9872b0c9af28c9e99", "Passive", this);
            this._trigger = new _04f6e693bd674433adf90707bd850655("04f6e693bd674433adf90707bd850655", "Trigger", this);

        }
        public _7cc4336c95394bd9872b0c9af28c9e99 Passive => this._passive;
        public _04f6e693bd674433adf90707bd850655 Trigger => this._trigger;

    }
}
