using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4 : MonoBehaviour, IInventoryItem {
    public string Name
    {
        get
        {
            return "M4";
        }
    }

    public Sprite _Image = null;
    public Sprite Image
    {
        get { return _Image; }
    }

    public void Onpickup()
    {
        gameObject.SetActive(false);
    }
    public void OnDrop()
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, 1000))
        {
            gameObject.SetActive(true);
            gameObject.transform.position = hit.point;
        }
    }

}
