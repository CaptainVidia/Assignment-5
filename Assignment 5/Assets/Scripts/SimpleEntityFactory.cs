/*Name: George Tang
 * File: SimpleEntityFactory.cs
 * Project: Assignment 5
 * Description: Card Stats and information. Sets up all instantation.
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class SimpleEntityFactory : MonoBehaviour
{
    public Entity[] entities = new Entity[3];
    private int toInstantiate = 0;
    public Text cardText;
    Entity toCollect;
    
    void Update()
    {
        cardText.text = "Card Type: " + entities[toInstantiate].CardType() + "\nCard Objective: " + entities[toInstantiate].CardAbility() + "\nMana Cost: " + entities[toInstantiate].CardCost() + "\nCard Number Set: " + entities[toInstantiate].CardNumSet();
    }

    public Entity CardChoice()
    {
        if (toInstantiate == 0)
        {
            toCollect = entities[0];
            if (toCollect.gameObject.GetComponent<Monster>() == null)
                toCollect.gameObject.AddComponent<Monster>();
        }

        else if (toInstantiate == 1)
        {
            toCollect = entities[1];
            if (toCollect.gameObject.GetComponent<Spell>() == null)
                toCollect.gameObject.AddComponent<Spell>();
        }

        else
        {
            toCollect = entities[2];
            if (toCollect.gameObject.GetComponent<Special>() == null)
                toCollect.gameObject.AddComponent<Special>();
        }
        return toCollect;
    }

    public void MonsterChoice()
    {
        toInstantiate = 0;
    }
    public void SpellChoice()
    {
        toInstantiate = 1;
    }
    public void SpecialChoice()
    {
        toInstantiate = 2;
    }

}
