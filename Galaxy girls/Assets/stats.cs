using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stats : MonoBehaviour
{
    public int lives = 3;
    public int scene;
    private bool grace;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("hurty"))
        {
            if (!grace)
            {
                Debug.Log("Owie!");
                Debug.Log(lives);
                lives -= 1;
                if (lives == 0)
                {
                    // to be fully implemented ltr
                    SceneManager.LoadScene(scene);
                }
                grace = true;
                StartCoroutine("Grace");
            }
        }
    }

    IEnumerator Grace()
    {
        yield return new WaitForSeconds(2);
        grace = false;
    }
}
