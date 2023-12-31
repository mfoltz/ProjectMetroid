// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.AbilityRange
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityRange
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_Max;
    [FieldOffset(0)]
    public float Min;
    [FieldOffset(4)]
    public float Max;

    static AbilityRange()
    {
      Il2CppClassPointerStore<AbilityRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Behaviours", nameof (AbilityRange));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityRange>.NativeClassPtr);
      AbilityRange.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRange>.NativeClassPtr, nameof (Min));
      AbilityRange.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRange>.NativeClassPtr, nameof (Max));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityRange>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
