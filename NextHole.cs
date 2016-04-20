using UnityEngine;
using System.Collections;

public class NextHole : MonoBehaviour {
    void OnTriggerEnter()
    {
        if (gameObject.name == "Hole")
        {
            Debug.Log("Hole Complete");
        }
    }
}
