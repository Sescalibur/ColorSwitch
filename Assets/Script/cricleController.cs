using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cricleController : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    [SerializeField] bool leftRotate = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (leftRotate)
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

    }
    
}
