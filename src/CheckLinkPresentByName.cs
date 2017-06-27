using System.Diagnostics;
 
namespace Microframework.Commands
{
    /// <summary>
    /// CheckLinkPresentByName command
    /// </summary>
    class CheckLinkPresentByName : Command
    {
        string text;
        public CheckLinkPresentByName(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// Realisation of CheckLinkPresentByName command
        /// </summary>
        public override void Execute()
        {
            Provider.provider.CheckLinkPressentByName(text);
        }
    }
}