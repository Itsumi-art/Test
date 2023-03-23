using DIALOGUE;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

namespace TESTING
{
    public class TestParsing : MonoBehaviour
    {

        
        // Start is called before the first frame update
        void Start() { 

            SendFileToParse();


        }

        void SendFileToParse() { 

            List<string> lines = FileManager.ReadTextAsset("testFile");

            foreach(string line in lines)
            {
                if (line == string.Empty)
                    continue;
                DIALOGUE_LINE dl = DialogueParser.Parse(line);
            }
        }
    }

    /*string line = "Speaker \"Dialogue \\\"Goes In\\\" Here!\" Command(arguments here)";

    DialogueParser.Parse(line);*/
}
