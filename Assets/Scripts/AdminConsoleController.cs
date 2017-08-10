using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AdminConsoleController : MonoBehaviour {

    public ClientGridController playerGrid;
    private HostSession m_hostSession;

    private void Awake()
    {
        m_hostSession = GetComponent<HostSession>();
    }

    // Use this for initialization
    void Start () {
        if (m_hostSession.useHLAPI)
        {
            
        }
        else
        {

        }
    }
	
    public void StartTestSession()
    {
        m_hostSession.StartHosting();   
    }

    public void UpdatePlayerProgress(Progress prog, int con)
    {
        playerGrid.UpdatePlayerProgress(prog, con);
    }

    public void AddPlayer(GameObject player)
    {
        playerGrid.AddPlayer(player);
    }

    // Update is called once per frame
    void Update () {
	    	
	}
}
