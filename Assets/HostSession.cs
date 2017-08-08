using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Types;
using UnityEngine.Networking.Match;

public class HostSession : MonoBehaviour {

    AdminConsoleController adminConsole;

    // Matchmaker related
    //List<MatchInfoSnapshot> m_MatchList = new List<MatchInfoSnapshot>();
    //bool m_MatchCreated, m_MatchJoined;
    //MatchInfo m_MatchInfo;
    //string m_MatchName = "NewSession";
    //NetworkMatch m_NetworkMatch;

    //// Connection/communication related
    //int m_HostId = -1;
    //// On the server there will be multiple connects, on the client this will only contain one ID
    //List<int> m_ConnectionIds = new List<int>();
    //byte[] m_ReceiveBuffer;
    //string m_NetworkMessage = "Hello, World!";
    //string m_LastReceivedMessage = "";
    //NetworkWriter m_Writer;
    //NetworkReader m_Reader;
    //bool m_ConnectionEstablished;

    //const int k_ServerPort = 25000;
    //const int k_MaxMessageSize = 65535;
    int maxConnections = 10;
    int myReliableChannelId;
    int myUnreliableChannelId;
    int hostId;
    int socketPort = 8888;
    int connectionId;

    void Awake()
    {
        //m_NetworkMatch = gameObject.AddComponent<NetworkMatch>();
        adminConsole = gameObject.GetComponent<AdminConsoleController>();
    }

	// Use this for initialization
	void Start () {
        NetworkTransport.Init();
        ConnectionConfig config = new ConnectionConfig();
        myReliableChannelId = config.AddChannel(QosType.Reliable);
        myUnreliableChannelId = config.AddChannel(QosType.Unreliable);
        HostTopology topology = new HostTopology(config, maxConnections);
        hostId = NetworkTransport.AddHost(topology, socketPort);
        Debug.Log("Socket open. HostID is: " + hostId);
        //m_ReceiveBuffer = new byte[k_MaxMessageSize];
        //m_Writer = new NetworkWriter();
        // While testing with multiple standalone players on one machine this will need to be enabled
        Application.runInBackground = true;
		
	}

    public void Connect()
    {
    }

    private void OnApplicationQuit()
    {
        NetworkTransport.Shutdown();
    }

    public

    // Update is called once per frame
    void Update () {
		
	}
}
