using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JumpBackFromSecondLevel : MonoBehaviour {

    public float timeLimit = 10;
    public Text countDownText;
    private float time=0;
    private float timeToDisplay;
	
    // Update is called once per frame
	void Update () {
        time = Time.time;
        Debug.Log(time);

        timeToDisplay = timeLimit - time;
        countDownText.text = timeToDisplay.ToString();

        if (timeToDisplay <= 0)
        {
            timeToDisplay = timeLimit;
            SceneManager.LoadScene("01_startScene");
        }

	}
}
