// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.RandomMutant
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RandomMutant
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Mutant;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    [FieldOffset(0)]
    public PrefabGUID Mutant;
    [FieldOffset(4)]
    public int Weight;

    static RandomMutant()
    {
      Il2CppClassPointerStore<RandomMutant>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (RandomMutant));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomMutant>.NativeClassPtr);
      RandomMutant.NativeFieldInfoPtr_Mutant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMutant>.NativeClassPtr, nameof (Mutant));
      RandomMutant.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMutant>.NativeClassPtr, nameof (Weight));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomMutant>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
