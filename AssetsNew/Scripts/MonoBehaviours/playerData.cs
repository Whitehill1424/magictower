using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerData : MonoBehaviour
{
    public HitPoints hitPoints;
    public Attack attack;
    public Dfense dfense;
    public Agile agile;
    public Yellowkey yellowkey;
    public Bluekey bluekey;
    public Redkey redkey;
    [HideInInspector]
    public player character;
    public Image meterImage;
    public Text hpText;
    public Text attackText;
    public Text dfenseText;
    public Text agileText;
    public Text yellowkeyText;
    public Text bluekeyText;
    public Text redkeyText;
    void Start()
    {
        
    }

    void Update()
    {
    //    if(character != null)
        {
        
            hpText.text = "Hp: " + hitPoints.value;
            attackText.text = "Atk: " + attack.value;
            dfenseText.text = "Dfe: " + dfense.value;
            agileText.text = "Agi: " + agile.value;
            yellowkeyText.text = "YWk: " + yellowkey.value;
            bluekeyText.text = "BUk: " + bluekey.value;
            redkeyText.text = "RDk: " + redkey.value;
        }
    }
}
