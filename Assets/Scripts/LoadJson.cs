using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadJson : MonoBehaviour
{
    [SerializeField] private Text text1, text2, text3, text4, text5;

    private JsonFile _jsonFile = new JsonFile();
    private string _path;

    private void Start()
    {
        _path = Application.streamingAssetsPath + "/" + "Text.json";
        _jsonFile = JsonUtility.FromJson<JsonFile>(File.ReadAllText(_path));

        text1.text = _jsonFile.Do;
        text2.text = _jsonFile.Re;
        text3.text = _jsonFile.Me;
        text4.text = _jsonFile.Fa;
        text5.text = _jsonFile.So;
    }


    public class JsonFile
    {
        public string Do;
        public string Re;
        public string Me;
        public string Fa;
        public string So;
    }
}
