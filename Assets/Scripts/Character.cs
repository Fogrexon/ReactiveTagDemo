using ReactiveTag.Generated.Tags;
using UnityEngine;

public class Character: MonoBehaviour{
    public void OnTagAttach()
    {
        throw new System.NotImplementedException();
    }

    public void OnTagDetach()
    {
        throw new System.NotImplementedException();
    }

    public void Awake()
    {
        
        var tag = ReactiveTagRoot.Root.Dynamic.Parent;
        
        
    }
}