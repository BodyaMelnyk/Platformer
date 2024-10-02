using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private void Update()
    {
        transform.position = new Vector3(_player.position.x, _player.position.y, transform.position.z);
    }
}
