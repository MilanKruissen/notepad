using TMPro;
using UnityEngine;

public class FaiFairData : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI faiFairTitleTxt;
    [SerializeField] private TextMeshProUGUI faiFairDescriptionTxt;
    [SerializeField] private TextMeshProUGUI faiFairDateTxt;
    
    // Excursion Data
    private string _faiFairTitle;
    private string _faiFairDescription;
    private string _faiFairDate;
    
    public void SetData(string faiFairTitle, string faiFairDescription, string faiFairDate)
    {
        _faiFairTitle = faiFairTitle;
        _faiFairDescription = faiFairDescription;
        _faiFairDate = faiFairDate;
        
        faiFairTitleTxt.text = _faiFairTitle;
        faiFairDescriptionTxt.text = _faiFairDescription;
        faiFairDateTxt.text = _faiFairDate;
    }

    public void OpenExcursion()
    {
        // When pressing the faifair, open the fai fair and set title, description and date
        
        
        // FindAnyObjectByType<TabManager>().OpenExcursionsTab();
        // FindAnyObjectByType<TabManager>().excursionsTab.GetComponent<ExcursionTab>().SetExcursionData(_faiFairTitle, _faiFairDescription, _faiFairDate);
    }
}
