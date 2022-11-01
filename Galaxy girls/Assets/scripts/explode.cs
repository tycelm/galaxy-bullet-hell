using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;
    public GameObject g;
    public GameObject h;
    public GameObject origin;
    public float speed;

    // Start is called before the first frame update
    void OnEnable()
    {
        Vector3 pos = origin.transform.position;
        a.transform.position = b.transform.position = c.transform.position = d.transform.position =
            e.transform.position = f.transform.position = g.transform.position = h.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        a.transform.Translate(Vector3.up * speed * Time.deltaTime);
        b.transform.Translate(Vector3.right * speed * Time.deltaTime);
        b.transform.Translate(Vector3.up * speed * Time.deltaTime);
        c.transform.Translate(Vector3.right * speed * Time.deltaTime);
        d.transform.Translate(Vector3.right * speed * Time.deltaTime);
        d.transform.Translate(Vector3.down * speed * Time.deltaTime);
        e.transform.Translate(Vector3.down * speed * Time.deltaTime);
        f.transform.Translate(Vector3.down * speed * Time.deltaTime);
        f.transform.Translate(Vector3.left * speed * Time.deltaTime);
        g.transform.Translate(Vector3.left * speed * Time.deltaTime);
        h.transform.Translate(Vector3.left * speed * Time.deltaTime);
        h.transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
