using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapHandler : MonoBehaviour
{
    public static MiniMapHandler Agent;

    public GameObject Map;
    public GameObject PointerHolder;
    public GameObject PointerPrefab;

    [HideInInspector] private GameObject player;
    [HideInInspector] private List<GameObject> destinations = new List<GameObject>();
    [HideInInspector] private List<GameObject> mapdestinations = new List<GameObject>();
    [HideInInspector] public int count = -1;
    

    [Header("Settings")]

    public float range;
    public float scale = 10f;

    private void Awake()
    {
        if (Agent == null) Agent = this;
    }

    private void Update()
    {
        if (player == null || count < 0) return;
        else
        for(int i = 0; i < destinations.Count; i++)
        {
            float distance = Mathf.Sqrt(Mathf.Pow(destinations[i].transform.position.x-player.transform.position.x,2) + Mathf.Pow(destinations[i].transform.position.z - player.transform.position.z, 2));
            Vector3 direction = new Vector3((destinations[i].transform.position.x - player.transform.position.x)/distance,(destinations[i].transform.position.z - player.transform.position.z)/distance, 0.0f);
            
            if (distance > range) mapdestinations[i].transform.localPosition = range * scale * direction;
            else mapdestinations[i].transform.localPosition = distance * scale * direction;
                        
            Map.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, player.transform.rotation.eulerAngles.y);
        }
    }

    public void addPlayer(GameObject gameobject)
    {  
        player = gameobject;     
    }

    public void addDestination(GameObject gameobject)
    {
        destinations.Add(gameobject);
        mapdestinations.Add(Instantiate(PointerPrefab, PointerHolder.transform));
        count++;
    }

    public void removeDestination(GameObject gameobject)
    {
        if(destinations.Contains(gameobject))
        {
            Destroy(mapdestinations[destinations.IndexOf(gameobject)]);
            mapdestinations.Remove(mapdestinations[destinations.IndexOf(gameobject)]);
            destinations.Remove(gameobject);
        } 
    }

}
