using System;

namespace DEV_12
{
    public class StepsChecker
    {
        /// <summary>
        /// Return count of steps for black
        /// </summary>
        /// <param name="start"></param>
        /// <param name="finish"></param>
        /// <returns></returns>
        private int CountForWhite(int [] start, int [] finish)
        {
            if (finish[0] + finish[1] >= start[0] + start[1] &&
                finish[0] - finish[1] <= start[0] - start[1] &&
                finish[1] >= start[0])
                return Math.Abs(finish[1] - start[1]);
            else
                throw new ArgumentException("Not reachable field");
        }
        /// <summary>
        /// Return count of steps for black
        /// </summary>
        /// <param name="start"></param>
        /// <param name="finish"></param>
        /// <returns></returns>
        private int CountForBlack(int [] start, int [] finish)
        {
            if (finish[0] + finish[1] <= start[0] + start[1] &&
                 finish[0] - finish[1] >= start[0] - start[1] &&
                 finish[1] <= start[1])
                return Math.Abs(finish[1] - start[1]);
            else
                throw new ArgumentException("Not reachable field");
        }
        /// <summary>
        /// Count steps of checker
        /// </summary>
        /// <param name="color"></param>
        /// <param name="start"></param>
        /// <param name="finish"></param>
        /// <returns></returns>
        public int Count(char color, int [] start, int [] finish)
        {
            if (color == 'w')
                return CountForWhite(start, finish);
            else
                return CountForBlack(start, finish);
        }
    }
}

