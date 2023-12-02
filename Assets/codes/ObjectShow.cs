using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShow : MonoBehaviour
{
    public GameObject showObj;
    void Start()
    {
        
    }

    
    void Update()
    {
        showObj.SetActive(false);
    }
}
