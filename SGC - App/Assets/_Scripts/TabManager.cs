using UnityEngine;

public class TabManager : MonoBehaviour
{
    [SerializeField] private GameObject excursionsTab;
    [SerializeField] private GameObject createExcursionTab;

    public void OpenCreateExcursionTab()
    {
        excursionsTab.SetActive(false);
        createExcursionTab.SetActive(true);
    }
    
    public void CloseCreateExcursionTab()
    {
        excursionsTab.SetActive(true);
        createExcursionTab.SetActive(false);
    }
}
