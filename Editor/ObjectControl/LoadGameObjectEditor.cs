/**
* @file LoadGameObjectEditor.cs
* @brief LoadGameObject�X�N���v�g��Inspector���J�X�^�}�C�Y��������
* @author Chronoss0518
* @date 2022/01/02
* @details LoadGameObject�X�N���v�g�𑀍삵�₷���悤��Inspector���J�X�^�}�C�Y��������
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditor���p������LoadGameObjectEditor
*/

namespace ChUnity.ObjectControl
{


    [CustomEditor(typeof(LoadGameObject))]
    public class LoadGameObjectEditor : Common.GameObjectTargetSelectorEditor
    {

        protected void OnEnable()
        {
            targetObjectDescription = "��������I�u�W�F�N�g";
        }
        /**
       * @fn public void OnInspectorGUI()
       * @brief Inspector��GUI��ύX����֐��B
       */
        public override Object InspectorGUI()
        {

            var obj = base.InspectorGUI() as LoadGameObject;

            obj.baseGameObject = (GameObject)InputField<GameObject>(obj.baseGameObject, "�I�u�W�F�N�g�𐶐�����ʒu�̊�{�ƂȂ�I�u�W�F�N�g");

            BeginObjectUpdate();

            UpdateProperty(obj.baseGameObject, "baseObejct");

            EndObjectUpdate();

            return obj;
        }
    }

}
