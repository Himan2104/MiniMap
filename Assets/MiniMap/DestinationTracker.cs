using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationTracker : MonoBehaviour
{
    private void Start()
    {
        MiniMapHandler.Agent.addDestination(this.gameObject);
    }

    private void OnDestroy()
    {
        MiniMapHandler.Agent.removeDestination(this.gameObject);
    }
}
