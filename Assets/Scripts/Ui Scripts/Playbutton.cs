using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playbutton : MonoBehaviour
{

    public void play()
    {
        SceneManager.LoadScene("1");
    }
}
