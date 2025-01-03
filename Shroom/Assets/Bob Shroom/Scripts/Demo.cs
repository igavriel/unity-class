using UnityEngine;

public class Demo : MonoBehaviour
{
    
    void Start()
    {
        float maxHealth = 100;

        float health = maxHealth;         // health = 100
        health = health * 2;            // health = 200
        health = 0;                     // health = 0;


        string firstName = "Aviv";
        string lastName = "Heilweil";
        string fullName = firstName+" " + lastName; 
        Debug.Log ("Hello "+ fullName);   // Hello Aviv Heilweil
        SetGravity(true);

        ChangeColor(Color.red);
        Check();
    }

    void SetGravity(bool isGravity)
    {
        Rigidbody body = GetComponent<Rigidbody>();
        body.useGravity = isGravity;
    }

    void ChangeColor(Color color)
    {
        Renderer renderer = GetComponent<Renderer>();   
        renderer.material.color = color;
    }


    void Check()
    {

        float num1 = 8;
        float num2 = 15f;

      
        if(num1 > 10 && num2 > 10)
        {
            Debug.Log("TRUE");
        }
        else
        {
            Debug.Log("FALSE");
        }
        // FALSE


        if (num1 > 10 || num2 > 10)
        {
            Debug.Log("TRUE");
        }
        else
        {
            Debug.Log("FALSE");
        }
        // TRUE


    }
}
