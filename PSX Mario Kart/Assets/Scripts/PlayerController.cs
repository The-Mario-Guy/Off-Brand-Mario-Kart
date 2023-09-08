using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private int speed = 8;
    private float turnSpeed = 100;
    private float _horizontalInput;
    private float _verticalInput;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        //Moves da car
        transform.Translate(Vector3.forward * speed * _verticalInput * Time.deltaTime);
        //da turn
        transform.Rotate(Vector3.up, turnSpeed * _horizontalInput * Time.deltaTime);
    }
}
