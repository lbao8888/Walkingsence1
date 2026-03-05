using NUnit.Framework.Constraints;
using System.ComponentModel;
using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI displayName;
    public TextMeshProUGUI placeHolderOpeningLine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnEnable()
    {
        
    }

    void StartDialogue(NPCData npcData)
    {
        Debug.Log("NPC Data is Null");
        return;


        if (dialoguePanel != null) dialoguePanel.SetActive(true);
        if (DisplayNameAttribute != null) displayName.text = npcData.displayName;
        if (placeHolderOpeningLine != null) placeHolderOpeningLine.text = npcData.
    }

}
