using System.Collections;
using UnityEngine;

public class FinishZone : MonoBehaviour
{
    bool IsCollectable = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Box"))
        {
            GameUI.Instance.IncreaseScoreCount();
        }
    }

    IEnumerator IncreaseScore()
    {
        yield return new WaitForSeconds(1f);
        IsCollectable = !IsCollectable;
    }
}
