using UnityEngine;
using System.Collections;

public class EnemyIcon : MonoBehaviour {

    private Transform icon;
    private Transform player;

    void Start()
    {
        if (this.tag == Tags.soulBoss)
        {
            icon = MiniMap._instance.GetBossIcon().transform;
        }
        else if (this.tag == Tags.soulMonster)
        {
            icon = MiniMap._instance.GetMonsterIcon().transform;
        }
        player = GameObject.FindGameObjectWithTag(Tags.player).transform;

    }

    void Update()
    {
        Vector3 offset = transform.position - player.position;
        offset *= 10;
        icon.localPosition = new Vector3(offset.x, offset.z, 0);
    }

    void OnDestroy()
    {
        if (icon != null)
        {
            Destroy(icon.gameObject);
        }
    }
}
