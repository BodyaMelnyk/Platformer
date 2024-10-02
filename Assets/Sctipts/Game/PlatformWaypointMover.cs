using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformWaypointMover : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed = 2f;

    private int _currentWaypointIndex = 0;
    private float _minPermissibleDistance = 0.1f;

    private void Update()   
    {
        if (Vector2.Distance(_waypoints[_currentWaypointIndex].position, transform.position) < _minPermissibleDistance)
        {
            _currentWaypointIndex++;
            if (_currentWaypointIndex >= _waypoints.Length)
            {   
                _currentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, _waypoints[_currentWaypointIndex].position, _speed * Time.deltaTime);
    }
}
