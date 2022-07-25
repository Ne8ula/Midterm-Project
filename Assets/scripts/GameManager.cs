using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool gameEnded = false;
	public float restartTimer = 1f;
	public GameObject completeLevelUI;
	public void CompleteLevel1()
	{
		completeLevelUI.SetActive(true);
	}
	public void EndGame()
	{
		if (gameEnded == false){
			gameEnded = true;
			Invoke("restart", restartTimer);
		}
		
	}
	void restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
