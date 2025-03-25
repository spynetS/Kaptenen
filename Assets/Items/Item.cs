using UnityEngine;
using System.Collections.Generic;

public class Item : MonoBehaviour
{
    public GameObject nextUpgrade;
    public List<GameObject> cost = new List<GameObject>();

    void Use()
    {
        
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            this.Upgrade(cost);
        }
    }

    void Upgrade(List<GameObject> cost){
        if(nextUpgrade){
            GameObject B = Instantiate(nextUpgrade, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
