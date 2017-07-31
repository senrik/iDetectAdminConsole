using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientPanelController : MonoBehaviour {

    public Text userName, currentTest, progressText;

    public void SetupClientPanel(string username, string initTest, int currentIndex, int maxIndex)
    {
        userName.text = username;
        currentTest.text = initTest;
        progressText.text = string.Format("{0}/{1}", currentIndex, maxIndex);
    }

    public void UpdateProgress(string testName, int current, int max)
    {
        currentTest.text = testName;
        progressText.text = string.Format("{0}/{1}", current, max);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
