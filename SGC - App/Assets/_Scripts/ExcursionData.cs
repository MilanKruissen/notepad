using System;
using TMPro;
using UnityEngine;

public class ExcursionData : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI excursionTitleTxt;
    [SerializeField] private TextMeshProUGUI excursionDescriptionTxt;
    
    [SerializeField] private TextMeshProUGUI startDateTxt;
    [SerializeField] private TextMeshProUGUI endDateTxt;

    
    // Excursion Data
    private string _excursionTitle;
    private string _excursionDescription;
    private string _startDate;
    private string _endDate;
    
    public void SetData(string excursionTitle, string excursionDescription, string startDate, string endDate)
    {
        _excursionTitle = excursionTitle;
        _excursionDescription = excursionDescription;
        _startDate = startDate;
        _endDate = endDate;
        
        excursionTitleTxt.text = _excursionTitle;
        excursionDescriptionTxt.text = _excursionDescription;
        startDateTxt.text = _startDate;
        endDateTxt.text = _endDate;
    }

    public void OpenExcursion()
    {
        FindAnyObjectByType<TabManager>().OpenExcursionsTab();
        FindAnyObjectByType<TabManager>().excursionsTab.GetComponent<ExcursionTab>().SetExcursionData(_excursionTitle, _excursionDescription, _startDate, _endDate);
    }
}

