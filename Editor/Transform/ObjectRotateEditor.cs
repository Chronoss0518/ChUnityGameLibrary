/**
* @file ObjectRotateEditor.cs
* @brief ObjectRotateスクリプトのInspectorをカスタマイズしたもの
* @author Chronoss0518
* @date 2022/03/29
* @details ObjectRotateスクリプトを操作しやすいようにInspectorをカスタマイズしたもの
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditorを継承したObjectRotateEditor
*/

namespace ChUnity.Transform
{

    [CustomEditor(typeof(ObjectRotate))]
    public class ObjectRotateEditor : Common.GameObjectTargetSelectorEditor
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

            var obj = base.InspectorGUI() as ObjectRotate;

            obj.rotSize = InputField(obj.rotSize, "回転速度");

            obj.autoRotateAxis = (Axis)EnumPopup(obj.autoRotateAxis, "自動で回転を行うフラグ");

            BeginObjectUpdate();

            UpdateProperty(obj.rotSize, "rotSize");

            UpdateProperty((int)obj.autoRotateAxis, "autoRotateAxis");

            EndObjectUpdate();

            return obj;
        }
    }

}
