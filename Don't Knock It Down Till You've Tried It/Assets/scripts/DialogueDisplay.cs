using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueDisplay : MonoBehaviour
{
    public Conversations conversation;

    public GameObject speakerLeft;
    public GameObject speakerRight;
    public GameObject nextTextless;
    public float sec;
    private SpeakerUI speakerUILeft;
    private SpeakerUI speakerUIRight;

    private int activeLineIndex = 0;

    void Start()
    {
        speakerUILeft = speakerLeft.GetComponent<SpeakerUI>();
        speakerUIRight = speakerRight.GetComponent<SpeakerUI>();
        
        speakerUILeft.Speaker = conversation.speakerLeft;
        speakerUIRight.Speaker = conversation.speakerRight;
        AdvanceConversation();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            AdvanceConversation();
        }
    }
    
    void AdvanceConversation()
    {
        if (activeLineIndex < conversation.lines.Length)
        {
            DisplayLine();
            activeLineIndex += 1;
        }
        else
        {
            activeLineIndex = 0;
            speakerUILeft.Hide();
            speakerUIRight.Hide();
            nextTextless.SetActive(true);
            enabled = false;
        }

        void DisplayLine()
        {
            Line line = conversation.lines[activeLineIndex];
            Character character = line.character;

            if(speakerUILeft.SpeakerIs(character))
            {
                SetDialog(speakerUILeft, speakerUIRight, line.text);
            }
            else
            {
                SetDialog(speakerUIRight, speakerUILeft, line.text);
            }

            void SetDialog(SpeakerUI activeSpeakerUI, SpeakerUI inactiveSpeakerUI, string text)
            {
                activeSpeakerUI.portrait.sprite = line.portrait;
                StopAllCoroutines();
                StartCoroutine(TypeSentence(text, activeSpeakerUI));
                activeSpeakerUI.Show();
                inactiveSpeakerUI.Hide();
            }

            IEnumerator TypeSentence(string sentence, SpeakerUI activeSpeakerUI)
            {
                activeSpeakerUI.Dialog = "";
                foreach (char letter in sentence.ToCharArray())
                {
                    activeSpeakerUI.Dialog += letter;
                    yield return new WaitForSeconds(sec);
                }
            }
        }
    }
}
