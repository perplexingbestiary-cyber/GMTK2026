using UnityEngine;
using TarodevController;

public class PlayerSpriteFlipper : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sprite;

    private IPlayerController _player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _player = GetComponentInParent<IPlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
            HandleSpriteFlip();
            
        
    }

    private void HandleSpriteFlip()
        {
            if (_player.FrameInput.x != 0) _sprite.flipX = _player.FrameInput.x < 0;
        }
}
