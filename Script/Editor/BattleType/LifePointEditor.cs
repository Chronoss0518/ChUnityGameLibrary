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
        SerializedProperty maxLP;
        SerializedProperty action;

        SerializedProperty lMaxLP;
        SerializedProperty hMaxLP;
        int tmpMaxLP = 0;

        void OnEnable()
        {
            maxLP = serializedObject.FindProperty("maxLP");
            action = serializedObject.FindProperty("action");

            lMaxLP = serializedObject.FindProperty("lMaxLP");
            hMaxLP = serializedObject.FindProperty("hMaxLP");

        }

        public override void UpdateInspectorGUI()
        {
            tmpMaxLP = Slider(maxLP.intValue, lMaxLP.intValue, hMaxLP.intValue, "Max Life Point");

            InputField(action, "On Death Action");

            Label("Set Life Point Range");

            BeginHorizontal();
            InputField(lMaxLP, "Low:");
            EndHorizontal();

            BeginHorizontal();
            InputField(hMaxLP, "High:");
            EndHorizontal();

        }


        public override void EndInspectorGUI()
        {
            var obj = target as LifePoint;

            obj.maxLifePoint = tmpMaxLP;
        }
    }

}
