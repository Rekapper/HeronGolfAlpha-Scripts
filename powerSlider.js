#pragma strict
import UnityEngine.UI;
var mySlider: UnityEngine.UI.Slider;
var TimeInterval = 0;
var countUp = true;
var i = 0;
var r = 0.001;
function Start () {
    mySlider = GameObject.Find("powerSlider").GetComponent(UnityEngine.UI.Slider);
}

function LateUpdate () {
/*    TimeInterval = TimeInterval + Time.deltaTime*10;
    if (TimeInterval >= 1)
    {*/
        if (mySlider.value < 10 && countUp){mySlider.value+=r;};
        if(mySlider.value > 0 && !countUp){mySlider.value-=r;};

        if(mySlider.value==10){countUp = false;};
        if(mySlider.value==0){countUp = true;};
    //}
}