using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ReflectProbeDelay : UdonSharpBehaviour
{
    public bool ToggleUpdateReflects = true;
    public float Delay = 0.5f;
    private float _timerCount;
    public ReflectionProbe ReflectionProbeObject;
    private void Update()
    {
        if(ToggleUpdateReflects)
        {
            if(_timerCount >= Delay)
            {
                ReflectionProbeObject.RenderProbe();
                _timerCount = 0;
            }
            else
            {
                _timerCount += Time.deltaTime;
            }
        }
    }
}
