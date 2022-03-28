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


namespace ChUnity.BattleType
{
    [CustomEditor(typeof(AttackPoint))]
    public class AttackPointEditor : CustomInspectorBase
    {
        public override void OnInspectorGUI()
        {

            base.OnInspectorGUI();

            var obj = target as AttackPoint;

            obj.attackPoint = Slider(obj.attackPoint, obj.lowAttackPoint, obj.highAttackPoint, "Attack Point");

            Label("Set Attack Point Range");
            BeginHorizontal();
            obj.lowAttackPoint = InputField(obj.lowAttackPoint, "Low:");
            EndHorizontal();

            BeginHorizontal();
            obj.highAttackPoint = InputField(obj.highAttackPoint, "High:");
            EndHorizontal();


        }
    }

}

