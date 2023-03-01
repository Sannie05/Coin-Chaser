using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PickUp : MonoBehaviour
{

    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    
    public GameObject silver_1;
    public GameObject silver_2;
    public GameObject silver_3;
    public GameObject silver_4;
    public GameObject silver_5;

    public GameObject gold_1;
    public GameObject gold_2;
    public GameObject gold_3;
    public GameObject gold_4;
    public GameObject gold_5;
    public GameObject gold_6;
    public GameObject gold_7;
    public GameObject gold_8;
    public GameObject gold_9;
    public GameObject gold_10;
    public GameObject gold_11;
    public GameObject gold_12;

    public GameObject ruby_1;
    public GameObject ruby_2;
    public GameObject ruby_3;
    public GameObject ruby_4;
    public GameObject ruby_5;
    public GameObject ruby_6;
    public GameObject ruby_7;
    public GameObject ruby_8;
    public GameObject ruby_9;
    public GameObject ruby_10;
    public GameObject ruby_11;
    public GameObject ruby_12;

    private Rigidbody rb;   
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 65)
        {
            winTextObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }

        if (other.gameObject.CompareTag("PickupGold"))
        {
            other.gameObject.SetActive(false);
            count = count + 2;

            SetCountText();
        }

        if (other.gameObject.CompareTag("PickUpRuby"))
        {
            other.gameObject.SetActive(false);
            count = count + 3;

            SetCountText();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            count = 0;
            winTextObject.SetActive(false);

            SetCountText();

            silver_1.SetActive(true);
            silver_2.SetActive(true);
            silver_3.SetActive(true);
            silver_4.SetActive(true);
            silver_5.SetActive(true);

            gold_1.SetActive(true);
            gold_2.SetActive(true);
            gold_3.SetActive(true);
            gold_4.SetActive(true);
            gold_5.SetActive(true);
            gold_6.SetActive(true);
            gold_7.SetActive(true);
            gold_8.SetActive(true);
            gold_9.SetActive(true);
            gold_10.SetActive(true);
            gold_11.SetActive(true);
            gold_12.SetActive(true);

            ruby_1.SetActive(true);
            ruby_2.SetActive(true);
            ruby_3.SetActive(true);
            ruby_4.SetActive(true);
            ruby_5.SetActive(true);
            ruby_6.SetActive(true);
            ruby_7.SetActive(true);
            ruby_8.SetActive(true);
            ruby_9.SetActive(true);
            ruby_10.SetActive(true);
            ruby_11.SetActive(true);
            ruby_12.SetActive(true);

        }

    }
}
