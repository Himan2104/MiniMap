using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Prefab;

    private List<GameObject> Destinations = new List<GameObject>();

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.F1)) Spawn();
        if (Input.GetKeyUp(KeyCode.F2)) Clear();
    }

    public void Spawn()
    {
        Vector3 pos = new Vector3(Random.Range(-50, 50), 1.0f, Random.Range(-50, 50));
        Destinations.Add(Instantiate(Prefab, pos, Quaternion.identity));
    }

    public void Clear()
    {
        foreach (GameObject dest in Destinations) Destroy(dest);
        Destinations.Clear();
    }
}
