using UnityEngine;

public class HideOrShow : MonoBehaviour
{
    public GameObject hand;

    public void Activate(){
        hand.SetActive(true);
    }

    public void Deactivate(){
        hand.SetActive(false);
    }
}
