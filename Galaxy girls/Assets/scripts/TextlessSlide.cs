using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextlessSlide : MonoBehaviour
{
    [SerializeField] private Image me;
    public GameObject next;
    public Animator anim;
    public bool shake = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            next.SetActive(true);
            me.enabled = false;
            if (shake)
            {
                StartCoroutine("Shake");
            }
        }
    }

    IEnumerator Shake()
    {
        anim.SetBool("Shake", true);
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("Shake", false);
    }
}
