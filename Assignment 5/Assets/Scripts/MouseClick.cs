/*Name: George Tang
 * File: MouseClick.cs
 * Project: Assignment 5
 * Description: Allows the collector to select certain cards to either add or remove to their deck
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MouseClick : MonoBehaviour
{
    public SimpleEntityFactory factory;
    Entity toCollect;
    public Text deckMaxText;
    int deck = 50;
    // Use this for initialization
    //start is not needed
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        toCollect = factory.CardChoice();

        deckMaxText.text = "Total Mana Cost of Cards Remaining: " + deck;
        if (Input.GetMouseButtonDown(0))
        {
            

            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "Playmat" && toCollect.CardCost() <= deck)
                {
                    Instantiate(toCollect.gameObject, hitInfo.point, toCollect.gameObject.transform.rotation, null);
                    deck -= toCollect.CardCost();

                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag != "Playmat")
                {
                    deck += hitInfo.collider.gameObject.GetComponent<Entity>().CardCost();
                    Destroy(hitInfo.collider.gameObject);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
