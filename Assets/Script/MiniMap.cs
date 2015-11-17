using UnityEngine;
using System.Collections;

public class MiniMap : MonoBehaviour {
    public static MiniMap _instance;
    private Transform playerIcon;

    void Awake()
    {
        _instance = this;
    }

	// Use this for initialization
	void Start () {
        playerIcon = transform.Find("PlayerIcon");
	}

    public Transform GetPlayerIcon()
    {
        return playerIcon;
    }
}
