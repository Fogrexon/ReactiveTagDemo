using System;

namespace ReactiveTag.Generated.Tags
{
    public class _7cc4336c95394bd9872b0c9af28c9e99: Tag
    {
        private _38aa4bd95503459485570cea852a7548 _attackboost;
        private _b3c6b086837d4063a00960290713a6e5 _defenseboost;
        private _45400c380dd94fdc94f576869f886125 _movespeedboost;

        public _7cc4336c95394bd9872b0c9af28c9e99(string id, string name, Tag parent = null): base(id, name, parent)
        {
            this._attackboost = new _38aa4bd95503459485570cea852a7548("38aa4bd95503459485570cea852a7548", "AttackBoost", this);
            this._defenseboost = new _b3c6b086837d4063a00960290713a6e5("b3c6b086837d4063a00960290713a6e5", "DefenseBoost", this);
            this._movespeedboost = new _45400c380dd94fdc94f576869f886125("45400c380dd94fdc94f576869f886125", "MoveSpeedBoost", this);

        }
        public _38aa4bd95503459485570cea852a7548 AttackBoost => this._attackboost;
        public _b3c6b086837d4063a00960290713a6e5 DefenseBoost => this._defenseboost;
        public _45400c380dd94fdc94f576869f886125 MoveSpeedBoost => this._movespeedboost;

    }
}
