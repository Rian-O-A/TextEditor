public class Input{
    public static short Options(){
       
        string responseBrute = Console.ReadLine();

        if(short.TryParse(responseBrute, out short response)){
            return response;
        }else{
            
            return 0;
            }
    }

    public static string Text(int linha= 1){
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> WRITE TEXT >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("(:sq) to save and exit\n");
       
        string text = "";

        do
        {
            Console.Write("- " + linha + " ");
            string input = Console.ReadLine();
            
            if (input == null || input.ToLower() == ":sq")
                break;

            text += input + "\n";
            linha++;
        } while (true);

        return text;
    }

    public static int Index(){
        
        
        string responseBrute =Console.ReadLine();

        if(int.TryParse(responseBrute, out int response)){
            return response;
        }else{
            Console.WriteLine("Error: Index invalid, please try again!");
            Thread.Sleep(2500);
            return 0;
            }
        
    }
    public static int Update(){
        

        int[] optionsValid = [1, 2, 3, 4];
        Console.WriteLine("[1] - Delete Line\n[2] - Add Line\n[3] - Clear File\n[4] - Cancel\n");
        int option = Options();
        if(optionsValid.Contains(option) == false){
            Console.WriteLine("Error: Option invalid, please try again!");
            Thread.Sleep(2500);
            Update();

        }
        
        return option;
    }
    public static char Continue(){
        

        char[] optionsValid = ['y', 'n'];
        Console.WriteLine("Do you want to continue exclusing? [y/n]");
        Console.Write(">>> ");
        char option = Console.ReadLine().ToLower()[0];
        if(optionsValid.Contains(option) == false){
            Console.WriteLine("Error: Option invalid, please try again!");
            Thread.Sleep(2500);
            Continue();

        }
        
        return option;
    }



      
        
    


}