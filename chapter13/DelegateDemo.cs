using static System.Console;
delegate void UpdateString(ref string input);
class DelegateDemo
{
    public static void StringAdded(ref string theString)
    {
        theString += " added string here";
    }

    public static void StringReplace(ref string theString) 
    {
        theString = theString.Replace(theString, "Here is the replacement string");
    }
    static void Main()
    {
        UpdateString stringAdd;
        UpdateString replaceStrDel;
        stringAdd = new UpdateString(StringAdded);
        replaceStrDel = new UpdateString(StringReplace);

        //get inpt to add or replace
        Write("Enter a string?: ");
        string input = ReadLine();
        Write("Enter A to Add or R to Replace string?: ");
        string addOrReplaceStr = ReadLine();

        if (addOrReplaceStr.ToUpper().Equals("A"))
        {
            stringAdd(ref input);
        }else if (addOrReplaceStr.ToUpper().Equals("R"))
        {
            replaceStrDel(ref input);
        }
               
        WriteLine(input);
        
    }
}