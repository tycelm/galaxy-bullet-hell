using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stats : MonoBehaviour
{
    public int lives = 3;
    public GameObject Over;
    private bool grace;
    public Animator life;
    public Animator animator;
    public Animator cam;
    public GameObject modeDisplay;
    public TextMeshProUGUI dialog;
    public AudioLowPassFilter sound;
    private PlayerData me;
    private int current;
    private bool gooseworx;

    void Start()
    {
        modeDisplay.SetActive(false);
        me = SaveSystem.LoadPlayer();
        current = SceneManager.GetActiveScene().buildIndex;
        gooseworx = me.gooseworx;
        life.SetBool("god", gooseworx);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            gooseworx = me.ToggleGooseworx(!gooseworx);
            SaveSystem.SavePlayer(me);
            dialog.text = $"Gooseworx mode: {gooseworx}";
            modeDisplay.SetActive(true);
            life.SetBool("god", gooseworx);
            StartCoroutine("Toggle");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("hurty"))
        {
            if (!grace)
            {
                sound.enabled = true;
                animator.SetBool("hurt", true);
                StartCoroutine("Shake");
                if (!gooseworx)
                {
                    lives -= 1;
                    life.SetInteger("Life",lives);
                }
                else
                {
                    life.SetTrigger("hurt");
                }
                if (lives == 0)
                {
                    // to be fully implemented ltr
                    // play anim then removes player from scene

                    // used to increase attempt count
                    updateAttempts();
                    Over.SetActive(true); // delay this when i have the anim
                }
                grace = true;
                StartCoroutine("Grace");
            }
        }
    }

    public void updateAttempts()
    {

        // other scenes unknown so i only got level 1
        if (current == 3)
        {
            me.one += 1;
            SaveSystem.SavePlayer(me);
        }
        else
        {
            Debug.LogError("imagine not being able to count");
        }
    }

    IEnumerator Grace()
    {
        yield return new WaitForSeconds(2);
        sound.enabled = false;
        grace = false;
    }

    IEnumerator Shake()
    {
        cam.SetBool("Shake", true);
        yield return new WaitForSeconds(0.1f);
        cam.SetBool("Shake", false);
        animator.SetBool("hurt", false);
    }

    IEnumerator Toggle()
    {
        yield return new WaitForSeconds(2);
        modeDisplay.SetActive(false);
    }
}
