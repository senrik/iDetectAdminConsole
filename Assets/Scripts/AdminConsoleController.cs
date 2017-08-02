using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AdminConsoleController : MonoBehaviour {


    private NetworkManager _networkManager;

	// Use this for initialization
	void Start () {
        _networkManager = GetComponent<NetworkManager>();
	}
	
    public void StartTestSession()
    {
        _networkManager.StartServer();
    }

	// Update is called once per frame
	void Update () {
		
	}
}
