using System.Collections;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int health = 100;

    public Renderer renderer;
    private Color originalColor;

    private void Start()
    {
        

        renderer.material = new Material(renderer.material);

        originalColor = renderer.material.GetColor("_MinColor");
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        StartCoroutine(FlashRed());

        if(health < 0)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator FlashRed()
    {
        renderer.material.SetColor("_MainColor", Color.red);

        yield return new WaitForSeconds(0.1f);

        renderer.material.color = originalColor;
    }
}
