/**
* @file CustomInspectorBase.cs
* @brief CustomInspectorを開発する際の基盤となるクラス
* @author Chronoss0518
* @date 2022/01/02
* @details UnityではInspectorの見た目を変更することが可能で、こちらを利用するとScriptごとのInspectoを開発する手間を軽減させることが可能
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   Editorを継承したCustom Inspectorの開発を容易にするためのクラス。
* @details 必要だと思われる機能を内包したクラス。Editorも内包しているため、Attributeの「CustomEditor」のみ必要となる。
*/


namespace ChUnity
{
    
    public class CustomInspectorBase : Editor
    {

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //BaseFunction//

        /**
       * @fn void Line()
       * @brief Inspectorを区切るためのラインを作る。
       */
        protected bool MSGBox(in string _title,in string _description,in string _ok = "OK!",in string _no = "")
        {
            if(string.IsNullOrWhiteSpace(_no)) EditorUtility.DisplayDialog(_title, _description, _ok);
            return EditorUtility.DisplayDialog(_title,_description,_ok,_no);
        }

        /**
       * @fn void Line()
       * @brief Inspectorを区切るためのラインを作る。
       */
        protected void Line()
        {
            BoxSameWidthInspector(1);
        }

        /**
       * @fn void BoxSameWidthInspector(in float _height, in string _text = "")
       * @brief Inspectorの幅と同じサイズのBoxを作成する。
       */
        protected void BoxSameWidthInspector(in float _height, in string _text = "")
        {
            GUILayout.Box(_text, GUILayout.ExpandWidth(true), GUILayout.Height(_height));
        }

        /**
       * @fn void Label(in string _str)
       * @brief Inspector上に文字を書く
       */
        protected void Label(in string _str)
        {
            EditorGUILayout.LabelField(_str);
        }

        /**
       * @fn void HelpBox(in string _description, in MessageType _type = MessageType.Info)
       * @brief Helpboxを作成する
       */
        protected void HelpBox(in string _description, in MessageType _type = MessageType.Info)
        {
            if (string.IsNullOrWhiteSpace(_description)) return;

            EditorGUILayout.HelpBox(_description, _type);
        }

