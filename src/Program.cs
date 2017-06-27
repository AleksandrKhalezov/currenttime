using Microframework.Commands;
using Microframework.CommandCreators;
using System;
 
namespace Microframework
{
    /// <summary>
    /// Microframework to test site
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // path to read commands and write results
                string path = @"D:\Programming\C#\Projects\MicroFramework\input.txt";
                string outPutPath = @"D:\Programming\C#\Projects\MicroFramework\output.txt";

                CreatorCommand creatorCommand = new CreatorOpen(new CreatorCheckPageTitle(
                                                                new CreatorCheckPageContains(
                                                                new CreatorCheckLinkPresentByName(
                                                                new CreatorCheckLinkPresentByHref(null)))));
                
                Provider provider = Provider.GetInstance(creatorCommand, outPutPath);
                provider.Execute(path);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}