using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public HitPoints hitpoints;
    public int maxHitpoints;
    public int startingHitPoints;
    public Attack attack;
    public int startingAttack;
    public Dfense dfense;
    public int startingDfense;
    public Agile agile;
    public int startingAgile;
    public Yellowkey yellowkey;
    public int startingYellowkey;
    public Bluekey bluekey;
    public int startingBluekey;
    public Redkey redkey;
    public int startingRedkey;
}
