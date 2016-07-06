﻿/*---------------------------------------------------------------------------------------
--  SOURCE FILE:    AmanSelfBuff.cs
--
--  PROGRAM:        Linux Game
--
--  FUNCTIONS:
--      void Start()
--      override void FixedUpdate()
--
--  DATE:           April 2, 2016
--
--  REVISIONS:      (Date and Description)
--                  April 4th: Hank Lo
--                      - Numbers balancing; removed majority of self stat buffs, increased hp buff
--                  April 5th: Allen Tsang
--                      - Attached indicator
--
--  DESIGNERS:      Allen Tsang, Hank Lo
--
--  PROGRAMMER:     Allen Tsang, Hank Lo
--
--  NOTES:
--  This class contains the logic that relates to the Aman Self Buff Class.
---------------------------------------------------------------------------------------*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class AmanSelfBuff : Buff {
    
    int hpBuff = 2000;
    BaseClass target;
    Rigidbody2D area;
    GameObject indicator;
    GameObject instance;

    new void Start()
    {
        base.Start();
        target = gameObject.GetComponent<BaseClass>();
        target.ClassStat.MaxHp += hpBuff;

        area = (Rigidbody2D)Resources.Load("Prefabs/AmanBuffArea", typeof(Rigidbody2D));
        //load indicator
        if (target.playerID == GameData.AllyKingID)
            indicator = (GameObject)Resources.Load("Prefabs/AllyAmanCircle", typeof(GameObject));
        else
            indicator = (GameObject)Resources.Load("Prefabs/EnemyAmanCircle", typeof(GameObject));

        instance = (GameObject)Instantiate(indicator, transform.position, transform.rotation);
        instance.transform.parent = target.transform;
    }
    
    // Called every physics update
    protected override void FixedUpdate() {
        //Non-standard duration, counts up
        duration++;
        if (duration % 50 == 0) 
        {
            //Do AoE buff
            Rigidbody2D instance = (Rigidbody2D)Instantiate(area, target.gameObject.transform.position, target.gameObject.transform.rotation);
            instance.GetComponent<AmanBuffArea>().playerID = target.playerID;
            instance.GetComponent<AmanBuffArea>().teamID = target.team;
            instance.GetComponent<AmanBuffArea>().damage = 0;
            Destroy(instance.gameObject, 0.1f);
        }
    }
}

