using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CHARACTERS;
using DIALOGUE;
using TMPro;

namespace TESTING
{
    public class TestCharacters : MonoBehaviour
    {
        public TMP_FontAsset tempFont;

        // Start is called before the first frame update
        void Start()
        {
            Character Neah = CharacterManager.instance.CreateCharacter("Neah");
            //Character Caleb = CharacterManager.instance.CreateCharacter("Caleb");
            //Character Tristan = CharacterManager.instance.CreateCharacter("Tristan");
            //StartCoroutine(Test());
        } 

        IEnumerator Test()
        {
            return null;
            //Debug.Log("Finished");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}