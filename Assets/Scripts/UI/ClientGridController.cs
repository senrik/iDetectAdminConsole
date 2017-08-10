using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientGridController : MonoBehaviour {

    public List<GameObject> connectedPlayers;

	// Use this for initialization
	void Start () {
        connectedPlayers = new List<GameObject>();
	}

    public void UpdatePlayerProgress(Progress prog, int i)
    {
        connectedPlayers[i-1].GetComponent<ClientPanelController>().UserProgress = prog;
    }

    public void AddPlayer(GameObject player)
    {
        connectedPlayers.Add(player);
        player.transform.SetParent(transform);
    }
	
}