        /**
       * @fn void VerticalSpace(in float _size)
       * @brief Inspectorの項目と項目の間に空白を入れる。
       */
        protected void VerticalSpace(in float _size)
        {
            GUILayout.Space(_size);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //PairFunctions//

        /**
       * @fn void BeginToggleGroup(ref bool _flg,in string _name)
       * @brief 複数のBeginToggleGroupを設置して、終りにEndToggleGroupを置く
       */
        protected void BeginToggleGroup(ref bool _flg, in string _name)
        {
            EditorGUILayout.BeginToggleGroup(_name, _flg);
        }

        /**
       * @fn void BeginToggleGroup(bool _flg,in string _name)
       * @brief 複数のBeginToggleGroupを設置して、終りにEndToggleGroupを置く
       */
        protected void BeginToggleGroup(bool _flg, in string _name)
        {
            EditorGUILayout.BeginToggleGroup(_name, _flg);
        }

        /**
       * @fn void EndToggleGroup()
       * @brief 複数のBeginToggleGroupを設置して、終りにEndToggleGroupを置く
       */
        protected void EndToggleGroup()
        {
            EditorGUILayout.EndToggleGroup();
        }

        /**
       * @fn void BeginHorizontal()
       * @brief 同じ高さにInspectorの機能を配置する。EndHorizontalを使用する前に利用する。
       */
        protected void BeginHorizontal()
        {
            EditorGUILayout.BeginHorizontal();
        }

        /**
       * @fn void EndHorizontal()
       * @brief 同じ高さにInspectorの機能を配置する。BeginHorizontalを使用した後に利用する。
       */
        protected void EndHorizontal()
        {
            EditorGUILayout.EndHorizontal();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //IsFunction//

        /**
       * @fn bool IsFoldOut(ref bool _flg, in string _name)
       * @brief 対象のグループを折りたためるようにし、グループが展開されており確認できることを確認する。
       */
        protected bool IsExtractFoldOut(in bool _flg, in string _name)
        {
            return EditorGUILayout.Foldout(_flg, _name);
        }

        /**
       * @fn bool IsPushButton(in string _name)
       * @brief Buttonを表示し、Buttonが押されたかを確認する。
       */
        protected bool IsPushButton(in string _name)
        {
            return GUILayout.Button(_name);
        }

        /**
       * @fn bool Toggle(ref bool _flg, in string _title, in string _description = "")
       * @brief チェックされていることを確認する
       */
        protected bool IsTrueToggle(in bool _flg, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            return EditorGUILayout.Toggle(_flg);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //Slider//

        /**
       * @fn void Slider(ref float _val, in float _low, in float _high, in string _title, in string _description = "")
       * @brief float型の値をバーをスライドして調節させる。
       */
        protected float Slider(in float _val, in float _low, in float _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            return EditorGUILayout.Slider(_val, _low, _high);
        }

        /**
       * @fn void Slider(ref int _val, in int _low, in int _high, in string _title, in string _description = "")
       * @brief int型の値をバーをスライドして調節させる。
       */
        protected int Slider(in int _val, in int _low, in int _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            return EditorGUILayout.IntSlider(_val, _low, _high);
        }

        /**
       * @fn void Slider(ref Vector2 _val, in Vector2 _low, in Vector2 _high, in string _title, in string _description = "")
       * @brief Vector2型の値をバーをスライドして調節させる。
       */
        protected Vector2 Slider(in Vector2 _val, in Vector2 _low, in Vector2 _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);

            Vector2 res = _val;

            BeginHorizontal();
            res.x = Slider(res.x, _low.x, _high.x, "x");
            EndHorizontal();

            BeginHorizontal();
            res.y = Slider(res.y, _low.y, _high.y, "y");
            EndHorizontal();
            return res;
        }

        /**
       * @fn void Slider(ref Vector2Int _val, in Vector2Int _low, in Vector2Int _high, in string _title, in string _description = "")
       * @brief Vector2Int型の値をバーをスライドして調節させる。
       */
        protected Vector2Int Slider(in Vector2Int _val, in Vector2Int _low, in Vector2Int _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            Vector2Int res = _val;
            BeginHorizontal();
            res.x = Slider(res.x, _low.x, _high.x, "x");
            EndHorizontal();

            BeginHorizontal();
            res.y = Slider(res.y, _low.y, _high.y, "y");
            EndHorizontal();

            return res;
        }

        /**
       * @fn void Slider(ref Vector3 _val, in Vector3 _low, in Vector3 _high, in string _title, in string _description = "")
       * @brief Vector3型の値をバーをスライドして調節させる。
       */
        protected Vector3 Slider(in Vector3 _val, in Vector3 _low, in Vector3 _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);

            Vector3 res = _val;

            BeginHorizontal();
            res.x = Slider(res.x, _low.x, _high.x, "x");
            EndHorizontal();

            BeginHorizontal();
            res.y = Slider(res.y, _low.y, _high.y, "y");
            EndHorizontal();

            BeginHorizontal();
            res.z = Slider(res.z, _low.z, _high.z, "z");
            EndHorizontal();

            return res;
        }

        /**
       * @fn void Slider(ref Vector3Int _val, in Vector3Int _low, in Vector3Int _high, in string _title, in string _description = "")
       * @brief Vector3Int型の値をバーをスライドして調節させる。
       */
        protected Vector3Int Slider(in Vector3Int _val, in Vector3Int _low, in Vector3Int _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);

            Vector3Int res = _val;
            BeginHorizontal();
            res.x = Slider(res.x, _low.x, _high.x, "x");
            EndHorizontal();

            BeginHorizontal();
            res.y = Slider(res.y, _low.y, _high.y, "y");
            EndHorizontal();

            BeginHorizontal();
            res.z = Slider(res.z, _low.z, _high.z, "z");
            EndHorizontal();

            return res;
        }

        /**
       * @fn void Slider(ref Vector4 _val, in Vector4 _low, in Vector4 _high, in string _title, in string _description = "")
       * @brief Vector4型の値をバーをスライドして調節させる。
       */
        protected Vector4 Slider(in Vector4 _val, in Vector4 _low, in Vector4 _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);

            Vector4 res = _val;

            BeginHorizontal();
            res.x = Slider(res.x, _low.x, _high.x, "x");
            EndHorizontal();

            BeginHorizontal();
            res.y = Slider(res.y, _low.y, _high.y, "y");
            EndHorizontal();

            BeginHorizontal();
            res.z = Slider(res.z, _low.z, _high.z, "z");
            EndHorizontal();

            BeginHorizontal();
            res.w = Slider(res.w, _low.w, _high.w, "w");
            EndHorizontal();

            return res;
        }

