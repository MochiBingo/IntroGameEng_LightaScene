using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Trigger3 : MonoBehaviour
{
    public PlayableDirector timeline;
    private bool played = false;
    public void OnTriggerEnter(Collider other)
    {
        if (played == false)
        {
            timeline.Play();
            played = true;
        }
    }
}
