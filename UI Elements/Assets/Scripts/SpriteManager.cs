using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public static SpriteManager instance;

    private void Awake()
    {
        instance = this;

        UpdateEnum();

        spritesDic.Clear();
        foreach (SpriteList tmp in sprites)
            spritesDic.Add(tmp.name, tmp);
    }

    public List<SpriteList> sprites = new List<SpriteList>();

    public Dictionary<string, SpriteList> spritesDic = new Dictionary<string, SpriteList>();

    void Update()
    {
        //spritesDic.Clear();
        //foreach (SpriteList tmp in sprites)
        //    spritesDic.Add(tmp.name, tmp);
    }

    void UpdateEnum()
    {
        string path = "";
        string name = "GeneratedSpritesEnum";
        var data = sprites;

        File.Delete(Application.dataPath + "/" + path + name + ".cs");

        using (StreamWriter file = File.AppendText(Application.dataPath + "/" + path + name + ".cs"))
        {
            file.WriteLine("[System.Serializable]\npublic enum " + name + " \n{");

            int i = 0;
            foreach (var line in data)
            {

                string lineRep = line.ToString().Replace(" ", string.Empty);
                if (!string.IsNullOrEmpty(lineRep))
                {
                    file.WriteLine(string.Format("\t{0},", data[i].name), false);
                    i++;
                }
            }

            file.WriteLine("\n}");
        }

        AssetDatabase.ImportAsset(path + name);
    }

}

[System.Serializable]
public class SpriteList
{
    public string name;
    public Sprite sprite;
}
