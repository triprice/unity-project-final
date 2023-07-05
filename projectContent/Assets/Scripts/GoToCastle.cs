using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToCastle : MonoBehaviour
{
    private int diamonds = 0;   

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.tag);

        if (other.transform.tag == "ending")
        {
            SceneManager.LoadScene(1);
        }
    }
}
