﻿using UnityEngine;
using System.Collections;

public class MiniMap : MonoBehaviour {
    public static MiniMap _instance;
    private Transform playerIcon;
    public GameObject enemyIconPrefab;

    void Awake()
    {
        _instance = this;
        playerIcon = transform.Find("PlayerIcon");
    }

    public Transform GetPlayerIcon()
    {
        return playerIcon;
    }
    public GameObject GetBossIcon()
    {
        GameObject go = NGUITools.AddChild(this.gameObject, enemyIconPrefab);
        go.GetComponent<UISprite>().spriteName = "BossIcon";
        return go;
    }
    public GameObject GetMonsterIcon()
    {
        GameObject go = NGUITools.AddChild(this.gameObject, enemyIconPrefab);
        go.GetComponent<UISprite>().spriteName = "EnemyIcon";
        return go;
    }
}
