using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    
    void Start()
    {
        MiniMapHandler.Agent.addPlayer(this.gameObject);
    }

   
}
