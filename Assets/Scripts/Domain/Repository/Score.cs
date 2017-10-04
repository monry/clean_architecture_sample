
using CAFU.Domain;
using CASample.Data.DataStore;

namespace CASample.Domain.Repository {

    public class Score : Repository<Score> {

        public Data.Entity.Score Load() {
            return ScoreDataStoreFactory.CreateInstance().LoadScore();
        }

        public void Save(Data.Entity.Score score) {
            ScoreDataStoreFactory.CreateInstance().SaveScore(score);
        }

    }

}