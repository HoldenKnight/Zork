using UnityEngine;
using Zork;
using Newtonsoft.Json;

public class ZorkGameManager : MonoBehaviour
{
    // Start is called before the first frame updateOutput
    void Start()
    {
        TextAsset jsonText = Resources.Load<TextAsset>(ZorkJsonFilename);

        Game game = JsonConvert.DeserializeObject<Game>(jsonText.text);

        _game.GameStopped += _game_GameStopped;

        //_game.MovesIncreased += _game_MovesIncreased;

        //_game.ScoreIncreased += _game_ScoreIncreased;

        //game.Start(OutputService, InputService);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            InputService.ProcessInput();
        }

    }

    private void _game_GameStopped(object sender, System.EventArgs e)
    {
#if Unity_Editor
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    private void _game_MovesIncreased(object sender, System.EventArgs e)
    {
        //someithing
    }

    [SerializeField]
    private string ZorkJsonFilename = "Zork";

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private UnityInputService InputService;

    private Game _game;
}
