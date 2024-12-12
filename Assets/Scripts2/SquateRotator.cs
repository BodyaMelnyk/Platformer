using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquateRotator : MonoBehaviour
{
    [SerializeField] private Vector2 _positionB;

    private void Update()
    {
        transform.Rotate(0, 0, 360 * 6 * Time.deltaTime);  
    }
}
