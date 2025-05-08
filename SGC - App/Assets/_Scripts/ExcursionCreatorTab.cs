using UnityEngine;

public class InputFieldGrabber : MonoBehaviour
{
    [Header("The value we got from the title input field")] 
    [SerializeField] private string titleInputText;
    
    [Header("The value we got from the description input field")] 
    [SerializeField] private string descriptionInputText;
    
    // Start date
    [Header("The value we got from the start date input field")] 
    [SerializeField] private int startDateDayInput;
    [SerializeField] private int startDateMonthInput;
    [SerializeField] private int startDateYearInput;
    
    // End date
    [Header("The value we got from the end date input field")] 
    [SerializeField] private int endDateDayInput;
    [SerializeField] private int endDateMonthInput;
    [SerializeField] private int endDateYearInput;
    
    [SerializeField] private string startDate;
    [SerializeField] private string endDate;
    
    public GameObject excursionPrefab;
    public Transform excursionContent; 

    void CreateExcursion()
    {
        SetStartDateString();
        SetEndDateString();
        
        GameObject excursion = Instantiate(excursionPrefab, excursionContent);
        excursion.GetComponent<ExcursionData>().SetData(titleInputText, descriptionInputText, startDate, endDate);
        
        FindFirstObjectByType<TabManager>().CloseCreateExcursionTab();
    }

    // Title
    public void GetTitleFromInputField(string input)
    {
        titleInputText = input;
    }
    
    // Description
    public void GetDescriptionFromInputField(string input)
    {
        descriptionInputText = input;
    }
    
    // Start day
    public void GetStartDateDay(string input)
    {
        startDateDayInput = int.Parse(input);
    }
    
    public void GetStartDateMonth(string input)
    {
        startDateMonthInput = int.Parse(input);
    }
    
    public void GetStartDateYear(string input)
    {
        startDateYearInput = int.Parse(input);
    }

    void SetStartDateString()
    {
        startDate = $"{startDateDayInput:D2} - {startDateMonthInput:D2} - {startDateYearInput}";
    }
    
    // End day
    public void GetEndDateDay(string input)
    {
        endDateDayInput = int.Parse(input);
    }
    
    public void GetEndDateMonth(string input)
    {
        endDateMonthInput = int.Parse(input);
    }
    
    public void GetEndDateYear(string input)
    {
        endDateYearInput = int.Parse(input);
    }
    
    void SetEndDateString()
    {
        endDate = $"{endDateDayInput:D2} - {endDateMonthInput:D2} - {endDateYearInput}";
    }
}
