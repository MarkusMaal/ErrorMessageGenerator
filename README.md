# ErrorMessageGenerator
This program allows you to generate custom error messages. Features:
* Customizable error message icon
* Customizable error message buttons
* Customizable default selection on error message
* Conditional error messages - these types of messages appear based on previous actions by the user
* Export and import macro files
* Quiet mode

## Quiet mode
To use the quiet mode, you need to do the following:
1. Export the error message(s) if you haven\'t done so already
2. Open the directory the executable of ErrorMessageGenerator is located at
3. Pass the filename into the arguments after the executable name. If the path contains spaces, it must be in quotes. Example `ErrorMessageGenerator filename.emm`
4. This will hopefully just display the error message(s) without starting the interface. If you want to load the main interface, you can add a -forcegui argument. Example `ErrorMessageGenerator filename.emm -forcegui`
