using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Enemy")]

public class Enemy : ScriptableObject
{
    public string objectName;
    public Sprite sprite;
    public int attack;
    public int dfense;
    public int agile;
    public int hp;
    public enum EnemyType
    {
        ShremGreen,
        ShremRed,
        TheKing
    }
    public EnemyType enemyType;
}
