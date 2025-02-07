using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    private Move playerMove;
    private ProjectileManager projectileManager;

    private Vector2 minPointLimit;
    private Vector2 maxPointLimit;
    private float xPosition;
    private float yPosition;
    void Start()
    {
        playerMove = GetComponent<Move>();
        projectileManager = GetComponent<ProjectileManager>();
        minPointLimit = new Vector2(-5.5f, -9.25f);
        maxPointLimit = new Vector2( 5.5f,  9.25f);
    }

    void Update()
    {
        Movement();
        Shooting();
    }

    private void Movement()
    {
        xPosition = transform.position.x;
        yPosition = transform.position.y;

        direction = Vector3.zero;

        if(Input.GetKey(KeyCode.A) && xPosition > minPointLimit.x) direction += new Vector3(-1,  0, 0);
        if(Input.GetKey(KeyCode.D) && xPosition < maxPointLimit.x) direction += new Vector3( 1,  0, 0);
        if(Input.GetKey(KeyCode.W) && yPosition < maxPointLimit.y) direction += new Vector3( 0,  1, 0);
        if(Input.GetKey(KeyCode.S) && yPosition > minPointLimit.y) direction += new Vector3( 0, -1, 0);

        playerMove.SetMovement(direction, speed);
    }

    private void Shooting()
    {
        if(Input.GetKeyDown(KeyCode.Space)) projectileManager.Shot();
    }
}
