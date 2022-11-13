using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public float posx;
    public float posy;
    public float posz;
    private float sec = 0.4f;

        void OnEnable()
    {
        left.transform.position = new Vector3(posx, posy, posz);
        right.transform.position = new Vector3(posx, posy, posz);
        StartCoroutine("Leave");
    }

    // Update is called once per frame
    void Update()
    {
        left.transform.Translate(Vector3.left * 15 * Time.deltaTime);
        right.transform.Translate(Vector3.right * 12 * Time.deltaTime);
    }

    IEnumerator Leave()
    {
        yield return new WaitForSeconds(sec);
        gameObject.SetActive(false);
    }
}
