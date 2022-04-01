/**
* @file RotateCursolEditor.cs
* @brief RotateCursolスクリプトのInspectorをカスタマイズしたもの
* @author Chronoss0518
* @date 2022/03/29
* @details RotateCursolスクリプトを操作しやすいようにInspectorをカスタマイズしたもの
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditorを継承したRotateCursolEditor
*/

namespace ChUnity.Transform
{

    [CustomEditor(typeof(RotateCursol))]
    public class RotateCursolEditor : Common.GameObjectTargetSelectorEditor
    {

        private void OnEnable()
        {
            targetObjectDescription = "回転するオブジェクト";
        }

        /**
       * @fn public void OnInspectorGUI()
       * @brief InspectorのGUIを変更する関数。
       */
        public override Object InspectorGUI()
        {
            return base.InspectorGUI();

        }
    }

}
