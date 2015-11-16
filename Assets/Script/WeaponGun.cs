using UnityEngine;
using System.Collections;

public class WeaponGun : MonoBehaviour {

    public Transform bulletPos;
    public GameObject bulletPre;
    public float attack = 100;

    public void Shoot()
    {
        GameObject go = GameObject.Instantiate(bulletPre, bulletPos.position, transform.root.rotation) as GameObject;
        go.GetComponent<Bullet>().attack = attack;
    }
}
