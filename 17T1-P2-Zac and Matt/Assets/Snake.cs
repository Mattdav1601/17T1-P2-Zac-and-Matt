using UnityEngine;
using System.Collections;

public class Snake : MonoBehaviour {

    public PathExample[] snakeBits;
    public float segmentDelay;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < snakeBits.Length; ++i)
        {
            snakeBits[i].tween((i + 1) * segmentDelay);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
