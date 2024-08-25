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

namespace ChUnity.Event
{
    [CustomEditor(typeof(CounterEvent))]
    public class CounterEventEditor : CustomInspectorBase
    {

        SerializedProperty loopFlg;
        SerializedProperty loopMaxCount;

        SerializedProperty countAction;

        void OnEnable()
        {
            loopFlg = serializedObject.FindProperty("loopFlg");
            loopMaxCount = serializedObject.FindProperty("loopMaxCount");

            countAction = serializedObject.FindProperty("countAction");
        }

        public override void UpdateInspectorGUI()
        {

            var obj = target as CounterEvent;

            Label("Counterの現在値[" + obj.counter.ToString() +"]");
            
            InputField(countAction, "useCountAction");

            InputField(loopFlg, "loopFlg");

            if (loopFlg.boolValue)
            {
                InputField(loopMaxCount, "loopMaxCount");
            }

        }

    }

}
