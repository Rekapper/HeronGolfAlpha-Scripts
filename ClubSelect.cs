using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClubSelect : MonoBehaviour {

    public Text Club;
    public Text ClubDistanceText;
    public string[] ClubArray = new string[] { "1D", "3D", "3W", "5W", "5I", "7I", "8I", "9I", "PW", "SW", "P" };
    public int[] clubDistanceArray = new int[] { 315, 290, 270, 240, 200, 150, 130, 100, 75, 50, 20 };
    public int[] clubAngleArray = new int[] { 2,3,4,5,6,7,8,9,10,11,0 };
    public int ClubPosition;
    public static int clubDistance;
    public static int clubAngleMult;
    // Use this for initialization
    void Start () {
        Club.text = ClubArray[ClubPosition];
        clubDistance = clubDistanceArray[ClubPosition];
        ClubDistanceText.text = clubDistance.ToString();
        clubAngleMult = clubAngleArray[ClubPosition];
    }
	
    void OnMouseOver() { if (Input.GetMouseButtonDown(0)) ClubUp(); }
    public void ClubUp()
    {
        ClubPosition = ClubPosition - 1;
        if (ClubPosition < 0) { ClubPosition = 10; }
        Club.text = ClubArray[ClubPosition];
        clubDistance = clubDistanceArray[ClubPosition];
        ClubDistanceText.text = clubDistance.ToString();
        clubAngleMult = clubAngleArray[ClubPosition];
    }
    public void ClubDown()
    {
        ClubPosition = ClubPosition + 1;
        if (ClubPosition > 10) { ClubPosition = 0; }
        Club.text = ClubArray[ClubPosition];
        clubDistance = clubDistanceArray[ClubPosition];
        ClubDistanceText.text = clubDistance.ToString();
        clubAngleMult = clubAngleArray[ClubPosition];

    }
}
//int clubPosition1 = clubPosition.GetComponent<ClubSelect>();
//int clubDistance = clubDistanceArray[clubPosition1];