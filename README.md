# Moneybags 💰

## Build Environment Setup

Moneybags development is done in VS Code using the Java Extension Pack. It targets JDK 21 (Latest LTS at the time of writing).

As development will be primarily done on Windows, the following instructions are written with Windows in mind.

Moneybags uses the Gradle build system.

### Getting the JDK

To install the JDK (OpenJDK 21, specifically), the simplest way (imo) is to use Scoop.

> Note: Please remove any older or different versions of Java already installed to prevent VS Code from getting confused

1. Install Scoop Package Manager if you don't have it already:

    ```powershell
    Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
    Invoke-RestMethod -Uri https://get.scoop.sh | Invoke-Expression
    ```

2. Set up Scoop by installing Git and adding the Java bucket (buckets are just repositories):

    ```powershell
    scoop bucket install git
    scoop bucket add java
    ```

3. Install OpenJDK 21:

    ```powershell
    scoop install openjdk21
    ```

4. Set the `JAVA_HOME` **user** environment variable to the installation directory `C:\Users\<your-username>\scoop\apps\openjdk21\current`

    One of the benefits of using Scoop is that the `current` directory is symlinked, so if you update JDK 21, you won't need to update your `JAVA_HOME` variable.

5. Install WiX Toolset from [here](https://github.com/wixtoolset/wix3/releases/download/wix3141rtm/wix314.exe) - required for creating native executables.

6. Add the WiX Toolset bins to your **user** `Path`: `C:\Program Files (x86)\WiX Toolset v3.14\bin`

### Getting JavaFX

1. Download OpenJFX 21 from [here](https://gluonhq.com/products/javafx/).
2. Install it somewhere sensible on your machine, it doesn't really matter where because we refer to the `OPENJFX_HOME` environment variable within the project.
3. Set the `OPENJFX_HOME` **user** environment variable to the directory where you've installed JavaFX.

### Configuring VS Code

1. Install VS Code
2. Install the Java Extension Pack

### Common Practices within VS Code

- Interact with files using the `Java Projects` section in the sidebar rather than with the directory explorer, it allows for easy package and class creation.

## Building with Gradle

To build the project with Gradle, run `./gradlew build`

To distribute, run `./gradlew dist` - This will create a self-contained executable in the `app/bin/dist` directory.

## Further Reading

[CONTRIBUTING](https://github.com/soda3x/Moneybags/blob/main/CONTRIBUTING.md)

[STYLE](https://github.com/soda3x/Moneybags/blob/main/STYLE.md)
