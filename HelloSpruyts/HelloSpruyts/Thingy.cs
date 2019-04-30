namespace HelloSpruyts
{
    using System;

    internal class Thingy
    {
        String[] incidental;
        String name;
        String beatsPic;
         
        String beats;
        String verb;
        public Thingy(String Name, String Beats, String BeatsPic, String Verb,string[] Incidental)
        {
            name = Name;
            beatsPic = BeatsPic;
             
            beats = Beats;
            verb = Verb;
            incidental = Incidental;
        }
        public String compete(String enemy)
        {
            String result = "lose";

            if (enemy==(beats)) { result = "win"; }
            if (enemy==(name)) { result = "draw"; }
            //toaster("ene "+enemy + " " + beats + "you " + name + " "+ result,context);
            return result;
        }

        public String getName()
        { return name; }

       

        public String getBeatsPic()
        { return beatsPic; }

        public String getVerb()
        { return verb; }

        public String toString()
        { return name + " " + verb + " " + beats + "!"; }

        public string getGloatwin(int index) { return incidental[index] ; }
        



    }
}