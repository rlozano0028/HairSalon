namespace ClassPractice
{
    class Person
    {
        string Name;
        string HairColor;
        string HairStyle;
        int HairLength;


        public Person(string Name, string HairColor, string HairStyle, int HairLength)
        {
            this.Name = Name;
            this.HairColor = HairColor;
            this.HairStyle = HairStyle;
            this.HairLength = HairLength;
        }
        public string GetName()
        {
            return Name;
        }

        public string GetColor()
        {
            return HairColor;
        }

        public string GetStyle()
        {
            return HairStyle;
        }
        public int GetHairLength()
        {
            return HairLength;
        }

        public override string ToString()
        {
            return $"{Name}, HairColor:{HairColor}, HairStyle{HairStyle}, HairLength{HairLength}";
        }


    }
}


