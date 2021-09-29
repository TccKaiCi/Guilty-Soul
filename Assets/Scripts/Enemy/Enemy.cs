using TMPro;
using UnityEngine;

[System.Serializable]
public abstract class Enemy : MonoBehaviour
{
    public int id;
    public string name;
    public int health;
    public int maxHealth;
    public GameObject floatingText;
    public HealthBar heathBar;
    private void Awake()
    {
    }
    public abstract void TakeDamage(int damage);

    public abstract void infor();
    public void VisualDameTaken(string text)
    {
        if (floatingText)
        {
            GameObject prefab = Instantiate(floatingText, gameObject.GetComponent<Transform>().position, Quaternion.identity);
            prefab.GetComponentInChildren<TextMeshPro>().text = text;
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
