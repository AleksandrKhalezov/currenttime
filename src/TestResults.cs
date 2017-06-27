using System;
 
namespace Microframework
{
    /// <summary>
    /// Contaons test results
    /// </summary>
    struct TestResults
    {
        public bool IsPassing { get; set; }
        string command;
        public TimeSpan time { get; set; }
        public TestResults(bool isPass, string command, TimeSpan time)
        {
            this.IsPassing = isPass;
            this.command = command;
            this.time = time;
        }

        /// <summary>
        /// Convert result to need format
        /// </summary>
        /// <returns>formated result</returns>
        public override string ToString()
        {
            return string.Concat(IsPassing?'+':'!', "  [", command, "]  ", time.Milliseconds);
        }
    }
}