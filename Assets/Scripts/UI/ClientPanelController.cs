using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientPanelController : MonoBehaviour {

    public Text userName, currentTest, progressText;

    private Progress userProgress;

    private void Start()
    {
        userProgress = new Progress();
    }

    public void SetupClientPanel(string username, string initTest, int currentIndex, int maxIndex)
    {
        userName.text = username;
        currentTest.text = initTest;
        progressText.text = string.Format("{0}/{1}", currentIndex, maxIndex);
    }

    private void LateUpdate()
    {
        userName.text = userProgress.username;
        currentTest.text = userProgress.currentTest;
        progressText.text = string.Format("{0}/{1}", userProgress.currentTestNum, userProgress.maxTestNum);
    }

    public Progress UserProgress
    {
        get { return userProgress; }
        set { userProgress = value; }
    }
}
