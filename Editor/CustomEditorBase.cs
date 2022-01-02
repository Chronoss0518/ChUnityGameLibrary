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

    protected void StartGroup()
    {
        EditorGUILayout.BeginHorizontal();
    }

    protected void EndGroup()
    {
        EditorGUILayout.EndHorizontal();
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
    protected void Slider(ref Vector2 _val, Vector2 _low, Vector2 _high, string _title, string _description = "")
    {
        Label(_title);

        StartGroup();
        Slider(ref _val.x, _low.x, _high.x, "x");
        EndGroup();

        StartGroup();
        Slider(ref _val.y, _low.y, _high.y, "y");
        EndGroup();

    }
    protected void Slider(ref Vector3 _val, Vector3 _low, Vector3 _high, string _title, string _description = "")
    {
        Label(_title);

        StartGroup();
        Slider(ref _val.x, _low.x, _high.x, "x");
        EndGroup();

        StartGroup();
        Slider(ref _val.y, _low.y, _high.y, "y");
        EndGroup();

        StartGroup();
        Slider(ref _val.z, _low.z, _high.z, "z");
        EndGroup();
    }
    protected void Slider(ref Vector4 _val, Vector4 _low, Vector4 _high, string _title, string _description = "")
    {
        Label(_title);

        StartGroup();
        Slider(ref _val.x, _low.x, _high.x, "x");
        EndGroup();

        StartGroup();
        Slider(ref _val.y, _low.y, _high.y, "y");
        EndGroup();

        StartGroup();
        Slider(ref _val.z, _low.z, _high.z, "z");
        EndGroup();

        StartGroup();
        Slider(ref _val.w, _low.w, _high.w, "w");
        EndGroup();
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
