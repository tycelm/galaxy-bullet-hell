using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public GameObject original;
    public GameObject drop;
    private float sec = 0.5f;

    void OnEnable()
    {
        StartCoroutine("Leave");
    }

    // Update is called once per frame
    void Update()
    {
        left.transform.Translate(Vector3.left * 17 * Time.deltaTime);
        right.transform.Translate(Vector3.right * 10 * Time.deltaTime);
    }

    IEnumerator Leave()
    {
        yield return new WaitForSeconds(sec);
        Debug.Log("raeched");
        gameObject.SetActive(false);
    }
}
