using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
public Canvas pauseMenu;
public Button resumeButton;
public Button quitToMainMenuButton;
public Button QuitGameButton;
	// Use this for initialization
	void Start () {
		pauseMenu.enabled = false;
		resumeButton.enabled = false;
		quitToMainMenuButton.enabled = false;
		QuitGameButton.enabled = false;
	}
	public void PressPause(){
	Time.timeScale = 0f;
		pauseMenu.enabled = true;
		resumeButton.enabled = true;
		quitToMainMenuButton.enabled = true;
		QuitGameButton.enabled = true;
	}
	public void ResumePressed(){
	Time.timeScale = 1.0f;
		pauseMenu.enabled = false;
		resumeButton.enabled = false;
		quitToMainMenuButton.enabled = false;
		QuitGameButton.enabled = false;
	}
	public void QuitToMain(){
	Time.timeScale = 1.0f;
		SceneManager.LoadScene("1Home");
	}
	public void QuitGame(){
		Application.Quit();
	}
}
