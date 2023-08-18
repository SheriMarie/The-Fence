using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _walkSpeed;
    [SerializeField] private float _runSpeed;
    [SerializeField] private float _crouchSpeed;
    [SerializeField] private float _jumpSpeed;
    [SerializeField] private Rigidbody2D _body2D;
    float _speed;

    [SerializeField] private Vector3 _direction; //Vector3 is a struct - stoed data 
                                                 //direction.x, direction.y, direction.z


    // Start is called before the first frame update
    void Start()
    {
        _body2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float _horizontal = 0;
        //float _vertical = 0;

        _horizontal = Input.GetAxis("Horizontal");
       // _vertical = Input.GetAxis("Vertical");

        _direction.x = _horizontal;
        // //_direction.y = 0;
       // _direction.z = _vertical;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _speed = _runSpeed;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            _speed = _crouchSpeed;
        }
        else
        {
            _speed = _walkSpeed;
        }
        if (Input.GetButtonDown("Jump"))
        {
            //direction.y 
            _body2D.AddForce(new Vector2(0, _jumpSpeed),ForceMode2D.Impulse);
        }
        _body2D.velocity = new Vector2(_direction.x*_speed,_body2D.velocity.y);
        // transform.position += direction * speed * Time.deltaTime;

        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     // I have no idea hoe to get this jump working and I feel STOOPID 
        //     transform.position += new Vector3(0,0,100);

        //     //transform.position += Vector3.forward; // Vector3.forward = (0,0,1) on the transform position
        // }


        // if(Input.GetButtonDown("Jump"))
        // {
        //    //direction.y 
        // }

        // if (Input.GetKey(KeyCode.LeftControl))
        // {
        //     _speed = _crouchSpeed;
        // }

        // transform.position += _direction * _speed * Time.deltaTime;

    }
}