using UnityEngine;
using MoreMountains.CorgiEngine;

public class TestHorizontalMove : CharacterHorizontalMovement
{
    [SerializeField] private CorgiController _overridedController;

    protected override void Initialization()
    {
        base.Initialization();
        if (_overridedController != null)
        {
            _controller = _overridedController;
        }
    }
}
