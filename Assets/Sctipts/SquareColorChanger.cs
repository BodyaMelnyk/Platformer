using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareColorChanger : MonoBehaviour
{
    private SpriteRenderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        _renderer.color = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
        transform.position = new Vector2(1f, 1f);
    }



}
