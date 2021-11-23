using UnityEngine;
using Zork;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    public void Write(object value)
    {
        throw new System.NotImplementedException();
    }

    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void WriteLine(object value)
    {
        throw new System.NotImplementedException();
    }

    public void WriteLine(string value)
    {
        throw new System.NotImplementedException();
    }

    [SerializeField]
    private TextMesh outputtext;

    [SerializeField]
    private TextMesh locationtext;

    [SerializeField]
    private TextMesh movestext;

    [SerializeField]
    private TextMesh scoretext;
}
