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
        /**
       * @fn public void OnInspectorGUI()
       * @brief Inspector��GUI��ύX����֐��B
       */
        public override void OnInspectorGUI()
        {


            base.OnInspectorGUI();

            var obj = target as CounterEvent;

            if (obj == null) return;

            CounterDictionary dic = (CounterDictionary)SerializeObjectToObject("useCountAction");

            if(dic == null) return;


        }
    }

}
