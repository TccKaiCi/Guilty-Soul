using System;
using UnityEngine;

[System.Serializable]
public class Eagle : Enemy
{
    public int idInput;
    public int armor;
    private void Start()
    {
        base.heathBar.SetHealthBar(base.health, base.maxHealth);
    }

    public Eagle()
    {

    }

    public Eagle(int id, string name, int health, int armor)
    {
        base.id = id;
        base.name = name;
        base.health = health;
        this.armor = armor;
    }


    override
    public void infor()
    {
        Debug.Log(id + " " + name + " " + health);
    }

    public override void TakeDamage(int damage)
    {
        VisualDameTaken(damage.ToString());
        damage -= this.armor;
        if (damage > 0)
        {
            base.health -= damage;
        }

        base.heathBar.SetHealthBar(base.health, base.maxHealth);

        if (base.health <= 0)
        {
            Die();
        }
    }
    public void StrikeMode()
    {

    }
    public void FlyingAtk()
    {
        Player target = FindObjectOfType<Player>();
        Sense sense = GetComponentInChildren<Sense>();
        if(sense.tLock==true)
        {
            Rigidbody2D rig = GetComponent<Rigidbody2D>();
            rig.AddForce(target.transform.position-gameObject.transform.position);
        }   
    }
    private void Update()
    {
        FlyingAtk();
    }

}
