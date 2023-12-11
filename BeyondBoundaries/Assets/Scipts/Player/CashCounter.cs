using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CashCounter : MonoBehaviour
{
    [SerializeField] float cheap;
    [SerializeField] float expensive;
    [SerializeField] float highEnd;
    [SerializeField] float cashAmount;
    [SerializeField] TextMeshProUGUI myText;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Small Valuable")
        {
            cashAmount += cheap;
            myText.text = "Cash: $" + cashAmount;
            Destroy(collision.gameObject);
        }
        
        else if (collision.gameObject.tag == "Valuable")
        {
            cashAmount += expensive;
            myText.text = "Cash: $" + cashAmount;
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag == "High End Valuable")
        {
            cashAmount += highEnd;
            myText.text = "Cash: $" + cashAmount;
            Destroy(collision.gameObject);
        }
    }
}
