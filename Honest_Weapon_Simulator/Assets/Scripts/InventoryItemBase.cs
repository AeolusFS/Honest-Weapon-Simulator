using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItemBase: MonoBehaviour
{
    public string Name;

    public Sprite Image;
}

public class InventoryItemBase : InteractableItemBase {

    public InventorySlot Slot
    {
        get; set;
    }

    public virtual void Onpickup()
    {
        gameObject.SetActive(false);
    }
    public virtual void OnDrop()
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 1000))
        {
            gameObject.SetActive(true);
            gameObject.transform.position = hit.point;
        }
    }
}
