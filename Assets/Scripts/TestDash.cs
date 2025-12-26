using UnityEngine;
using MoreMountains.CorgiEngine;

public class TestDash : CharacterDash
{
    [Header("Extras")]
    [SerializeField] private CorgiController _overridedController;
    [SerializeField] private Character _characterNavigation;


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

    private void Update()
    {
        if (_characterNavigation)
        {
            _character.IsFacingRight = _characterNavigation.IsFacingRight;

            //Debug.Log(_character.IsFacingRight);
        }
    }
}
