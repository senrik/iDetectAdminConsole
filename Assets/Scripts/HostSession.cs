using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HostSession : NetworkManager {

    public bool useHLAPI;
    private AdminConsoleController adminConsole;

    void Awake()
    {
        if (useHLAPI)
        {
            //m_netManager = gameObject.AddComponent<NetworkManager>();
            gameObject.AddComponent<NetworkManagerHUD>();
            //m_netManager.autoCreatePlayer = false;
            NetworkServer.RegisterHandler(444, ProgressUpdate);
        }
        else
        {

        }
        adminConsole = gameObject.GetComponent<AdminConsoleController>();
    }

    void ProgressUpdate(NetworkMessage netMsg)
    {
        string jsonMessage = netMsg.reader.ReadString();
        Debug.Log("Message Received from connectionID: " + netMsg.conn);
        adminConsole.UpdatePlayerProgress(JsonUtility.FromJson<Progress>(jsonMessage), netMsg.conn.connectionId);

    }

	// Use this for initialization
	void Start () {

        if (useHLAPI)
        {

        }
	}

    public override void OnServerConnect(NetworkConnection conn)
    {
        Debug.Log("Client connected with ID: " + conn.connectionId);
        adminConsole.AddPlayer(Instantiate(playerPrefab));
    }    

    public void StartHosting()
    {
        if (useHLAPI)
        {
            //m_netManager.StartServer();
            StartServer();
            
        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update () {
        if (useHLAPI)
        {

        }
	}
}
