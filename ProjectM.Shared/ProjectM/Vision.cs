// Decompiled with JetBrains decompiler
// Type: ProjectM.Vision
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Vision
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    [FieldOffset(0)]
    public ModifiableFloat Range;

    static Vision()
    {
      Il2CppClassPointerStore<Vision>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Vision));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vision>.NativeClassPtr);
      Vision.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vision>.NativeClassPtr, nameof (Range));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vision>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
