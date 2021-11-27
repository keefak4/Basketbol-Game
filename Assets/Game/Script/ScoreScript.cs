using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    [SerializeField] private Text textScrorre;
    private int scoreBall = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            scoreBall++;
            textScrorre.text = "" + scoreBall;
            Destroy(other.gameObject);
        }
    }
}
