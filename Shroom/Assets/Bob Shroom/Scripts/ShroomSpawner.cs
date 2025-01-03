using UnityEngine;

public class ShroomSpawner : MonoBehaviour
{
    public int numOfShrooms = 100; // כמה פטריות נרצה על המגגרש
    public float fieldSize = 10f; // גודל המגרש 
    public GameObject shroomPrefab; // הפריפאב מתוך המגירה ממנו נרצה לייצר העתקים
    void Start()
    {
        CreateField(); // קורא למתודה שייצרתי שמייצרת מגרש
    }

    void CreateField()
    {
        for (int i = 0; i < numOfShrooms; i++)  // סופר מ-0 עד 99
        {
            float x = Random.Range(-fieldSize, fieldSize); // מגדיר משתנה ונותן לו ערך בין 10 למינוס 10
            float z = Random.Range(-fieldSize, fieldSize); // מגדיר משתנה ונותן לו ערך בין 10 למינוס 10

            Vector3 randomPosition = new Vector3(x, 0f, z); // ניצור ווקטור3 שהוא יהיה המיקום של הפיטריה

            Instantiate(shroomPrefab, randomPosition , Quaternion.identity);   //ניצור פטריה במקום שההגדרנו
        }
    }
}
