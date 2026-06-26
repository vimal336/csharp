class Reverse{
    public static void Run(){
        string myname  = "hello C sharp";
        string setname  = "dotnet";
        string reversed = "";
        for(int i=myname.Length-1;i>=0;i--){
                    reversed = reversed + myname[i];
                        Console.WriteLine(reversed);
                         Console.WriteLine(reversed);
        }
        //Console.WriteLine(reversed);
    }
}