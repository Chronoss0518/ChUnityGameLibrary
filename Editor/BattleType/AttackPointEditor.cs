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
        public override Object InspectorGUI()
        {
            var obj = target as AttackPoint;

            obj.attackPoint = Slider(obj.attackPoint, obj.lowAttackPoint, obj.highAttackPoint, "Attack Point");

            Label("Set Attack Point Range");
            BeginHorizontal();
            obj.lowAttackPoint = InputField(obj.lowAttackPoint, "Low:");
            EndHorizontal();

            BeginHorizontal();
            obj.highAttackPoint = InputField(obj.highAttackPoint, "High:");
            EndHorizontal();

            BeginObjectUpdate();

            UpdateProperty(obj.attackPoint, "atk");
            
            UpdateProperty(obj.lowAttackPoint, "lATK");

            UpdateProperty(obj.highAttackPoint, "hATK");

            EndObjectUpdate();

            return obj;
        }
    }

}

