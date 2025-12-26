using UnityEngine;
using MoreMountains.CorgiEngine;

public class TestCharacter : Character
{
    [SerializeField] private CorgiController _overridedController;

    protected override void Awake()
    {
        base.Awake();
        _overridedController = GetComponentInParent<CorgiController>();
    }

    public override void Initialization()
    {
        base.Initialization();
        if (_overridedController != null)
        {
            _controller = _overridedController;
        }

        if (_controller != null)
            _originalGravity = _controller.Parameters.Gravity;
    }

    
}
