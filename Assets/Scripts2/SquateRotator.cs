using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquateRotator : MonoBehaviour
{
    [SerializeField] private Vector2 _positionB;

    private void Update()
    {
        transform.position = Vector2.Lerp(transform.position, _positionB, 5 * Time.deltaTime);
        transform.Rotate(0, 0, 360 * 6 * Time.deltaTime);  
    }
}
