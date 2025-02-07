using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed;
    private Vector3 direction;

    void Update()
    {
        Move2D();
    }

    private void Move2D()
    {
        if(direction != Vector3.zero)
        {
            transform.position += Time.deltaTime * speed * direction;
        }
    }

    public void SetMovement(Vector3 _direction, float _speed)
    {
        _direction.z = 0.0f;
        direction = _direction.normalized;
        speed = _speed;
    }
}
