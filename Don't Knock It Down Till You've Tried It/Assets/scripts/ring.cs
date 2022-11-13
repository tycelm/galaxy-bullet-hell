using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ring : MonoBehaviour
{
    public int x;
    public float posx;
    public float posy;
    public float posz;

    void OnEnable()
    {
        transform.position = new Vector3(posx, posy, posz);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * x * Time.deltaTime);
    }
}
