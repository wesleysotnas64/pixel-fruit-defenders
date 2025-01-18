using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    private Move playerMove;
    void Start()
    {
        playerMove = GetComponent<Move>();
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        direction = Vector3.zero;
        
        // if(Input.GetKey(KeyCode.W)) direction += new Vector3( 0,  1, 0);
        // if(Input.GetKey(KeyCode.S)) direction += new Vector3( 0, -1, 0);
        if(Input.GetKey(KeyCode.A)) direction += new Vector3(-1,  0, 0);
        if(Input.GetKey(KeyCode.D)) direction += new Vector3( 1,  0, 0);

        playerMove.SetMovement(direction, speed);
    }
}
