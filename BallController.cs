using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class BallController : MonoBehaviour {

	public GameObject Hole;
    public float speed;
    public float sliderval;
    public float roughMultiplyer;
    public int strokes = 0;
    public int distancetohole;
    public Text YardstH;
    public Text StrokesText;
	public Text HoleText;
	public Text ParText;
	public Text SurfaceConName;
	public string HoleT;
	public Vector3 LastPosition;
	public int HoleNum = 1;
	public int[] ParNumArr = new int[] { 4, 5, 3, 4, 3, 5, 5, 4, 3, 4, 5, 3, 4, 3, 5, 5, 4, 3};
	public int ParNum;
	//public Camera GameCamera;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
		HoleT = "Hole1";
		HoleText.text = "Hole #1";
		ParNum = ParNumArr[HoleNum-1];
		ParText.text = "Par "+ParNum.ToString();
        //Terrain.activeTerrain.collectDetailPatches = false;
		//HoleNum = 2;
		HoleCount();
		MoveGolfBallToNextHole();
    }
    //public float angle;

    //void Update(){
        
        //if (Input.touches.Length > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        //{
        //    angle += Input.GetTouch(0).deltaPosition.y;
        //    transform.rotation *= Quaternion.AngleAxis(angle, Vector3.forward);
        //}  }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
		Hole = GameObject.Find(HoleT);
        distancetohole = (int)Vector3.Distance(rb.transform.position,Hole.transform.position);
        YardstH.text = distancetohole.ToString();
    }
    void OnMouseOver() { if (Input.GetMouseButtonDown(0)) HitBall(); }
    void HitBall()
    {
		LastPosition = rb.transform.position; 
		Debug.Log(LastPosition);
        var dir = Camera.main.transform.forward;
        sliderval = (GameObject.Find("powerSlider").GetComponent<Slider>().value);		
        float forward = sliderval * (ClubSelect.clubDistance) * roughMultiplyer;
        dir.y = 0;
        strokes += 1;
        float up = ClubSelect.clubDistance * ClubSelect.clubAngleMult * sliderval/10;
        rb.AddForce(dir.normalized * forward);
        rb.AddForce(0, up, 0);
        StrokesText.text = strokes.ToString(); ;
    }
    //void OnApplicationPause()
   // {
        ///'Golf Ball'.position(0, 2.5, -200);
        //Application.LoadLevel("YourPreviousLevel");
        //SceneManager.LoadScene("NW-C1-H1-v2");
   // }
    void OnTriggerEnter(Collider ground) {
		if(ground.tag == "Rough") 
			{roughMultiplyer = 0.7f; 
			SurfaceConName.text = "Rough";} 
		else if(ground.tag == "Sand")
			{roughMultiplyer = 0.5f;
			SurfaceConName.text = "Sand";} 
		else if(ground.tag =="Fairway")
			{roughMultiplyer = 0.95f;
			SurfaceConName.text = "Fairway";}
		else if(ground.tag == "Water")
			{rb.transform.position = LastPosition;
			strokes += 1;}
		else if (Hole){
			HoleCount();
			Debug.Log(HoleT);
		}
		else {roughMultiplyer = 1; SurfaceConName.text = "Fairway";}
	}
	void OnCollisionExit(Collision air){
		roughMultiplyer = 1;
	}
	void HoleCount(){
		int HoleMax = 18;
		if(HoleNum < HoleMax){HoleNum++;}
		else{Debug.Log("End of Round");}
		HoleT = "Hole"+HoleNum;
		HoleText.text = "Hole #"+HoleNum.ToString();
		ParNum = ParNumArr[HoleNum-1];
		ParText.text = "Par "+ParNum.ToString();
		MoveGolfBallToNextHole();
	}
	void MoveGolfBallToNextHole(){
	switch(HoleNum){
		case 2:
		rb.transform.position = new Vector3(455,6,555);
		strokes = 0;
		//GameCamera.transform.rotation = new Vector3(12,310,0);
		break;
		
		}
	}
}