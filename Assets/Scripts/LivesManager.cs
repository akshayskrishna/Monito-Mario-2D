using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour
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
            total--;
            score.text = total.ToString();

            if (total == 0)
            {
                SceneManager.LoadScene("GameOver");
            }

        }
    }
}
