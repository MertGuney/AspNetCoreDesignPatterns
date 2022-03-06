using System;

namespace WebApp.ChainOfResponsibilityPattern.ChainOfResponsibility
{
    public interface IProcessHandler
    {
        /// <summary>
        /// Sırada bir sonraki işlemi belirtir
        /// </summary>
        /// <param name="processHandler"></param>
        /// <returns></returns>
        IProcessHandler SetNext(IProcessHandler processHandler);
        /// <summary>
        /// Her türlü obje alabilmesi için object olarak tanımladık
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        Object Handle(Object o);
    }
}
