using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        string tag = other.gameObject.tag;

        switch (tag)
        {
            case "Start":
                Debug.Log("Start collide");
                break;
            case "Finish":
                Debug.Log("Finish collide");
                break;
            case "Fuel":
                Debug.Log("Fuel up");
                break;
            default:
                ReloadLevel();
                break;    
        }
    }

    void ReloadLevel() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
