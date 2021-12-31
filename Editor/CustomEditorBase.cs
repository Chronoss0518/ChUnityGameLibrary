using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class CustomEditorBase : Editor
{
    protected void Line()
    {
        BoxSameWidthInspector(1);
    }

    protected void BoxSameWidthInspector(float _height, string _text = "")
    {

        GUILayout.Box(_text, GUILayout.ExpandWidth(true), GUILayout.Height(_height));
    }

    protected void Slider(ref float _val,float _low,float _high,string _title, string _description = "")
    {
        Label(_title);
        _val = EditorGUILayout.Slider(_val, _low, _high);
    }
    protected void Slider(ref int _val, int _low, int _high, string _title, string _description = "")
    {
        Label(_title);
        _val = EditorGUILayout.IntSlider(_val, _low, _high);
    }
    protected void RangeSlider(ref float _lowVal,ref float _highVal, float _low, float _high, string _title, string _description = "")
    {
        Label(_title);
        EditorGUILayout.MinMaxSlider(ref _lowVal,ref _highVal,_low ,_high);
    }

    protected void Label(string _str)
    {
        EditorGUILayout.LabelField(_str);
    }

    protected void HelpBox(string _description)
    {
        if (_description == null) return;


    }

    protected void Groups(Delegate _delegate)
    {



    }

    protected void VerticalSpace(int _size)
    {

    }

}
