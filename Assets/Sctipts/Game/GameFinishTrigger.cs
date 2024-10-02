using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))] 
public class GameFinishTrigger : MonoBehaviour
{
    private AudioSource _finishSound;
    private bool _isLevelFinished = false;

    private void Start()
    {
        _finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player) && _isLevelFinished == false)
        {
            _isLevelFinished = true;
            StartCoroutine(CompleteLevel());
        }
    }

    private IEnumerator CompleteLevel()
    {
        _finishSound.Play();

        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(2);
    }
}
