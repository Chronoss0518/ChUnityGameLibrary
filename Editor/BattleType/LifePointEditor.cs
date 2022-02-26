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

            {

                int tmp = obj.maxLifePoint;
                Slider(ref tmp, obj.lowMaxLifePoint, obj.highMaxLifePoint, "Max Life Point");
                obj.maxLifePoint = tmp;
            }

            {

                int low = obj.lowMaxLifePoint, high = obj.highMaxLifePoint;
                Label("Set Max Life Point Range");
                BeginHorizontal();
                InputField(ref low, "Low:");
                EndHorizontal();

                BeginHorizontal();
                InputField(ref high, "High:");
                EndHorizontal();

                obj.lowMaxLifePoint = low;
                obj.highMaxLifePoint = high;
            }

        }
    }

}
