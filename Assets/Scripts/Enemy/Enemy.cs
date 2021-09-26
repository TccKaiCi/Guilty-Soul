using UnityEngine;

[System.Serializable]
public abstract class Enemy : MonoBehaviour
{
    public int id;
    public string name;
    public int health;

    public abstract void TakeDamage(int damage);

    public abstract void infor();
}
