using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator), typeof(Rigidbody2D))]
public class PlayerLife : MonoBehaviour
{
    [SerializeField] private AudioSource _deathSoundEffect;

    private Animator _animator;
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Trap component))
            Die();
    }

    private void Die()
    {
        _animator.SetTrigger("Death");
        _rigidbody2D.bodyType = RigidbodyType2D.Static;
        _deathSoundEffect.Play();
    }

}
