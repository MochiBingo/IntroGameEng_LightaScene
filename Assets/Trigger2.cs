using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Trigger2 : MonoBehaviour
{
    public PlayableDirector timeline;
    public void OnTriggerEnter(Collider other)
    {
        timeline.Play();
    }
}
