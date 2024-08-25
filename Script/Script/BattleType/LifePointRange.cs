using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AttackData", menuName = "BattleTypeRange/AttackPoint", order = 1)]
public class LifePointRange : ScriptableObject
{
    public int lMaxLP = 0;
    public int hMaxLP = 0;
}
