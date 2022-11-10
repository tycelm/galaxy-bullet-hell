using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AttemptsDoor : MonoBehaviour
{
    public TextMeshProUGUI one;
    // Start is called before the first frame update
    void Start()
    {
        PlayerData me = SaveSystem.LoadPlayer();
        one.text = me.one.ToString();
    }
}
