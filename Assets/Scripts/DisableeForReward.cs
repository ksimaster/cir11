using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableeForReward : MonoBehaviour
{

    void Update()
    {
        if (PlayerPrefs.GetInt(gameObject.name) == 1)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
           
        }
    }

    private void Start()
    {
        
    }
}
