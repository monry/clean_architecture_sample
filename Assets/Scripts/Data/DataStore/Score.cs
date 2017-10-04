using System.IO;
using CAFU.Data;
using UnityEngine;

namespace CASample.Data.DataStore {

    public interface IScoreDataStore : IDataStore {

        Entity.Score LoadScore();

        void SaveScore(Entity.Score score);

    }

    public static class ScoreDataStoreFactory {

        public static IScoreDataStore CreateInstance() {
            return new Score();
        }

    }

    /// <remarks>この DataStore の実体を変更することで JSON から読んだり CSV から読んだり API から... を変更する</remarks>
    public class Score : IScoreDataStore {

        public Entity.Score LoadScore() {
            string jsonFilePath = GenerateJSONPath();
            if (!File.Exists(jsonFilePath)) {
                return new Entity.Score();
            }
            return JsonUtility.FromJson<Entity.Score>(jsonFilePath);
        }

        public void SaveScore(Entity.Score score) {
            string jsonFilePath = GenerateJSONPath();
            if (!Directory.Exists(Path.GetDirectoryName(jsonFilePath))) {
                Directory.CreateDirectory(jsonFilePath);
            }
            string json = JsonUtility.ToJson(score);
            File.WriteAllText(jsonFilePath, json);
        }

        private static string GenerateJSONPath() {
            return Path.Combine(Application.persistentDataPath, "score.json");
        }

    }

}