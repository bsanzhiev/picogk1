using Leap71.ShapeKernel;
using PicoGK;

string strOutputFolder = "/Users/bash/devs/PicoGK-Examples";

try
{
    Console.WriteLine("Hello, World!");
    PicoGK.Library.Go(
        0.1f,
        Leap71.ShapeKernelExamples.ImplicitGyroidSphere.Task,
        strOutputFolder
        );
}
catch (Exception e)
{
    Console.WriteLine("Failed to run Task.");
    Console.WriteLine(e.ToString());
}