// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityPriority
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityPriority
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    private static readonly System.IntPtr NativeFieldInfoPtr_InterruptLowerPriority;
    private static readonly System.IntPtr NativeFieldInfoPtr_InterruptHigherPriority;
    [FieldOffset(0)]
    public int Priority;
    [FieldOffset(4)]
    public bool InterruptLowerPriority;
    [FieldOffset(5)]
    public bool InterruptHigherPriority;

    static AbilityPriority()
    {
      Il2CppClassPointerStore<AbilityPriority>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilityPriority));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityPriority>.NativeClassPtr);
      AbilityPriority.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPriority>.NativeClassPtr, nameof (Priority));
      AbilityPriority.NativeFieldInfoPtr_InterruptLowerPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPriority>.NativeClassPtr, nameof (InterruptLowerPriority));
      AbilityPriority.NativeFieldInfoPtr_InterruptHigherPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPriority>.NativeClassPtr, nameof (InterruptHigherPriority));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityPriority>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
