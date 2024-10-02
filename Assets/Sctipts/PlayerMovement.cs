using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider2D))]  
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _speed;
    [SerializeField] private LayerMask _jumpableGroundMask;
    [SerializeField] private AudioSource _jumpSoundEffect;

    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private float _directionX = 0f;
    private BoxCollider2D _boxCollider;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        HorizontalMove();
        Jump();
    }

    private void HorizontalMove()
    {
        _directionX = Input.GetAxisRaw("Horizontal");
        _rigidbody2D.velocity = new Vector2(_directionX * _speed, _rigidbody2D.velocity.y);

        UpdateAnimationStates();
    }
    
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, _jumpForce);
            _jumpSoundEffect.Play();
        }
    }

    private void UpdateAnimationStates()
    {
        MovementState state;

        _spriteRenderer.flipX = _directionX < 0f ? true : false;

        if (_directionX > 0f || _directionX < 0f)
            state = MovementState.Run;

        else
            state = MovementState.Idle;


        if (_rigidbody2D.velocity.y > 0.1f)
            state = MovementState.Jump;

        if (_rigidbody2D.velocity.y < -0.1f)
            state = MovementState.Fall;

        _animator.SetInteger("State", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(_boxCollider.bounds.center, _boxCollider.bounds.size, 0f, Vector2.down, 0.1f, _jumpableGroundMask);
    }

}
 