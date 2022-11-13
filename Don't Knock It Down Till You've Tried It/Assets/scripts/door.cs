using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    [SerializeField] private Image customImage;
    public Animator anim;
    public Image blac;
    public int scene;
    public GameObject open;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            open.SetActive(true);
            customImage.enabled = true;
            if (Input.GetKey(KeyCode.Return))
            {
                StartCoroutine("Leave");
            }
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            open.SetActive(true);
            customImage.enabled = true;
            if (Input.GetKey(KeyCode.Return))
            {
                StartCoroutine("Leave");    
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            open.SetActive(false);
            customImage.enabled = false;
        }
    }

    IEnumerator Leave()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => blac.color.a == 1);
        SceneManager.LoadScene(scene);
    }

}