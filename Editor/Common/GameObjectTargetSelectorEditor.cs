/**
* @file GameObjectTargetSelectorEditor.cs
* @brief GameObjectTargetSelectorスクリプトのInspectorをカスタマイズしたもの
* @author Chronoss0518
* @date 2022/03/29
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

        protected string targetObjectDescription = "操作対象のオブジェクト";

        /**
       * @fn public void OnInspectorGUI()
       * @brief InspectorのGUIを変更する関数。
       */
        public override Object InspectorGUI()
        {

            var obj = target as GameObjectTargetSelector;

            obj.target = (GameObject)InputField<GameObject>(obj.target, targetObjectDescription);

            return obj;
        }
    }

}
