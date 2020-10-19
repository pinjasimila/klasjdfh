using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D c)
    {
        // Does the other collider have the tag "Player"?
        if (c.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);

        }
    }
}
