using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : Character
{
    public playerData playerDataPrefab;
    playerData playerdata;
    void Start()
    {
        hitpoints.value = startingHitPoints;
        attack.value = startingAttack;
        dfense.value = startingDfense;
        agile.value = startingAgile;
        yellowkey.value = startingYellowkey;
        bluekey.value = startingBluekey;
        redkey.value = startingRedkey;
        playerdata = Instantiate(playerDataPrefab);
        playerdata.character = this;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("canpickup"))
        {
            Item hitObjects = collision.gameObject.GetComponent<Consumable>().item;
            if (hitObjects != null)
            {
                bool shouldDisappear = false;

                print("Hit: " + hitObjects.objectName);
                switch (hitObjects.itemType)
                {
                    case Item.ItemType.medicine:
                        shouldDisappear = AdjustHitpoints(hitObjects.quantity);
                        break;
                    case Item.ItemType.atkstrong:
                        shouldDisappear = AdjustAttack(hitObjects.quantity);
                        break;
                    case Item.ItemType.dfestrong:
                        shouldDisappear = AdjustDfense(hitObjects.quantity);
                        break;
                    case Item.ItemType.agistrong:
                        shouldDisappear = AdjustAgile(hitObjects.quantity);
                        break;
                    case Item.ItemType.yellowkey:
                        shouldDisappear = AdjustYWkey(hitObjects.quantity);
                        break;
                    case Item.ItemType.bluekey:
                        shouldDisappear = AdjustBUkey(hitObjects.quantity);
                        break;
                    default:
                        break;
                }
                if (shouldDisappear)
                {
                    collision.gameObject.SetActive(false);
                }
            }

        }
    }
    public bool AdjustHitpoints(int amount)
    {
        if (hitpoints.value < maxHitpoints)
        {
            hitpoints.value = hitpoints.value + amount;
            print("Adjust by" + amount + ". New value: " + hitpoints.value);
            return true;
        }
        return false;
    }
    public bool AdjustAttack(int amount)
    {
        if (attack.value<999)
        {
            attack.value = attack.value + amount;
            print("Adjust by" + amount + ". New value: " + attack.value);
            return true;
        }
        return false;
    }
    public bool AdjustDfense(int amount)
    {
        if (dfense.value < 999)
        {
            dfense.value = dfense.value + amount;
            print("Adjust by" + amount + ". New value: " + dfense.value);
            return true;
        }
        return false;
    }
    public bool AdjustAgile(int amount)
    {
        if (agile.value < 100)
        {
            agile.value = agile.value + amount;
            print("Adjust by" + amount + ". New value: " + agile.value);
            return true;
        }
        return false;
    }
    public bool AdjustYWkey(int amount)
    {
        if (yellowkey.value < 100)
        {
            yellowkey.value = yellowkey.value + amount;
            print("Adjust by" + amount + ". New value: " + yellowkey.value);
            return true;
        }
        return false;
    }
    public bool AdjustBUkey(int amount)
    {
        if (bluekey.value < 100)
        {
            bluekey.value = bluekey.value + amount;
            print("Adjust by" + amount + ". New value: " + bluekey.value);
            return true;
        }
        return false;
    }

    /*   public void SaveData()
       {
           Global.Instance.startingHitPoints = hitpoints.value;
           Global.Instance.startingAttack = attack.value;
           Global.Instance.startingDfense = dfense.value;
           Global.Instance.startingAgile = agile.value;
           Global.Instance.startingYellowkey = yellowkey.value;
           Global.Instance.startingBluekey = bluekey.value;
           Global.Instance.startingRedkey = redkey.value;
       }*/
}
