using UnityEngine;
using System.Collections;

public class BiggerWhenLooking : MonoBehaviour {

    public float growthRate = 0.1f;
    Camera camera;

	// Use this for initialization
	void Start () {
        camera = Camera.main;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //Ray ray = camera.ScreenPointToRay(new Vector3 (Screen.width / 2, Screen.height / 2, 0));

        Ray ray = new Ray(camera.transform.position, camera.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000f))
        {
            if (hit.transform == this.transform)
            {
                transform.localScale = transform.localScale * (1f + (growthRate * Time.fixedDeltaTime));
            }
        }
	}
}
