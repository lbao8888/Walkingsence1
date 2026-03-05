using UnityEngine;

public class DestroyInteractable : Interactable
{
    public override void Interact(CCPlayer cCPlayer)
    {
        Destroy(gameObject);
        Debug.Log("Destroyed: " +  gameObject.name);
    }
}
