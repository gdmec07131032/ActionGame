using UnityEngine;
using System.Collections;

public class SoulBossATKAndDamage : ATKAndDamage {

    private Transform player;

    void Awake()
    {
        base.Awake();
        player = GameObject.FindGameObjectWithTag(Tags.player).transform;
    }

    public void Attack1()
    {
        if (Vector3.Distance(transform.position, player.position) < attackDistance)
        {
            player.GetComponent<ATKAndDamage>().TakeDamage(normalAttack);
        }
    }
    public void Attack2()
    {
        if (Vector3.Distance(transform.position, player.position) < attackDistance)
        {
            player.GetComponent<ATKAndDamage>().TakeDamage(normalAttack);
        }
    }
}
