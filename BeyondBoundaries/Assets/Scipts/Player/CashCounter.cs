using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CashCounter : MonoBehaviour
{
    [SerializeField] float dollars = 15;
    [SerializeField] float hundreds = 300;
    [SerializeField] float thousands = 15000;
    [SerializeField] float millions = 1000000;
    [SerializeField] float cashAmount;
    [SerializeField] TextMeshProUGUI myText;
    [SerializeField] GameObject teleporter;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Small Valuable")
        {
            cashAmount += dollars;
            myText.text = "Cash: $" + cashAmount;
            Destroy(collision.gameObject);
        }
        
        else if (collision.gameObject.tag == "Valuable")
        {
            cashAmount += hundreds;
            myText.text = "Cash: $" + cashAmount;
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag == "High End Valuable")
        {
            cashAmount += thousands;
            myText.text = "Cash: $" + cashAmount;
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag == "Millions")
        {
            cashAmount += millions;
            myText.text = "Cash: $" + cashAmount;
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    if (collision.gameObject.tag == "Small Valuable")
        {
            cashAmount += dollars;
            myText.text = "Cash: $" + cashAmount;
            Destroy(collision.gameObject);
        }
        
        else if (collision.gameObject.tag == "Valuable")
        {
            cashAmount += hundreds;
            myText.text = "Cash: $" + cashAmount;
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag == "High End Valuable")
        {
            cashAmount += thousands;
            myText.text = "Cash: $" + cashAmount;
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag == "Millions")
        {
            cashAmount += millions;
            myText.text = "Cash: $" + cashAmount;
            Destroy(collision.gameObject);
        }
        if (cashAmount > 1000000)
        {
            teleporter.SetActive(true);
        }
    }
}
