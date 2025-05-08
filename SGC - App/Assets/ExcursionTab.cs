using TMPro;
using UnityEngine;

public class ExcursionTab : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI excursionTitle;
    [SerializeField] private TextMeshProUGUI excursionDescription;
    [SerializeField] private TextMeshProUGUI excursionStartDate;
    [SerializeField] private TextMeshProUGUI excursionEndDate;

    public void SetExcursionData(string title, string description, string startDate, string endDate)
    {
        excursionTitle.text = title;
        excursionDescription.text = description;
        excursionStartDate.text = startDate;
        excursionEndDate.text = endDate;
    }
}
