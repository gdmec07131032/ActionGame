using UnityEngine;
using System.Collections;

public class AutoDestroy : MonoBehaviour {

    public float exitTime = 1;
	void Start () {
        Destroy(this.gameObject, exitTime);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
