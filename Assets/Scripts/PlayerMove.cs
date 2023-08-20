using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;
    [SerializeField] private float crouchSpeed;

    [SerializeField] private Vector3 direction; //Vector3 is a struct - stoed data 
                                                //direction.x, direction.y, direction.z


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKeyDown("space"))
        {
            transform.position += Vector3.forward; // Vector3.forward = (0,0,1) on the transform position
        }

        //(1,0,0) + (0,-1,3) = (1,-1,3)

        float horizontal = 0;
        float vertical = 0;

        /*
         
        if (Input.GetKey("right"))
            horizontal = 1;
        if (Input.GetKey("left"))
            horizontal = -1;

        if (Input.GetKey("up"))
            vertical = 1;
        if (Input.GetKey("down"))
            vertical = -1;
        */

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        direction.x = horizontal;
        direction.y = 0;
        direction.z = vertical;

        float speed = walkSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
            speed = runSpeed;

        if (Input.GetKey(KeyCode.LeftControl))
            speed = crouchSpeed;

        transform.position += direction * speed * Time.deltaTime;
    }
}
