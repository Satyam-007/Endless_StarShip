using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class maze : MonoBehaviour
{
    public void sceneChange()
    {
        SceneManager.LoadScene(1);
    }
}
