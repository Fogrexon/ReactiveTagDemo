using System;

namespace ReactiveTag.Generated.Tags
{
    public class _b94286b90f744b9da0f9747fc50979c5: Tag
    {
        private _6ff8b6157a34441faffcdfc640975e23 _status;
        private _6618891255334eb087f8f03fa2bf21cc _visual;

        public _b94286b90f744b9da0f9747fc50979c5(string id, string name, Tag parent = null): base(id, name, parent)
        {
            this._status = new _6ff8b6157a34441faffcdfc640975e23("6ff8b6157a34441faffcdfc640975e23", "Status", this);
            this._visual = new _6618891255334eb087f8f03fa2bf21cc("6618891255334eb087f8f03fa2bf21cc", "Visual", this);

        }
        public _6ff8b6157a34441faffcdfc640975e23 Status => this._status;
        public _6618891255334eb087f8f03fa2bf21cc Visual => this._visual;

    }
}
