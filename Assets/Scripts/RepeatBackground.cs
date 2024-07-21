using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    public GameObject ground;
    void Start()
    {
        startPos = transform.position;
        repeatWidth = ground.transform.localScale.z * 10 / 2;
    }

    
    void Update()
    {
        if(transform.position.z < startPos.z - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
