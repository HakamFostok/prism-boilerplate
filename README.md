# What is prism-boilerplate
  Prism-Boilerplate is a basic setup for WPF application with Prism library installed, which is targeting .NET Core.

### Technical Prerequisite
  1. Visual Studio 2019 
  2. NET Core 3.1
  
### Personal Prerequisite
  You need to be familiar with 
  1. C#.
  2. WPF 
  3. Prism library  

### When should I used it
  if you are creating new WPF application targeting .NET Core and you will setup Prism library, then this project will save your time by providing some of the basics that you need for almost every WPF prism project.

### Is prism-boilerplate an architecture?
  Well, No. It is just a basic setup to save you from the chores of setting up an WPF Prism application. <br/>
  You can architect your project as you want, which give you the flexibility you need. <br/>
  Prism-boilerplate will give you intitial boost for the start of the project. <br/>
  and Also will give you some important building blocks to use them along the way.
  
### How to use it
  for now you can clone the repository and change the name of the projects as you want. <br/>
  for future releases we will improve this process to make it easier.

### What is the architecture of the template
  1. WPF application (Startup Project) which represnet very thin layer to access the project.
  2. Modules folder, which contains two projects. <br/>
    - SharedModule: which basically contains all the basic setup for the project. <br/>
    - MainModule: which is basically an example module, it is just for demonstration. it contains No important functionality.
    
### What is the benifits
  1. FileDialogService which is MVVM way to call OpenFileDialog.
  2. MessageBoxService which is MVVM way to call WPF MessageBox methods.
  3. Base View-Model already containing all the services in the project <br/>
     The base View-Model will provide the access to : <br/>
     * IEventAggregator: service to allow you send and subscribe for prism events. (**Prism Service**) <br/>
     * IRegionManager: service to allow you manage the regions for the applications modules. (**Prism service**) <br/>
     * IDialogService: service to allow you open new windows in MVVM way (**Prism service**) <br/>
     * IFileDialogService: service to allow you access the OpenFileDialog. <br/>
     * IMessageBoxService: service to allow you access the MessageBox. <br/>
     * ILogService: service to allow you log errors and info. <br />
     
  4. One class in the shared module to manage all your Region Names.
  5. One class in the shared module to manage all your Events.
  6. LogService for logging service. <br/>
     NLog is installed and confguired.
   
### Contributions
   Pull Requests is very welcomed <br />
   There is no need to change your style to contribute on this repository <br />
   Code with your own standards <br/>
   It is our mission to re-style your code if your PR merged.
