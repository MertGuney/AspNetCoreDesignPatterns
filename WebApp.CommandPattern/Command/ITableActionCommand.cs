using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApp.CommandPattern.Command
{
    public interface ITableActionCommand
    {
        IActionResult Execute();
    }
}
