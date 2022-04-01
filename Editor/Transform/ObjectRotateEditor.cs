/**
* @file ObjectRotateEditor.cs
* @brief ObjectRotate�X�N���v�g��Inspector���J�X�^�}�C�Y��������
* @author Chronoss0518
* @date 2022/03/29
* @details ObjectRotate�X�N���v�g�𑀍삵�₷���悤��Inspector���J�X�^�}�C�Y��������
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditor���p������ObjectRotateEditor
*/

namespace ChUnity.Transform
{

    [CustomEditor(typeof(ObjectRotate))]
    public class ObjectRotateEditor : Common.GameObjectTargetSelectorEditor
    {

        private void OnEnable()
        {
            targetObjectDescription = "��]����I�u�W�F�N�g";
        }

        /**
       * @fn public void OnInspectorGUI()
       * @brief Inspector��GUI��ύX����֐��B
       */
        public override Object InspectorGUI()
        {

            var obj = base.InspectorGUI() as ObjectRotate;

            obj.rotSize = InputField(obj.rotSize, "��]���x");

            obj.autoRotateAxis = (Axis)EnumPopup(obj.autoRotateAxis, "�����ŉ�]���s���t���O");

            BeginObjectUpdate();

            UpdateProperty(obj.rotSize, "rotSize");

            UpdateProperty((int)obj.autoRotateAxis, "autoRotateAxis");

            EndObjectUpdate();

            return obj;
        }
    }

}
