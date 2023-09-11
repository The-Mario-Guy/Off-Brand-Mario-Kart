using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public Vector3 offset = new Vector3(0, 1.5f, -3.3f);
    void Start()
    {
        //Forces the Player to go at 25 FPS for the true PSX experience
        Application.targetFrameRate = 25;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Tracks the Player
        transform.position = Player.transform.position + offset;
    }
}
