namespace DEV_5
{
    class Post
    {
        public const int JUNIORSALARY = 5;
        public const int JUNIORPODUCTIVITY = 2;

        public const int MIDDLESALARY = 8;
        public const int MIDDLEPODUCTIVITY = 4;

        public const int SENIORSALARY = 15;
        public const int SENIORPODUCTIVITY = 7;

        public const int LEADERSALARY = 20;
        public const int LEADERPODUCTIVITY = 10;
        
        public int[] JuniorParameters()
        {
            int[] arrayOfJun = new int[2];
            arrayOfJun[1] = JUNIORSALARY;
            arrayOfJun[2] = JUNIORPODUCTIVITY;
            return arrayOfJun;
        }

        public int[] MiddleParameters()
        {
            int[] arrayOfMid = new int[2];
            arrayOfMid[1] = MIDDLESALARY;
            arrayOfMid[2] = MIDDLEPODUCTIVITY;            
            return arrayOfMid;
        }

        public int[] SeniorParameters()
        {
            int[] arrayOfSen = new int[2];
            arrayOfSen[1] = SENIORSALARY;
            arrayOfSen[2] = SENIORPODUCTIVITY;
            return arrayOfSen;
        }

        public int[] LeaderParameters()
        {
            int[] arrayOfLead = new int[2];
            arrayOfLead[1] = LEADERSALARY;
            arrayOfLead[2] = LEADERPODUCTIVITY;
            return arrayOfLead;
        }
    }
}
