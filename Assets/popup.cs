using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popup : MonoBehaviour
{
    public Canvas namaCanvas; 
    public bool tampil = false;

    public void tampilPopUp()
    {
        if (tampil== false)
        {
            tampil = true;
            namaCanvas.enabled = true;
        }else if (tampil = true)
        {
            tampil = false;
            namaCanvas.enabled = false;
        }
    }
}
