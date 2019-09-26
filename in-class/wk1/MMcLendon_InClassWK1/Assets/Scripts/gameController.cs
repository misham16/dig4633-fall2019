using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public bool chickenHat = false;
    public GameObject cHat;

    public void ChickenHappy () 
    {
        if()
        {
            Debug.Log("Chicken is Happy");
        }
    }

    void HatRestored()
    {
        cHat.SetActive(true);
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
