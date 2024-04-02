using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item
{
    private int index;
    private string name;
    private ItemType type;
    private Sprite image;
    //멤버들이 브라이뱃이라 접근불가

    public int Index
    {
        get { return index;  }
        set { index = value;  }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public ItemType Type
    {
        get { return type; }
        set { type = value; }
    }
    public Sprite Image
    {
        get { return Image; }
        set { Image = value; }
    }

    public Item(int index, string name, ItemType type)
    {
        this.index = index;
        this.name = name;
        this.type = type;
    }

}


public enum ItemType
{
    Weapon,
    Armor,
    Potion,
    QuestItem
}

public class Inventory
{
    private Item[] items = new Item[16];

    public Item this[int index]
    {
        get { return items[index]; }
        set { items[index] = value; }
    }

    public int ItemCount
    {
        get
        {
            int count = 0;
            foreach (Item item in items)
            {
                if (item != null) count++;
            }
            return count;
        }
    }


    public bool AddItem(Item item)
    {
        for (int i = 0; i< items.Length; i++)
       {
            if (items[i] == null)
            {
                items[i] = item;
                return true;
            }
        }
        return false;
    }


    public void Remove(Item item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == item)
            {
                items[i] = null;
                break;

            }
        }
    }
}



public class ExGameSystem : MonoBehaviour
{

    private Inventory inventory = new Inventory();

    // Start is called before the first frame update
    void Start()
    {
        Item sword = new Item(0, "sword", ItemType.Weapon);
        Item shield = new Item(100, " shield", ItemType.Armor);

        inventory.AddItem(sword);
        inventory.AddItem(shield);
   

        Debug.Log("Player Inventory : " + GetInventoryAsString());
    }

    private string GetInventoryAsString()
    {
        string result = "";
        for (int i = 0; i < inventory.ItemCount; i++)       //인벤토리 안에 item 이 있으면 해당 이름 출력
            if (inventory[i] != null)
            {
                result += inventory[i].Name + ",";
            }
        return result.TrimEnd(',');  //콤마 제거?
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
