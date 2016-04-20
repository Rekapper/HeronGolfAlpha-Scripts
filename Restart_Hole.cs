using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart_Hole : MonoBehaviour {

	// Use this for initialization
	public void OnClick () {
        SceneManager.LoadScene("Hole1");
    }
}
