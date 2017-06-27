using System.Diagnostics;
 
namespace Microframework.Commands
{
    /// <summary>
    /// CheckPageTitle command
    /// </summary>
    class CheckPageTitle : Command
    {
        string title;    
        public CheckPageTitle(string text)
        {
            this.title = text;
        }

        /// <summary>
        /// Realisation of CheckPageTitle
        /// </summary>
        public override void Execute()
        {
            Provider.provider.CheckPageTitle(title);
        }
    }
}