using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cek_1 : MonoBehaviour
{
    float x, y;

    public string scenename;

    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
