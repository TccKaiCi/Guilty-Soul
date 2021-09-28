using UnityEngine;

[System.Serializable]
public abstract class Enemy : MonoBehaviour
{
    public int id;
    public string name;
    public int health;
    public int maxHealth;

    public HealthBar heathBar;


    public abstract void TakeDamage(int damage);

    public abstract void infor();

    public void Die()
    {
        Destroy(gameObject);
    }
}
