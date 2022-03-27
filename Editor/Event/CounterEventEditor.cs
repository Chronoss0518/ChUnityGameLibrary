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
        /**
       * @fn public void OnInspectorGUI()
       * @brief InspectorのGUIを変更する関数。
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
