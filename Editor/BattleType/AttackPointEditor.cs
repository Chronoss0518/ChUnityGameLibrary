/**
* @file AttackPointEditor.cs
* @brief LifePoint�X�N���v�g��Inspector���J�X�^�}�C�Y��������
* @author Chronoss0518
* @date 2022/01/02
* @details LifePoint�X�N���v�g�𑀍삵�₷���悤��Inspector���J�X�^�}�C�Y��������
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

