using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommetController : MonoBehaviour
{
    public GameObject wave;
    public float posx;
    public float posy;
    public float posz;

    void OnEnable()
    {
        transform.position = new Vector3(posx, posy, posz);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("floor"))
        {
            wave.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("floor"))
        {
            wave.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
