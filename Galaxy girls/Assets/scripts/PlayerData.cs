using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int one;
    public int two;
    public int three;

    public PlayerData(int one, int two, int three)
    {
        // attempts on respective levels
        this.one = one;
        this.two = two;
        this.three = three;

        // possibly completion rate
    }
}
