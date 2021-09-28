using UnityEngine;

[System.Serializable]
public class Frog : Enemy
{
    public int idInput;

    private void Start()
    {
        base.heathBar.SetHealthBar(base.health, base.maxHealth);
    }

    public Frog() { }

    public Frog(int id, string name, int health)
    {
        base.id = id;
        base.name = name;
        base.health = health;
    }

    override
    public void infor()
    {
        Debug.Log(this.id + " " + this.name + " " + this.health);
    }

    public override void TakeDamage(int damage)
    {
        base.health -= damage;

        base.heathBar.SetHealthBar(base.health, base.maxHealth);

        if (base.health <= 0)
        {
            Die();
        }
    }

}
