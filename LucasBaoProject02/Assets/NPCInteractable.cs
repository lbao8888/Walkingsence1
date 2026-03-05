using UnityEngine;

public class NPCInteractable : Interactable
{
    public NPCData npcData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Interact()
    {
        if(npcData == null)
        {
            Debug.Log("npc has no data: " + gameObject.name); 
        }
    

    }
}
