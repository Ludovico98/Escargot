using UnityEngine;

public class PlacingItem : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(" Enter" + collision.gameObject.name);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit : " + collision.gameObject.name);
        
    }


}
