var core : GameObject;
var targetPosition : Vector3;
private var lobHeight : float = 4;
private var lobTime : float = .7f;

function Start(){
	iTween.MoveBy(core, iTween.Hash("y", lobHeight, "time", lobTime/2, "easeType", iTween.EaseType.easeOutQuad));
	iTween.MoveBy(core, iTween.Hash("y", -lobHeight, "time", lobTime/2, "delay", lobTime/2, "easeType", iTween.EaseType.easeInCubic));     
	iTween.MoveTo(gameObject, iTween.Hash("position", targetPosition, "time", lobTime, "easeType", iTween.EaseType.linear));
	iTween.FadeTo(gameObject, iTween.Hash("delay", 3, "time", .5, "alpha", 0, "onComplete", "CleanUp"));
}

function CleanUp(){
	Destroy(gameObject);	
}