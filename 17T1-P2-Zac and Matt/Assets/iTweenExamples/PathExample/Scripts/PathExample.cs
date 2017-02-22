using UnityEngine;
using System.Collections;

public class PathExample : MonoBehaviour{
    public Transform[] path;

    public GUIStyle style;
	private bool buttonActivated;
	
	void Start(){
		//tween();
	}
	
	void OnGUI () {
		if(buttonActivated){
			if(GUI.Button (new Rect (67,178,113,32), "",style)){
				reset();
				//tween();
			}
		}
	}
	
	void OnDrawGizmos(){
		iTween.DrawPath(path);
	}
	
	public void tween(float delay){
		iTween.MoveTo(gameObject,iTween.Hash("path",path,"time",30,"orienttopath",true,"looktime",0.6,"easetype","linear","oncomplete","complete1","delay",delay));	
	}
	
	void reset(){
		buttonActivated=false;
		transform.position=new Vector3(0,0,0);
		transform.eulerAngles=new Vector3(0,0,0);
	}

    void complete1()
    {
        iTween.MoveTo(gameObject, iTween.Hash("path", path, "time", 30, "orienttopath", true, "looktime", 0.6, "easetype", "linear", "oncomplete", "complete1"));
    }
}

