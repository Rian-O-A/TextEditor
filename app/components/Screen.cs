public class Screen{

    

    public static void Delete(){
        Console.Clear();
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx DELETE FILE xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.Write("Index: ");
        int index = Input.Index();
        if(index == 0){
            Delete();
        }else{
            ManagerFile.Delete(index);
        }
    }
    public static void ListFile(){

        string[] files = ManagerFile.ListFile();
        int maxIndexWidth = files.Length;
        int maxNameWidth = files.Max(file => Path.GetFileName(file).Length);
        int maxTypeWidth = files.Max(file => Path.GetExtension(file).Length);
        int maxPathWidth = files.Max(file => Path.GetFullPath(file).Length);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        // Imprime o cabeçalho
        Console.WriteLine(new string('-', maxIndexWidth+ maxNameWidth + maxTypeWidth + maxPathWidth + 22));
        Console.WriteLine("| {0,-" + (maxIndexWidth + 2) + "} | {1,-" + (maxNameWidth + 2) + "} | {2,-" + (maxTypeWidth + 2) + "} | {3,-" + (maxPathWidth + 2) + "} |", "Index","Name", "Type", "Path");
        Console.WriteLine(new string('-',maxIndexWidth + maxNameWidth + maxTypeWidth + maxPathWidth + 22)); // Tamanho total dos campos + espaçamento

        // Itera sobre todos os arquivos e os exibe
        for (int i = 0; i < files.Length; i++)
{
            string file = files[i];
            string fileName = Path.GetFileName(file);
            string fileType = Path.GetExtension(file);
            string filePath = Path.GetFullPath(file);

            Console.WriteLine("| {0,-" + (maxIndexWidth + 4) + "} | {1,-" + (maxNameWidth + 2) + "} | {2,-" + (maxTypeWidth + 2) + "} | {3,-" + (maxPathWidth + 2) + "} |", i+1, fileName, fileType, filePath);
        }

        // Imprime a linha inferior
        Console.WriteLine(new string('-',maxIndexWidth + maxNameWidth + maxTypeWidth + maxPathWidth + 22));
        Console.ResetColor();
    }


    public static void Creat(){
        Console.Clear();
        Console.WriteLine("=============================== CREAT FILE ===============================\n");
        string text = Input.Text();
        Salve(text);
    }

    public static void Salve(string text){

        Console.Clear();
        Console.WriteLine("What is the name to save the file?");
        string name = Console.ReadLine();
        bool response = ManagerFile.Salve(name, text);
        if (!response){
            Console.WriteLine("Error: Error, please try again!");
            Thread.Sleep(2500);
            Salve(text);
        }
        Console.WriteLine("File created successfully!");
        Thread.Sleep(2500);
        Menu.Start();  
    }

    public static void Read(){

        Console.Clear();
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx READ FILE xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.Write("Index: ");
        int index = Input.Index();
        if(index == 0 && index <= 0){
            Console.WriteLine("Error: Index 0 reserved, please try again!");
            Thread.Sleep(2500);
            Read();
            
        }else{
            
       
        ManagerFile.Read(index);
        
        }
        
    }
    public static void Update(){

        Console.Clear();
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx UPDATE FILE xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.Write("Index File: ");
        int index = Input.Index();
        if(index == 0 && index <= 0){
            Console.WriteLine("Error:Index 0 reserved, please try again!");
            Update();
            
        }else{
            
       
            ManagerFile.Read(index);
            int option = Input.Update();
            if(option == 4){
                Update();
            }

            ManagerFile.Update(index, option);
            Thread.Sleep(2500);
            Menu.Start();
            
        
        }
        
    }
}