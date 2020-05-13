using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    public Text score;
    int total = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = transform.Find("Target").position;

            if (total == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
            else { 
            total--;
            score.text = total.ToString();
            }

        }
    }

}
