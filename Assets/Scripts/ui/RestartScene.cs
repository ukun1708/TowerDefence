using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
   public void RetryScene()
    {
        SceneManager.LoadScene(0);
    }
}
