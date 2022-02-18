using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform Ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,Ball.position.y,transform.position.z);
        }
    }
}
