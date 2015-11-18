﻿using UnityEngine;
using System.Collections;

public class BuildTrail : MonoBehaviour {

    public WeaponTrail myTrail;
    private float t = 0.033f;
    private float tempT = 0;
    private float animationIncrement = 0.003f;

    void LateUpdate()
    {
        t = Mathf.Clamp(Time.deltaTime, 0, 0.66f);
        if (t > 0)
        {
            while (tempT < t)
            {
                tempT += animationIncrement;
                if (myTrail.time > 0)
                {
                    myTrail.Itterate(Time.time - t + tempT);
                }
                else
                {
                    myTrail.ClearTrail();
                }
            }
            tempT -= t;
            if (myTrail.time > 0)
            {
                myTrail.UpdateTrail(Time.time, t);
            }
        }
    }


}
