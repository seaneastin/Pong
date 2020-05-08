using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;


/**
 * this will load the specified scene
 */
public class SceneLoadingBehavior : MonoBehaviour
{
   public void loadScene(int scenenumber)
    {
        SceneManager.LoadScene(scenenumber);
    }
}
