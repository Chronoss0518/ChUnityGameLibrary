/**
* @file LifePointEditor.cs
* @brief LifePoint�X�N���v�g��Inspector���J�X�^�}�C�Y��������
* @author Chronoss0518
* @date 2022/01/02
* @details LifePoint�X�N���v�g�𑀍삵�₷���悤��Inspector���J�X�^�}�C�Y��������
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   Custom InspectorBase���p������LifePoint��CustomInspector
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

            Label("Counter�̌��ݒl[" + obj.counter.ToString() +"]");
            
            InputField(countAction, "useCountAction");

            InputField(loopFlg, "loopFlg");

            if (loopFlg.boolValue)
            {
                InputField(loopMaxCount, "loopMaxCount");
            }

        }

    }

}