using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelOnWalkthrough : MonoBehaviour {

	//We checked the trigger checkbox on the gameObject's collider component
	//Now we want to listen if something else with a collider enters this
	//gameobject.

	private void OnTriggerEnter(Collider other)
	{
        Debug.Log("Trigger was entered");
        //perform the level change
        SceneManager.LoadScene("02_nextScene");

	}



}
