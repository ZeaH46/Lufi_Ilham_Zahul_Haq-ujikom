using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyDamage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Deer"))
        {
            Deer deer = GetComponent<Deer>();
            deer.TakeDamage(25f);
            Destroy(gameObject);

        }
        if (other.gameObject.CompareTag("Horse"))
        {
            Horse horse = GetComponent<Horse>();
            horse.TakeDamage(25f);
            Destroy(gameObject);

        }
        if (other.gameObject.CompareTag("Dog"))
        {
            Dog dog = GetComponent<Dog>();
            dog.TakeDamage(25f);
            Destroy(gameObject);

        }
        if (other.gameObject.CompareTag("Cow"))
        {
            Cow cow = GetComponent<Cow>();
            cow.TakeDamage(25f);
            Destroy(gameObject);

        }
    }
}
