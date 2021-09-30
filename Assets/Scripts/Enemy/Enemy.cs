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
        Transform Pos = gameObject.GetComponent<Transform>();
        float posX = Random.Range(Pos.position.x - 2f, Pos.position.x + 2f);
        float posY = Random.Range(Pos.position.y - 2f, Pos.position.y + 2f);
        if (floatingText)
        {
            Vector3 spawnPos = new Vector3(posX, posY);
            GameObject prefab = Instantiate(floatingText, spawnPos, Quaternion.identity);
            prefab.GetComponentInChildren<TextMeshPro>().text = text;
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
