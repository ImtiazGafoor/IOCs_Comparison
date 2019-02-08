# IOCs_Comparison
A comparison of .NET iocs

This is a simple project where I compared the different Inversion of Control tools for basic resolution and registration available for NET projects. Specifically, I analyzed the speed for each of the following tools. Here are some stats based on my assessment for each. I tested by using a repository, switching its implementation, and performing a simple getbyid and getall call.

1. Simple Injector - https://simpleinjector.readthedocs.io/en/latest/index.html 
                   - As of 2/8/2019   4,496,393 total downloads on nuget
                   - Time - Single: 0ms List: 145ms
                   
2. Lamar  - https://jasperfx.github.io/lamar/documentation/ioc/
          - As of 2/8/2019   31,100 total downloads on nuget
          - Time - Single: 0ms List: 0ms - Thru a a warning about a library it couldn't find that messed my stats.
          
3. Windsor - https://www.codementor.io/copperstarconsulting/getting-started-with-dependency-injection-using-castle-windsor-4meqzcsvh
           - As of 2/8/2019  4,626,686 total downloads on nuget
           - Time - Single: 0ms List: 124ms
           
4. Unity - https://github.com/unitycontainer/unity Unity has limited documentation so I referred to other helpful resources like: https://www.tutorialsteacher.com/ioc/install-unity-container
         - As of 2/8/2019  15,519,709 total downloads on nuget
         - Time - Single: 0ms List: 51ms 
         
5. Ninject - http://www.ninject.org/download.html
           - As of 2/8/2019  8,672,378 total downloads on nuget
           - Time - Single: 0ms List: 43ms 
           
6. Autofac - https://autofac.org/
           - As of 2/8/2019  20,069,756 total downloads on nuget
           - Time - Single: 0ms List: 19ms 

After weighing in the pros and cons it seems like Autofac is the right choice to make. It has a large community that, documentation, and it's speed is impressive for the tests I ran.
