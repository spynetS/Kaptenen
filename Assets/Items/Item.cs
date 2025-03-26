using UnityEngine;
using System.Collections.Generic;

/**
 * Item is a object that can be picked up by a player
 * and used. This is mostly a abstract version to be implemented
 * but can be used to unsusable items.
 *  */
public class Item : MonoBehaviour
{
    public GameObject nextUpgrade;
    public List<GameObject> cost = new List<GameObject>();

    /**
     * Method that starts uses an item. Abstract
     *  */
    public virtual void Use()
    {
        
    }

    public void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            this.Upgrade(new List<GameObject>());
        }
    }
    /**
     * Method to handle upgrading of items. If the
     * cost is the same as the cost then the item
     * gets repalced with the `nextUpgrade` item.
     *  */
    public bool Upgrade(List<GameObject> cost){
        if(nextUpgrade){
            if(this.cost == (cost)){
                GameObject newGameObject = Instantiate(nextUpgrade, transform.position, transform.rotation, gameObject.transform.parent);
                Destroy(gameObject);
                return true;
            }
        }
        return false;
    }
    /** Returns the cost to be upgraded */
    public List<GameObject> getCost(){
        return this.cost;
    }
}
