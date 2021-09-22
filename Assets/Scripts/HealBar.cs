using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBar : MonoBehaviour
{
    public GameObject slotPrefab;
    public GameObject ant;
    public Transform slotPanel;
    public Player player;
    public int currenthealth;
    public void Start()
    {
        player = ant.GetComponent<Player>();
        currenthealth = player.playerStat.health;
        for (int i = 0; i < currenthealth; i++)
        {
            GameObject instance = Instantiate(slotPrefab);
            instance.transform.SetParent(slotPanel);
        }

    }
    private void Update()
    {
        Hpchange();
    }
    public void Hpchange()
    {
        currenthealth = 0;
       
    }
}
