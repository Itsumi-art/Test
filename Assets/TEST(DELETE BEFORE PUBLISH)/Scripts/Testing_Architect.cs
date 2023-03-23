using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DIALOGUE;

namespace TESTING
{
    public class Testing_Architect : MonoBehaviour
    {
        DialogueSystem ds;
        TextArchitect architect;

        public TextArchitect.BuildMethod bm = TextArchitect.BuildMethod.instant;

        string[] lines = new string[5] {
            " This is a random line of dialogue.",
            " I want to say something, come over here.",
            " The world is crazy place sometimes.",
            " Don't lose hope, things will get better!",
            " Thank you for doing your best - You are amazing!"
        };

        // Start is called before the first frame update
        void Start() {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.fade;
            architect.speed = 0.5f; //Apagar esta linha mais tarde. Faz o texto ir mais devagar. Gosto mais de como estava antes
        }

        // Update is called once per frame
        //Configuar o controle
        void Update() {

            if (bm != architect.buildMethod)
            {
                architect.buildMethod = bm;
                architect.Stop();
            }

            if (Input.GetKeyDown(KeyCode.S))
                architect.Stop();

            string longLine = " This is a very long line that makes no sense but I am just populating it with stuff because, you know, stuff is good right? I like stuff, you like stuff, we all like stuff and the turkey gets together.";
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                if (architect.isBuilding)
                {
                    if (!architect.hurryUp)
                        architect.hurryUp = true;
                    else
                        architect.ForceComplete();
                }
                else
                    architect.Build(longLine);
                //architect.Build(lines[Random.Range(0, lines.Length)]);

            }
            else if (Input.GetKeyDown(KeyCode.A)) 
            {
                architect.Append(longLine);
                //architect.Append(lines[Random.Range(0, lines.Length)]);

            }
        }
    }
}