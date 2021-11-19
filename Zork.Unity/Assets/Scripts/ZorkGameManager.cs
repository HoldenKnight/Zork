using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork;
using Newtonsoft.Json;

public class ZorkGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextAsset jsonText = Resources.Load<TextAsset>(ZorkJsonFilename);

        Game game = JsonConvert.DeserializeObject<Game>(jsonText.text);

        //game.Start(Output, Input);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField]
    private string ZorkJsonFilename = "Zork";

    [SerializeField]
    private UnityOutputService Output;

    [SerializeField]
    private UnityInputService Input;
}
