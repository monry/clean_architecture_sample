using CAFU.Data;

namespace CAFU.Domain {

    public interface ITranslator<in TInput, out TOutput> where TInput : IEntity where TOutput : IModel {

        TOutput Translate(TInput entity);

    }

}