        /**
       * @fn void RangeSlider(ref float _lowVal, ref float _highVal, in float _low, in float _high, in string _title, in string _description = "")
       * @brief float型の範囲情報を取得する
       */
        protected void RangeSlider(ref float _lowVal, ref float _highVal, in float _low, in float _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            EditorGUILayout.MinMaxSlider(ref _lowVal, ref _highVal, _low, _high);
        }

        /**
       * @fn void RangeSlider(ref Vector2 _val, in Vector2 _range, in string _title, in string _description = "")
       * @brief Vector2型の範囲情報(xがlow、yがhigh)を取得する
       */
        protected void RangeSlider(ref Vector2 _val, in Vector2 _range, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            float lowVal = _val.x;
            float highVal = _val.y;
            float low = _range.x;
            float high = _range.y;
            EditorGUILayout.MinMaxSlider(ref lowVal, ref highVal, low, high);

            _val.x = lowVal;
            _val.y = highVal;

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //InputField//


        /**
       * @fn void InputField(ref string _val, in string _title, in string _description = "")
       * @brief Textを入力する
       */
        protected string InputField(in string _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);

            return EditorGUILayout.TextField(_val);
        }

        /**
       * @fn void InputField(ref int _val, in string _title, in string _description = "")
       * @brief Intを入力する
       */
        protected int InputField(in int _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            return EditorGUILayout.IntField(_val);
        }

        /**
       * @fn void InputField(ref float _val, in string _title, in string _description = "")
       * @brief Intを入力する
       */
        protected float InputField(in float _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            return EditorGUILayout.FloatField(_val);
        }

        /**
       * @fn void InputField(ref Vector2 _val, in string _title, in string _description = "")
       * @brief Vector2を入力する
       */
        protected Vector2 InputField(in Vector2 _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            return EditorGUILayout.Vector2Field("", _val);
        }

        /**
       * @fn void InputField(ref Vector2Int _val, in string _title, in string _description = "")
       * @brief Vector2を入力する
       */
        protected Vector2Int InputField(in Vector2Int _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            return EditorGUILayout.Vector2IntField("", _val);
        }

        /**
       * @fn void InputField(ref Vector3 _val, in string _title, in string _description = "")
       * @brief Vector2を入力する
       */
        protected Vector3 InputField(in Vector3 _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            return EditorGUILayout.Vector3Field("", _val);
        }

        /**
       * @fn void InputField(ref Vector3Int _val, in string _title, in string _description = "")
       * @brief Vector2を入力する
       */
        protected Vector3Int InputField(in Vector3Int _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            return EditorGUILayout.Vector3IntField("", _val);
        }

        /**
       * @fn void InputField(ref Vector4 _val, in string _title, in string _description = "")
       * @brief Vector2を入力する
       */
        protected Vector4 InputField(Vector4 _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            return EditorGUILayout.Vector4Field("", _val);
        }

        /**
       * @fn void InputField(ref Object _val, in string _title, in string _description = "")
       * @brief Objectを入力する
       */
        protected Object InputField<T>(in Object _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            return EditorGUILayout.ObjectField("", _val, typeof(T), true);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //Popup//

        /**
       * @fn void EnumPopup(ref System.Enum _val, in string _title, in string _description = "")
       * @brief Enumを選択させるポップアップを表示
       */
        protected System.Enum EnumPopup(in System.Enum _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            return EditorGUILayout.EnumPopup("", _val);
        }

        protected int TextPopup(in int _selectNum, in string[] _stringList, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);

            return EditorGUILayout.Popup(_selectNum, _stringList);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //PropertyControl//

        /**
       * @fn void PropertyField(ref SerializedProperty _object, in string _title, in string _description = "")
       * @brief Unityで利用されるクラスを設定する
       */
        protected void PropertyField(in string _propertyName, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);

            serializedObject.Update();

            SerializedProperty property = serializedObject.FindProperty(_propertyName);

            EditorGUILayout.PropertyField(property);

            serializedObject.ApplyModifiedProperties();

        }

        protected void PropertyField(in SerializedProperty _prop, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);

            _prop.serializedObject.Update();

            EditorGUILayout.PropertyField(_prop);

            _prop.serializedObject.ApplyModifiedProperties();

        }
        protected Object SerializeObjectToObject(in string _propertyName)
        {
            serializedObject.Update();

            SerializedProperty property = serializedObject.FindProperty(_propertyName);

            return property.objectReferenceValue;

        }

        protected void ObjectToSerializeObject(in string _propertyName,in Object _obj)
        {
            SerializedProperty property = serializedObject.FindProperty(_propertyName);

            property.objectReferenceValue = _obj;
            serializedObject.ApplyModifiedProperties();

        }

    }

}
