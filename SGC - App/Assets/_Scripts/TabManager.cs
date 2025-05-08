using UnityEngine;

public class TabManager : MonoBehaviour
{
    [SerializeField] private GameObject excursionsList;
    [SerializeField] private GameObject createExcursionTab;
    [SerializeField] private GameObject faiFairTab;

    public GameObject mainMenuTab;
    public GameObject excursionsTab;
    public void OpenCreateExcursionTab()
    {
        excursionsList.SetActive(false);
        createExcursionTab.SetActive(true);
    }
    
    public void CloseCreateExcursionTab()
    {
        excursionsList.SetActive(true);
        createExcursionTab.SetActive(false);
    }

    public void OpenExcursionsTab()
    {
        mainMenuTab.SetActive(false);
        excursionsTab.SetActive(true);
    }

    public void OpenMainMenuTab()
    {
        mainMenuTab.SetActive(true);
        excursionsTab.SetActive(false);
    }

    public void OpenFaiFair()
    {
        excursionsTab.SetActive(false);
        faiFairTab.SetActive(true);
    }
}
