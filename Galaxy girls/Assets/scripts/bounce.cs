using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D m_Rigidbody2D;
    public int x;
    public float posx;
    public float posy;
    public float posz;
    public int jump;

    void OnEnable()
    {
        transform.position = new Vector3(posx, posy, posz);
    }

    void Update()
    {
        transform.Translate(Vector3.left * x * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("bouncedry"))
        {
            m_Rigidbody2D.AddForce(new Vector2(0f, jump));
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("bouncedry"))
        {
            m_Rigidbody2D.AddForce(new Vector2(0f, jump));
        }
    }
}
