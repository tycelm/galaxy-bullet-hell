﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stats : MonoBehaviour
{
    public int lives = 3;
    public int scene;
    private bool grace;
    public Animator animator;
    public Animator cam;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("hurty"))
        {
            if (!grace)
            {
                animator.SetBool("hurt", true);
                StartCoroutine("Shake");
                lives -= 1;
                if (lives == 0)
                {
                    // to be fully implemented ltr
                    SceneManager.LoadScene(scene);
                }
                grace = true;
                StartCoroutine("cancelAnim");
                StartCoroutine("Grace");
            }
        }
    }

    IEnumerator cancelAnim()
    {
        yield return new WaitForSeconds(0.01f);
        animator.SetBool("hurt", false);
    }

    IEnumerator Grace()
    {
        yield return new WaitForSeconds(2);
        grace = false;
    }

    IEnumerator Shake()
    {
        cam.SetBool("Shake", true);
        yield return new WaitForSeconds(0.1f);
        cam.SetBool("Shake", false);
    }
}
