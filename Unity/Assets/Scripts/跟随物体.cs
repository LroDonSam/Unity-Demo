using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 跟随物体 : MonoBehaviour
{
    private new Transform transform;
    public Transform 目标;
    private Vector3 distance;

    void Start()
    {
        transform = GetComponent<Transform>();
        distance = 目标.position - transform.position;
    }
    
    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.position = 目标.position - distance;
    }
}
