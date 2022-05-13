using System;

namespace OneOOP
{
    public class Family
    {
        private int groupOfBlood = 1;

        public string WhoFam { get; set; }
        public string ColorOfHair { get; set; }
        public string ColorOfEye { get; set; }
        public string Nationalities { get; set; }
        public int GroupOfBlood
        {
            get { return groupOfBlood; }
            set
            {
                if (value > 0 && value < 5)
                    groupOfBlood = value;
                else groupOfBlood = 1;
            }
        }


        public Family(){}
        public Family(string who, string hair, string eye, string nationalities, int blood)
        {
            WhoFam = who;
            ColorOfHair = hair;
            ColorOfEye = eye;
            Nationalities = nationalities;
            GroupOfBlood = blood;
        }

        public static Family operator +(Family dad, Family mom)
        {
            return new Family("child", mom.ColorOfHair, dad.ColorOfEye,
                dad.Nationalities, mom.GroupOfBlood);
        }


        public override string ToString()
        {
            return $"{WhoFam} - {Nationalities} with {ColorOfEye} eye," +
            	$" {ColorOfHair} hair, {GroupOfBlood} group of blood";
        }
    }
}
