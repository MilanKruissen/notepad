using UnityEngine;
using UnityEngine.UI;

public class FaiFairManager : MonoBehaviour
{
    // Voorbereidingen
    [SerializeField] private Button addVoorbereidingButton;
    [SerializeField] private GameObject voorbereidingContents;
    
    // Uitvoeringen
    [SerializeField] private Button addUitvoeringButton;
    [SerializeField] private GameObject uitvoeringContents;
    
    // Feedback
    [SerializeField] private Button addFeedbackButton;
    [SerializeField] private GameObject feedbackContents;
    
    // Overige punten
    [SerializeField] private Button addOverigPuntButton;
    [SerializeField] private GameObject overigePuntenContents;
    
    // Data
    [SerializeField] private GameObject faiFairTemplate;
    [SerializeField] private GameObject upperParentLayout;
    [SerializeField] private GameObject parentLayout;
    
    private void Start()
    {
        addVoorbereidingButton.onClick.AddListener(CreateNewVoorbereiding);
        addUitvoeringButton.onClick.AddListener(CreateNewUitvoering);
        addFeedbackButton.onClick.AddListener(CreateNewFeedback);
        addOverigPuntButton.onClick.AddListener(CreateNewVoorOverigPunt);
    }

    void CreateNewVoorbereiding()
    {
        Instantiate(faiFairTemplate, voorbereidingContents.transform);
        UpdateLayout();
    }
    
    void CreateNewUitvoering()
    {
        Instantiate(faiFairTemplate, uitvoeringContents.transform);
        UpdateLayout();
    }
    
    void CreateNewFeedback()
    {
        Instantiate(faiFairTemplate, feedbackContents.transform);
        UpdateLayout();
    }
    
    void CreateNewVoorOverigPunt()
    {
        Instantiate(faiFairTemplate, overigePuntenContents.transform);
        

        
        UpdateLayout();
    }

    void UpdateLayout()
    {
        {
            foreach (var layoutGroup in upperParentLayout.GetComponentsInChildren<VerticalLayoutGroup>())
            {
                LayoutRebuilder.ForceRebuildLayoutImmediate(layoutGroup.GetComponent<RectTransform>());
            }
        }
        
        LayoutRebuilder.ForceRebuildLayoutImmediate(parentLayout.GetComponent<RectTransform>());
        LayoutRebuilder.ForceRebuildLayoutImmediate(overigePuntenContents.GetComponent<RectTransform>());
        LayoutRebuilder.ForceRebuildLayoutImmediate(upperParentLayout.GetComponent<RectTransform>());
    }
}
