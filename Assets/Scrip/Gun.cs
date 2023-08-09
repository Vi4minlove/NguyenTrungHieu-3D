using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform _spawn;
    public void Shoot()
    {
        Ray ray = new Ray(_spawn.position, _spawn.forward);
        RaycastHit hit;
        float _shotDistance = 20;
        if (Physics.Raycast(ray, out hit, _shotDistance))
        {
            _shotDistance = hit.distance;
        }
        Debug.DrawRay(ray.origin, ray.direction * _shotDistance, Color.red, 1);
    }
}
