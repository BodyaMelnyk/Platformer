using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquateRotator : MonoBehaviour
{

    private void Update()
    {
        transform.Rotate(0, 0, 360 * 6 * Time.deltaTime);  
    }
}
