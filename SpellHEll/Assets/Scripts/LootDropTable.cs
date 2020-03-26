using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootDropTable : MonoBehaviour
{
    public GameObject Drop1;
    public int Drop1rate;
    public GameObject Drop2;
    public int Drop2rate;
    public GameObject Drop3;
    public int Drop3rate;
    public GameObject Drop4;
    public int Drop4rate;
    public GameObject Drop5;
    public int Drop5rate;
    public GameObject Drop6;
    public int Drop6rate;
    public int NoDrop;

    void Update()
    {
        if (GetComponent<HealthSystem>().health == 0)
        {
            Loots();
        }

    }

    void Loots()
    {
        
        int chance = (Random.Range(0, 100));
        {
            if (chance <= NoDrop)
            {
                return;
            }

            else if (chance <= Drop1rate)
            {
                GameObject loot = Instantiate(Drop1, transform.position, Quaternion.identity);
            }
            else if (chance <= Drop2rate)
            {
                GameObject loot = Instantiate(Drop2, transform.position, Quaternion.identity);
            }
            else if (chance <= Drop3rate)
            {
                GameObject loot = Instantiate(Drop3, transform.position, Quaternion.identity);
            }
            else if (chance <= Drop4rate)
            {
                GameObject loot = Instantiate(Drop4, transform.position, Quaternion.identity);
            }
            else if (chance <= Drop5rate)
            {
                GameObject loot = Instantiate(Drop5, transform.position, Quaternion.identity);
            }
            else if (chance <= Drop6rate)
            {
                GameObject loot = Instantiate(Drop6, transform.position, Quaternion.identity);
            }

        }

                     
    }

}
