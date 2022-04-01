/**
* @file ObjectScaleEditor.cs
* @brief ObjectScaleスクリプトのInspectorをカスタマイズしたもの
* @author Chronoss0518
* @date 2022/03/29
* @details ObjectScaleスクリプトを操作しやすいようにInspectorをカスタマイズしたもの
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditorを継承したObjectScaleEditor
*/

namespace ChUnity.Transform
{

    [CustomEditor(typeof(ObjectScale))]
    public class ObjectScaleEditor : Common.GameObjectTargetSelectorEditor
    {

        private void OnEnable()
        {
            targetObjectDescription = "拡縮を行うオブジェクト";
        }

        /**
       * @fn public void OnInspectorGUI()
       * @brief InspectorのGUIを変更する関数。
       */
        public override Object InspectorGUI()
        {

            var obj = base.InspectorGUI() as ObjectScale;

            obj.scaleSize = InputField(obj.scaleSize,"拡縮を行うサイズ","ObjectScaleを利用する場合は基本的にMethodを利用して拡縮を行わせます。");

            BeginObjectUpdate();

            UpdateProperty(obj.scaleSize, "scaleSize");

            EndObjectUpdate();

            return obj;
        }
    }

}
