namespace WebApp.ChainOfResponsibilityPattern.ChainOfResponsibility
{
    public abstract class ProcessHandler : IProcessHandler
    {
        private IProcessHandler nextProcessHandler;
        /// <summary>
        /// process abstract sınıfını miras alanlar bu metodu override edeceklerinden dolayı virtual olarak işaretliyoruz
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public virtual object Handle(object o)
        {
            if (nextProcessHandler != null)
            {
                return nextProcessHandler.Handle(o);
            }
            return null;
        }

        public IProcessHandler SetNext(IProcessHandler processHandler)
        {
            nextProcessHandler = processHandler;
            return nextProcessHandler;
        }
    }
}
