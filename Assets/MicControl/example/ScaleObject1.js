#pragma strict




function Update () {
//scales the gameObject heigt based on input stream gathered from MicControl.loudness
//transform.localScale=Vector3(MicControl.loudness,MicControl.loudness,1);

transform.localScale=Vector3(MicControl.loudness*0.05,MicControl.loudness*0.05,MicControl.loudness*0.05);
transform.Rotate(Vector3.up, 200F * Time.deltaTime);

}

