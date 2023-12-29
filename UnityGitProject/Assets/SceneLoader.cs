using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    
        public void LoadScene1()
        {
            SceneManager.LoadScene("Scene1");
        Debug.Log("button s1 Pressed");

    }

    public void LoadScene2()
        {
            SceneManager.LoadScene("Scene2");
        Debug.Log("button s2 Pressed");

    }

}
