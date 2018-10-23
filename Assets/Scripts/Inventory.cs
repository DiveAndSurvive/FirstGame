using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public static Inventory instance;

    void Awake()
    {
        instance = this;
    }

    public int inventorySpace = 16;
    public List<Sprite> items = new List<Sprite>();

    public bool Add(Sprite sprite)
    {
        if (items.Count >= inventorySpace)
        {
            return false;
        }
        items.Add(sprite);

        return true;
    }

    public void Remove(Sprite sprite)
    {
        items.Remove(sprite);
    }
}
