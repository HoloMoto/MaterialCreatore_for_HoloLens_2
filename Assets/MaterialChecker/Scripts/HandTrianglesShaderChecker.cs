using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;

public class HandTrianglesShaderChecker : MonoBehaviour
{
    Color _fillColor;
    Color _lineColor;
    Vector3 _pulseOrigin;
    public GameObject target;
    public Material _handMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PulseOrigin();
    }
    public void PulseOrigin()
    {
        _pulseOrigin = target.transform.position;
        _handMaterial.SetVector("_Pulse_Origin_", _pulseOrigin);
    }
    public void Intensity(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("Intensity").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue *5f;
        text.text = "Intensity ="+value;
        _handMaterial.SetFloat("_Intensity_",value);
    }
    public void VaryUV (SliderEventData data)
    {
        TMP_Text text = GameObject.Find("VaryUV").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "VaryUV =" + value;
        _handMaterial.SetFloat("_Vary_UV_", value);
    }
    public void VaryColor(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("VaryColor").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "VaryColor =" + value;
        _handMaterial.SetFloat("_Vary_Color_", value);
    }
    public void DesaturatedIntensity(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("DesaturatedIntensity").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "DesaturatedIntensity =" + value;
        _handMaterial.SetFloat("_Desaturated_Intensity_", value);
    }
    public void FillColorR(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("FillColorR").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue * 255f;
        text.text = "FillColor Red =" + value;
        _fillColor.r = value;
        _handMaterial.SetColor("_Fill_Color_", _fillColor);
    }
    public void FillColorG(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("FillColorG").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue * 255f;
        text.text = "FillColor Green =" + value;
        _fillColor.g = value;
        _handMaterial.SetColor("_Fill_Color_", _fillColor);
    }
    public void FillColorB(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("FillColorB").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue * 255f;
        text.text = "FillColor Blue =" + value;
        _fillColor.b = value;
        _handMaterial.SetColor("_Fill_Color_", _fillColor);
    }
    public void LineColorR(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("LineColorR ").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue * 255f;
        text.text = "LineColor Red =" + value;
        _lineColor.r = value;
        _handMaterial.SetColor("_Line_Color_", _lineColor);
    }
    public void LineColorG(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("LineColorG").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue * 255f;
        text.text = "LineColor Green =" + value;
        _lineColor.g = value;
        _handMaterial.SetColor("_Line_Color_", _lineColor);
    }
    public void LineColorB(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("LineColorB ").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue * 255f;
        text.text = "LineColor Blue =" + value;
        _lineColor.b = value;
        _handMaterial.SetColor("_Line_Color_", _lineColor);
    }
    public void EdgeWidth(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("EdgeWidth").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue * 10f;
        text.text = "EdgeWidth =" + value;
        _handMaterial.SetFloat("_Edge_Width_", value);
    }
    public void FilterWidth(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("FillterWidth").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue *10f;
        text.text = "FilterWidth =" + value;
        _handMaterial.SetFloat("_Filter_Width_", value);
    }
    public void PulseWidth(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("pulseWidth").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue *5f;
        text.text = "PulseWidth =" + value;
        _handMaterial.SetFloat("_Pulse_Width_", value);
    }
    public void PulseOuterSize(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("PulseOuterSize").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue*2f;
        text.text = "Pulse_Outer_Size =" + value;
        _handMaterial.SetFloat("_Pulse_Outer_Size_", value);
    }
    public void PulseLeadFuzz(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("PulseLeadFuzz").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "PulseLeadFuzz =" + value;
        _handMaterial.SetFloat("_Pulse_Lead_Fuzz_", value);
    }
    public void PulseTailFuzz(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("PulseTailFuzz").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "PulseTailFuzz =" + value;
        _handMaterial.SetFloat("_Pulse_Tail_Fuzz_", value);
    }
    public void PulseVary(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("PulseVary").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "PulseVary =" + value;
        _handMaterial.SetFloat("_Pulse_Vary_", value);
    }
    public void PulseLineFuzz(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("Intensity").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "EdgeEidth =" + value;
        _handMaterial.SetFloat("_Pulse_Line_Fuzz_", value);
    }
    public void PulseNoiseFrequency(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("PulseNoiseFrequency").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue *100f;
        text.text = "PulseNoiseFrequency =" + value;
        _handMaterial.SetFloat("_Pulse_Noise_Frequency_", value);
    }
 
    public void PulseColorWidth (SliderEventData data)
    {
        TMP_Text text = GameObject.Find("PulseColorWidth").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "PulseColorWidth =" + value;
        _handMaterial.SetFloat("_Pulse_Color_Width_", value);
    }
    public void PulseAmplifyLeading(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("PulseAmplifyLeading").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue * 2f;
        text.text = "PulseAmplifyLeading =" + value;
        _handMaterial.SetFloat("_Pulse_Amplify_Leading_", value);
    }
    public void Period(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("Period").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue * 20f;
        text.text = "Period =" + value;
        _handMaterial.SetFloat("_Period_", value);
    }
    public void LineEndTime(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("LineEndTime").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue ;
        text.text = "LineEndTime =" + value;
        _handMaterial.SetFloat("_Line_End_Time_", value);
    }
    public void FillStartTime(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("FillStartTime").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "FillStartTime=" + value;
        _handMaterial.SetFloat("_Fill_Start_Time_", value);

    }
    //WristFadeStart
    public void WristFadeStart(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("WristFadeStart").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "WristFadeStart =" + value;
        _handMaterial.SetFloat("_Wrist_Fade_Start_", value);
    }
    public void WristFadeEnd(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("WristFadeEnd").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "WristFadeEnd =" + value;
        _handMaterial.SetFloat("_Wrist_Fade_End_", value);
    }
    //MaxHover
    public void MaxHover(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("MaxHover").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "MaxHover =" + value;
        _handMaterial.SetFloat("_Max_Hover_", value);
    }
    //MaxInAngle
    public void MaxInAngle(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("MaxInAngle").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "MaxInAngle =" + value;
        _handMaterial.SetFloat("_Max_In_Angle_", value);
    }
    public void MaxOutAngle(SliderEventData data)
    {
        TMP_Text text = GameObject.Find("MaxOutAngle").GetComponentInChildren<TMP_Text>();
        float value = data.NewValue;
        text.text = "MaxOutAngle =" + value;
        _handMaterial.SetFloat("_Max_Out_Angle_", value);
    }
}
