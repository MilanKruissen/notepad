using System;
using TMPro;
using UnityEngine;

public class SetExcursionData : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI excursionTitleTxt;
    [SerializeField] private TextMeshProUGUI excursionDescriptionTxt;
    
    [SerializeField] private TextMeshProUGUI startDateTxt;
    [SerializeField] private TextMeshProUGUI endDateTxt;

    public void SetData(string excursionTitle, string excursionDescription, string startDate, string endDate)
    {
        excursionTitleTxt.text = excursionTitle;
        excursionDescriptionTxt.text = excursionDescription;
        startDateTxt.text = startDate;
        endDateTxt.text = endDate;
    }
}

