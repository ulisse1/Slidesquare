using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;

public static class SaveSystem
{   
    public static void SaveHighscore(string score) 
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/highscore.xyz";

        FileStream stream = new FileStream(path, FileMode.Create);
        HighscoreData data = new HighscoreData(score);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static HighscoreData LoadHighScore()
    {
        string path = Application.persistentDataPath + "/highscore.xyz";

        if(File.Exists(path))
        {
            //Debug.Log("The file does exist, so we return something");
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            HighscoreData data = formatter.Deserialize(stream) as HighscoreData;
            stream.Close();
            return data;
        }
        //Debug.Log("NO TRACE OF THE FILE");
        return null;
    }

}
