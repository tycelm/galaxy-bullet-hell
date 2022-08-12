using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommetController : MonoBehaviour
{
    public GameObject wave;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("floor"))
        {
            Debug.Log("felt it");
            wave.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("floor"))
        {
            Debug.Log("felt it");
            wave.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
