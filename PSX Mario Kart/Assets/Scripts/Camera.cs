using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public Vector3 offset = new Vector3(0, 1.5f, -3.3f);
    //public float speedMod = 10.0f;
   // private Vector3 point;
    void Start()
    {
        //Forces the Player to go at 25 FPS for the true PSX experience
        Application.targetFrameRate = 25;
       // point = Player.transform.position;
        //transform.LookAt(point);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Tracks the Player
         transform.position = Player.transform.position + offset;
        //transform.RotateAround(object.transform.position, Vector3.up, speedMod * Time.deltaTime);
    }
}
