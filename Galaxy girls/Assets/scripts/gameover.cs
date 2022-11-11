using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public TextMeshProUGUI tip;
    public GameObject audio;
    private string[] tips = new string[] {"You can press space twice to double jump!", "What doesn't kill you makes you stronger, what does, doesn't.", 
         "Game too hard? Theres a secret button that gives you invincibility", "Don't feel bad, even I can't beat my own game",
        "If you're reading this, stand up and do some stretches", "If you're reading this, I am in your walls", "Everytime you take damage, you have a two second grace period",
        "Game too hard? Skill issue.", "Remember, no matter how hard things get, at least you're not Californian", 
        "Found a bug? No, we call that intended game design","Try dodging!", "Did you know you could press P to dash? I didn't, because it doesn't!",
        "gooseworx gooseworx gooseworx gooseworx gooseworx\ngooseworx gooseworx gooseworx gooseworx gooseworx\ngooseworx gooseworx gooseworx gooseworx gooseworx"};

    // Start is called before the first frame update
    void Start()
    {
        int select = Random.Range(0, tips.Length);
        tip.text = $"Tip: {tips[select]}";
    }

    void OnEnable()
    {
        audio.SetActive(false);
    }

    public void SceneSwitch(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
