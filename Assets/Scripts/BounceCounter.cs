using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    public int bounceCounter = 0;
    public int record;

    private void Start()
    {
        record = PlayerPrefs.GetInt("bounceRecord", 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        bounceCounter++;
        if (bounceCounter > record)
        {
            record = bounceCounter;
            PlayerPrefs.SetInt("bounceRecord", record);
        }
    }
}
