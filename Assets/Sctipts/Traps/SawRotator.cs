using UnityEngine;

public class SawRotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private int _rotationDegrees = 360;

    private void Update()
    {
        transform.Rotate(transform.rotation.y, transform.rotation.y, _rotationDegrees * _speed * Time.deltaTime);
    }
}
