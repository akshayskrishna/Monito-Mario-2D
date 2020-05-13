using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        Vector3 pos = transform.position;

        if (target.position.x < 0)
            return;
        

        
        else
        {
            
            pos.x = target.position.x;
            pos.y = target.position.y;
        }

        

        transform.position = pos;
    }
}
