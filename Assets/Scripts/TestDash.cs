using UnityEngine;
using MoreMountains.CorgiEngine;

public class TestDash : CharacterDash
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
