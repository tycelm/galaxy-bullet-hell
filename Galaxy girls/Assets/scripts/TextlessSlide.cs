using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextlessSlide : MonoBehaviour
{
    public DialogueDisplay DialogMsg;
    [SerializeField] private Image me;
    [SerializeField] private Image next;

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            if (DialogMsg != null)
            {
                DialogMsg.enabled = true;
            }
            next.enabled = true;
            me.enabled = false;
        }
    }
}
