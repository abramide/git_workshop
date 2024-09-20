using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("WinScreen");
        }
    }
}