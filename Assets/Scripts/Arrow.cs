using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private MoveForward moveForwardScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>(); 
        moveForwardScript = this.GetComponent<MoveForward>();
        //Arrow 
        moveForwardScript.speed = playerControllerScript.ArrowSpeed;
    }

    
    void Update()
    {
        
    }
}
