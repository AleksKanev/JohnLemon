using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    public string noteText; // Set note text in the inspector
    public GameObject uiTextObject; // Assign the UI text object to this

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiTextObject.SetActive(true); // Display the note text
            uiTextObject.GetComponent<Text>().text = noteText;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiTextObject.SetActive(false); // Hide the note text when the player leaves
        }
    }
}
