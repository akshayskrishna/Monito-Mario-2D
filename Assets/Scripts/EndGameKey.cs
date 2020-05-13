using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameKey : MonoBehaviour
{
    public Collider2D col;
    public Component doortest;

    // Start is called before the first frame update
    void Start()
    {
        doortest.GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

   private void OnTriggerEnter2D(Collider2D other)
{

        if (other.gameObject.CompareTag("Key"))
        {   
            other.gameObject.SetActive(false);
            
            doortest.GetComponent<BoxCollider2D>().enabled = true;
            
            
            //doortest.GetComponent<BoxCollider>().enabled = true;
            
        }

            
    }

}
