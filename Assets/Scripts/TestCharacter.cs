using UnityEngine;
using MoreMountains.CorgiEngine;

public class TestCharacter : Character
{
    [SerializeField] private CorgiController _overridedController;

    public override void Initialization()
    {
        base.Initialization();
        if (_overridedController != null)
        {
            _controller = _overridedController;
        }
    }

}
