using UnityEngine;
using UnityEngine.UI;

public class ObjectInteraction : MonoBehaviour
{
    public GameObject interactionText; // Reference to the UI text object
    public Text interactionTextComponent; // Reference to the Text component
    public Text interactionHiddenTextComponent; // Reference to the Text component
    public string interactionMessage = "Press E to interact with triangle."; // Default interaction message
    public string interactionHiddenMessage = "Maybe Other Way"; // Default interaction message
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            // Show interaction text when the player enters the trigger area
            interactionText.SetActive(true);
            
            interactionTextComponent.text = interactionMessage; // Set the interaction message
            interactionHiddenTextComponent.text = interactionHiddenMessage; // Set the interaction message
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Hide interaction text when the player exits the trigger area
            interactionText.SetActive(false);
        }
    }
}
