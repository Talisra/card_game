using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUi : MonoBehaviour
{
    #region Fields
    public string clockFormat = "{0:2D}:{1:2D}";
    public Image uiTimerBarShaped;
    public Text uiTimerClockShaped;

    private float _maxTurnTime;
    private Dictionary<CounterType, Action<float>> counterTypeToUpdateFunction = new Dictionary<CounterType, Action<float>>();
        
    #endregion

    private void Start()
    {
        counterTypeToUpdateFunction.Add(CounterType.Bar, UpdateTimeLeftOfProgressBar);
        counterTypeToUpdateFunction.Add(CounterType.Clock, UpdateTimeLeftOfTextField);
    }

    #region Public Functions

    public void ConfigureTimerVisuals(CounterType counterType, float turnTime)
    {
        _maxTurnTime = turnTime;
        if (counterType == CounterType.Bar)
        {
            uiTimerBarShaped.gameObject.SetActive(true);
            uiTimerBarShaped.fillAmount = 1;
        }
        else
        {
            uiTimerClockShaped.gameObject.SetActive(true);
            uiTimerClockShaped.text = string.Format(clockFormat, turnTime, 0);
        }
    }

    public void UpdateVisuals(CounterType counterType, float remainingTime)
    {
        counterTypeToUpdateFunction[counterType](remainingTime);
    }
    #endregion

    #region Private Functions
    private void UpdateTimeLeftOfProgressBar(float remainingTime)
    {
        uiTimerBarShaped.fillAmount = remainingTime / _maxTurnTime;
    }

    private void UpdateTimeLeftOfTextField(float remainingTime)
    {
        var remainingTimeAsParts = remainingTime.ToString("0.00").Split('.');
        uiTimerClockShaped.text = string.Format(clockFormat, remainingTimeAsParts[0], remainingTimeAsParts[1]);
    }
    #endregion

}
