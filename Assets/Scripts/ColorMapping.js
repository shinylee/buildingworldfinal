#pragma strict
var changeColor:float;
public var targetLight:GameObject;
public var targetCube:Transform;
public var micScript: MicControl;

function Start () {
micScript = GetComponent("MicControl");
}

function Update () {
changeColor = map_range(micScript.loudness,0, 100, 0,255);
//micScript.loudness is the valumne


if(changeColor > 255.0F){
changeColor = 255.0F;
}

//light.Color = Color(changeColor,0,0);
//Color prettyColor = new Color(changeColor, 0.0F, 0.0F);
	targetLight.light.color = new Color(changeColor, 0.0F, 0.0F);
	
///the rotation no work here
	//targetLight.transform.Rotate(Vector3.right * Time.deltaTime);
	targetCube.Rotate(Vector3.up, 10F * Time.deltaTime);
		// ... at the same time as spinning relative to the global 
		// Y axis at the same speed.
	targetCube.Rotate(Vector3.up * Time.deltaTime, Space.World);
}

function map_range(cvalue: float, low1: float, high1: float, low2: float, high2: float) {
    return low2 + (high2 - low2) * (cvalue - low1) / (high1 - low1);
}
