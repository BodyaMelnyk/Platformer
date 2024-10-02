using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private AudioSource _collectSoundEffect;

    public event UnityAction<int> ItemCollected;

    private int _cherriesCount = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Cherry cherry))
        {
            _collectSoundEffect.Play();
            Destroy(collision.gameObject);
            _cherriesCount++;
            ItemCollected?.Invoke(_cherriesCount);
        }   
    }
}
