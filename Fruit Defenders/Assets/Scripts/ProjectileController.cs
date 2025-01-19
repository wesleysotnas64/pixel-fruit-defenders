using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{

    public float speed;
    

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.Translate(0, Time.deltaTime * speed, 0);
    }

    public void SetProjectilDirection(Vector3 _direction)
    {
        _direction.z = 0;
        transform.up = _direction.normalized;
    }
}
