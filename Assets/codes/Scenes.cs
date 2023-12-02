using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    private int objectsInactive = 15;
    private int oldRRR;
    private bool objectsInact;

    public void increment()
    {
        objectsInactive++;
    }

    public void decrement()
    {
        objectsInactive--;
        
    }

    public bool isAmount(){
        return objectsInactive > 0;
    }

    private void Update() 
    {
        if (oldRRR != objectsInactive)
        {
            oldRRR = objectsInactive;
            Debug.Log("New scope: " + objectsInactive);
            if (objectsInactive < 1)
            {
                openScene3();
            }
        }
    }

    private void openScene3()
    {
        SceneManager.LoadScene(2);
    }
}
