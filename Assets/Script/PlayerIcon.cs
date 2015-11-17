using UnityEngine;
using System.Collections;

public class PlayerIcon : MonoBehaviour {
    private Transform playericon;

	// Use this for initialization
	void Start () {
        playericon = MiniMap._instance.GetPlayerIcon();
	}
	
	// Update is called once per frame
	void Update () {
        float y = transform.eulerAngles.y;
        playericon.localEulerAngles = new Vector3(0, 0, -y);
	}
}
