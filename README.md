# Text Editor

This is a simple text editor implemented in C# with a console interface. The editor allows users to create, read, update, and delete text files.

## Features

- **Create:** Allows users to create a new text file and save it with a specified name.
- **Read:** Enables users to read the contents of a text file by specifying its index.
- **Update:** Allows users to update the contents of a text file by specifying its index and choosing from various update options.
- **Delete:** Allows users to delete a text file by specifying its index.
- **List Files:** Lists all the available text files along with their details such as index, name, type, and path.
- **Exit:** Exits the text editor.

## Usage

To use the text editor, follow these steps:

1. Compile and run the program.
2. Choose an option from the main menu:
   - **1:** Create a new text file.
   - **2:** Read the contents of a text file.
   - **3:** Update the contents of a text file.
   - **4:** Delete a text file.
   - **5:** List all available text files.
   - **6:** Exit the text editor.
3. Follow the prompts to perform the selected operation.

## Code Overview

The text editor consists of four main classes: `Menu`, `Screen`, `Input`, and `ManagerFile`.

- **Menu:** Contains the main menu options and handles user input.
- **Screen:** Contains methods for various operations like creating, reading, updating, and deleting files.
- **Input:** Contains methods for handling user input such as reading options, text, index, update options, and continuation.
- **ManagerFile:** Handles file operations like reading, writing, updating, and deleting files.

```csharp
public class Menu {
    // Main menu options and switch case implementation
}

public class Screen {
    // Methods for file operations such as Create, Read, Update, Delete, and ListFile
}

public class Input {
    // Methods for handling user input such as Options, Text, Index, Update, and Continue
}

public class ManagerFile {
    // Methods for file operations such as Read, Delete, Update, Salve, and ListFile
}
