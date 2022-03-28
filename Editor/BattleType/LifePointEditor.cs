/**
* @file LifePointEditor.cs
* @brief LifePointスクリプトのInspectorをカスタマイズしたもの
* @author Chronoss0518
* @date 2022/01/02
* @details LifePointスクリプトを操作しやすいようにInspectorをカスタマイズしたもの
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   Custom InspectorBaseを継承したLifePointのCustomInspector
*/

namespace ChUnity.BattleType
{
    [CustomEditor(typeof(LifePoint))]
    public class LifePointEditor : CustomInspectorBase
    {
        /**
       * @fn public void OnInspectorGUI()
       * @brief InspectorのGUIを変更する関数。
       */
        public override void OnInspectorGUI()
        {


            base.OnInspectorGUI();

            var obj = target as LifePoint;

            obj.maxLifePoint = Slider(obj.maxLifePoint, obj.lowMaxLifePoint, obj.highMaxLifePoint, "Max Life Point");

            PropertyField("action", "Death Event");


            Label("Set Max Life Point Range");
            BeginHorizontal();
            obj.lowMaxLifePoint = InputField(obj.lowMaxLifePoint, "Low:");
            EndHorizontal();

            BeginHorizontal();
            obj.highMaxLifePoint = InputField(obj.highMaxLifePoint, "High:");
            EndHorizontal();



        }
    }

}
