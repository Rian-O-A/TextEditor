public class Menu{

    public static void Start(){
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1 - Create");
        Console.WriteLine("2 - Read");
        Console.WriteLine("3 - Update");
        Console.WriteLine("4 - Delete");
        Console.WriteLine("5 - List Files");
        Console.WriteLine("6 - Exit");
        Console.Write(">>> ");
        short option = Input.Options();

        switch(option){

            case 1: Screen.Creat(); break;
            
            case 2: Screen.Read(); break;
            
            case 3: Screen.Update(); break;
            
            case 4: Screen.Delete(); break;

            case 5: Screen.ListFile(); break;

            
            case 6: {
                Console.WriteLine("Bye!");
                System.Environment.Exit(0); 
                break;}
            
            default: Start(); break;
           
        }
        Start();
    }

}