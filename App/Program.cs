using App;
using App.Sort;
using CSharpDataStruct.Sort;
using System.Runtime.CompilerServices;

IExercise exercise = Get();
exercise.Do();

static IExercise Get()
{
    return new SortExercise();
}
