/**
* @file GameObjectTargetSelectorEditor.cs
* @brief GameObjectTargetSelectorスクリプトのInspectorをカスタマイズしたもの
* @author Chronoss0518
* @date 2022/01/02
* @details GameObjectTargetSelectorスクリプトを操作しやすいようにInspectorをカスタマイズしたもの
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   Custom InspectorBaseを継承したLifePointのCustomInspector
*/

namespace ChUnity.Common
{


    [CustomEditor(typeof(GameObjectTargetSelector))]
    public class GameObjectTargetSelectorEditor : CustomInspectorBase
    {

        /**
       * @fn public void OnInspectorGUI()
       * @brief InspectorのGUIを変更する関数。
       */
        public override void OnInspectorGUI()
        {

            base.OnInspectorGUI();

            var obj = target as GameObjectTargetSelector;

            var go = SerializeObjectToObject("targetObject");

            Label(go.name);

            InputField<GameObject>(ref go, "操作対象のオブジェクト");

            ObjectToSerializeObject("targetObject",go);

        }
    }

}
