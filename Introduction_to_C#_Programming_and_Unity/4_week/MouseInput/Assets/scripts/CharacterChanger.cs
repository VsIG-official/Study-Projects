using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Changes character on left mouse button
/// </summary>
public class CharacterChanger : MonoBehaviour
{
    //[SerializeField]
    //GameObject[] prefabCharacters = new GameObject[4];
    //list is a generic(we try to provide data type we want to attach)
    //lists don`t need an indicator of how big it will be
    List<GameObject> prefabCharacters = new List<GameObject>();
    //[SerializeField]
    //GameObject prefabCharacter0;
    //[SerializeField]
    //GameObject prefabCharacter1;
    //[SerializeField]
    //GameObject prefabCharacter2;
    //[SerializeField]
    //GameObject prefabCharacter3;

    // need for location of new character
    GameObject currentCharacter;

    //first frame input support
    bool previousFrameChangeCharacterInput = false;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        //populate array with characters
        //its better cause we don`t need to load them in game(we do it before game starts)
        //but it will be in executable file,so you need to use it with knowledge
        //prefabCharacters[0] = (GameObject)Resources.Load("Character0");
        //prefabCharacters[0] = (GameObject)Resources.Load(@"Prefabs\Character0");
        //prefabCharacters[1] = (GameObject)Resources.Load(@"Prefabs\Character1");
        //prefabCharacters[2] = (GameObject)Resources.Load(@"Prefabs\Character2");
        //prefabCharacters[3] = (GameObject)Resources.Load(@"Prefabs\Character3");
        //now we are adding object to a list
        //populate List with characters
        prefabCharacters.Add((GameObject)Resources.Load(@"prefabs\Character0"));
        prefabCharacters.Add((GameObject)Resources.Load(@"prefabs\Character1"));
        prefabCharacters.Add((GameObject)Resources.Load(@"prefabs\Character2"));
        prefabCharacters.Add((GameObject)Resources.Load(@"prefabs\Character3"));

        currentCharacter = Instantiate<GameObject>(
            prefabCharacters[0], Vector3.zero,
            Quaternion.identity);
    }

    private void Update()
    {
        if (Input.GetAxis("ChangeCharacter") > 0 )
        {
            if (!previousFrameChangeCharacterInput)
            {
                previousFrameChangeCharacterInput = true;
                Vector3 position = currentCharacter.transform.position;
                Destroy(currentCharacter);

                currentCharacter = Instantiate(prefabCharacters[Random.Range(0, 4)],
                    position, Quaternion.identity);
                //int prefabNumber = Random.Range(0, 4);
                //if (prefabNumber == 0)
                //{
                //    currentCharacter = Instantiate(prefabCharacter0, position, Quaternion.identity);
                //}
                //else if (prefabNumber == 1)
                //{
                //    currentCharacter = Instantiate(prefabCharacter1, position, Quaternion.identity);
                //}
                //else if (prefabNumber == 2)
                //{
                //    currentCharacter = Instantiate(prefabCharacter2, position, Quaternion.identity);
                //}
                //else if (prefabNumber == 3)
                //{
                //    currentCharacter = Instantiate(prefabCharacter3, position, Quaternion.identity);
                //}
            }
        }
        else
        {
            // no change character input
            previousFrameChangeCharacterInput = false;
        }
    }
}
