using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientGridController : MonoBehaviour {

    private List<GameObject> connectedPlayers;


	// Use this for initialization
	void Start () {
        connectedPlayers = new List<GameObject>();
	}

    public void AddPlayer(GameObject player)
    {
        connectedPlayers.Add(player);
        player.transform.SetParent(transform);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
