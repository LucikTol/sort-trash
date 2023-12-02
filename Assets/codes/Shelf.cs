using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{
    public GameObject obj;
    public GameObject showObj;

    void Start()
    {
        
    }

    void Update()
    {

        
        

    }

    public void onClick()
    {
        obj.SetActive(false);

        showObj.SetActive(true);
    }
}
