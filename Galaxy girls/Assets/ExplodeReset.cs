using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeReset : MonoBehaviour
{
    public float posx;
    public float posy;
    public float posz;
    void OnEnable()
    {
        transform.position = new Vector3(posx, posy, posz);
    }
}
