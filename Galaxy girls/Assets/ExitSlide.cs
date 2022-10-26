using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitSlide : MonoBehaviour
{
    public Animator anim;
    public Image blac;
    public int scene;
    void OnEnable()
    {
        StartCoroutine("Leave");
    }

    IEnumerator Leave()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => blac.color.a == 1);
        SceneManager.LoadScene(scene);
    }
}
