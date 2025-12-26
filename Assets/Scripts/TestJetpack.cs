using UnityEngine;
using MoreMountains.CorgiEngine;

public class TestJetpack : CharacterJetpack
{
    [SerializeField] private CorgiController _overridedController;

    private void Awake()
    {
        _overridedController = GetComponentInParent<CorgiController>();
    }
    protected override void Initialization()
    {
        base.Initialization();
        if (_overridedController != null)
        {
            _controller = _overridedController;
        }
    }
}
