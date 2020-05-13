using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeysCollected : MonoBehaviour
{

    public Text keycheck;
    string status;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Key"))
        {
            status = "Collected";
            keycheck.text = status.ToString();

        }


    }
        }
