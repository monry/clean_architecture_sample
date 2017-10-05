using CAFU.Presentation;
using CAFU.Presentation.View;

namespace CAFU.Application {

    public interface IBuilder<out T> where T : IViewController<IPresenter, IRouter> {

        T Build();

    }

    public abstract class Builder<T> : IBuilder<T> where T : IViewController<IPresenter, IRouter> {

        public abstract T Build();

    }

}