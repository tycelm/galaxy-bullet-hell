using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AttemptDisplayer : MonoBehaviour
{
    public TextMeshProUGUI dialog;

    // Start is called before the first frame update
    void Start()
    {
        PlayerData me = SaveSystem.LoadPlayer();
        int current = SceneManager.GetActiveScene().buildIndex;
        int attempt;

        if (current == 3)
        {
            attempt = me.one;
        }
        else
        {
            attempt = 404;
        }
        // same as save, got only one level rn


        dialog.text = $"Attempt {attempt}";
    }
}
