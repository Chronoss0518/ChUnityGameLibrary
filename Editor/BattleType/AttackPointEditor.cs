/**
* @file AttackPointEditor.cs
* @brief LifePointスクリプトのInspectorをカスタマイズしたもの
* @author Chronoss0518
* @date 2022/01/02
* @details LifePointスクリプトを操作しやすいようにInspectorをカスタマイズしたもの
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AttackPoint))]
public class AttackPointEditor : CustomInspectorBase
{
    public override void OnInspectorGUI()
    {

        base.OnInspectorGUI();

        var obj = target as AttackPoint;

        {

            int tmp = obj.attackPoint;
            Slider(ref tmp, obj.lowAttackPoint, obj.highAttackPoint, "Attack Point");
            obj.attackPoint = tmp;
        }

        {

            int low = obj.lowAttackPoint, high = obj.highAttackPoint;
            Label("Set Attack Point Range");
            BeginHorizontal();
            InputField(ref low, "Low:");
            EndHorizontal();

            BeginHorizontal();
            InputField(ref high, "High:");
            EndHorizontal();

            obj.lowAttackPoint = low;
            obj.highAttackPoint = high;
        }

    }
}
