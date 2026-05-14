class Reverse{
    public static void Run(){
        string myname  = "hello";
        string reversed = "";
        for(int i=myname.length-1;i>=0;i--);{
                    reversed = reversed + myname[i];
        }
        Console.WriteLine(reversed);
    }
}