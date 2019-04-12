using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalParameterScript : MonoBehaviour
{

    public int i_targLifeCycle;
    public float f_stareTime;
    public int i_lvlReq;

    public int i_amountToFinish;
    public bool b_targLifeCycle;

    public float f_trainVolume;
    public float f_globalVolume;

    public bool b_leftSided;

    private void Start()
    {
        i_targLifeCycle = 1;
        i_lvlReq = 8;
        i_amountToFinish = 30;
        

        f_stareTime = 4;
        f_trainVolume = 1;
        f_globalVolume = .3f;

        b_targLifeCycle = false;
        b_leftSided = true;
    }
}
