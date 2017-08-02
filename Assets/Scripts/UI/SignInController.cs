using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignInController : MonoBehaviour {

    public InputField adminUserName, sessionLabel;
    public Toggle networkType;

	// Use this for initialization
	void Start () {
		
	}
	
    public void ClearEntries()
    {
        adminUserName.text = "";
        sessionLabel.text = "";
        networkType.isOn = false;
    }

	// Update is called once per frame
	void Update () {
		
	}

    public string AdminUserName
    {
        get { return adminUserName.text; }
    }

    public string SessionLabel
    {
        get { return sessionLabel.text; }
    }

    public bool IsBluetooh
    {
        get { return networkType.isOn; }
    }
}
