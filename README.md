# BaseMod

This repository provides a template for creating a Limbus Company BepInEx mod.

# Development

1. Make sure you have installed BepInEx #577 on Limbus Company, and that you have launched Limbus Company with
   BepInEx installed at least once
2. To setup a dev environment, copy the file `Directory.Build.example.props` in `src/` and rename the copy to
   `Directory.Build.props`
3. Modify the file as per the instructions inside
4. Modify `BasePlugin.csproj`, change `RootNamespace` to the name of your mod.
5. Modify `main.cs`, change `BaseMod` in `namespace BaseMod;` to what you've entered in step 4.
   Change `Name`, `Version`, and `Author` as you wish.
6. Modify `AssemblyInfo.cs` and fix the line `using static BaseMod.Main;` to use the proper root namespace.
7. Whenever you build, the development build of the BepInEx plugin should automatically be copied to your game folder.

