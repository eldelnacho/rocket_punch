using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
            {
                case "Friendly":
                    Debug.Log("This object is friendly.");
                    break;
                case "Finish":
                    Debug.Log("Congratulations, you have landed safely");
                    break;
                default:
                    Debug.Log("You crashed!");
                    ReloadLevel();
                    break;
            }
    }

    private void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

}
