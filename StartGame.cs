using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartGame : MonoBehaviour {
    public Button Start;

    public void PlayButton()
    {
        SceneManager.LoadScene("NW-C1");
    }
}
