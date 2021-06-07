using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// give this script to a empty object
//select R as a input 

public class restart_with_R : MonoBehaviour
{
    [SerializeField]
    KeyCode keyrestart;
    void RestartLevel() //Restarts the level
{
    if (Input.GetKey(keyrestart))
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  	 
}
}
