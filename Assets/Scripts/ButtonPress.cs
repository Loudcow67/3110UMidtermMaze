using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour
{
    public void NewScene()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
