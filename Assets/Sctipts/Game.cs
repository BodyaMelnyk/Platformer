using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
