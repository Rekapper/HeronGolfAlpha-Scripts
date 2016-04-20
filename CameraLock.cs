using UnityEngine;
using System.Collections;

public class CameraLock : MonoBehaviour {

    public GameObject Player;
    private Vector3 offset;
    public float angle;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offset;
        if (Input.touches.Length > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            angle += Input.GetTouch(0).deltaPosition.y;
            transform.rotation *= Quaternion.AngleAxis(angle, Vector3.up);
        }
    }
}
