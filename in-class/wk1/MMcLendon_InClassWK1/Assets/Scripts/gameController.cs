using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public bool chickenHat = false;
    public GameObject cHat;

    public void ChickenHappy () 
    {
        if (chickenHat == true)
        {
            this.cHat.SetActive(true);
            Debug.Log("Chicken is Happy");
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey (KeyCode.Alpha9))
        {
            SceneManager.LoadScene("fade");
        }
    }
}
