using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Invoke("ReloadScene",2f);
        }
        
    }

    void ReloadScene()
    {
        Debug.Log("Ganaste");
        SceneManager.LoadScene(0);
    }
}
