using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ExcursionManager : MonoBehaviour
{
    [SerializeField] private Button addExcursionPlusButton;
    [SerializeField] private TabManager tabManager;
    
    void Start()
    {
        addExcursionPlusButton.onClick.AddListener(OpenOefeningCreeerTab);
    }

    void OpenOefeningCreeerTab()
    {
        tabManager.OpenCreateExcursionTab();
    }
}

