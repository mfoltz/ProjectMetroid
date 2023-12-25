// Decompiled with JetBrains decompiler
// Type: ProjectM.ChangeModelWhenDecaying
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChangeModelWhenDecaying
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthThreshold;
    [FieldOffset(0)]
    public half HealthThreshold;

    static ChangeModelWhenDecaying()
    {
      Il2CppClassPointerStore<ChangeModelWhenDecaying>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ChangeModelWhenDecaying));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeModelWhenDecaying>.NativeClassPtr);
      ChangeModelWhenDecaying.NativeFieldInfoPtr_HealthThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeModelWhenDecaying>.NativeClassPtr, nameof (HealthThreshold));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeModelWhenDecaying>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
