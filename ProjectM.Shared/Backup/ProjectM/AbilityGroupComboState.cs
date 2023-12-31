// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityGroupComboState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityGroupComboState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ComboIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComboLength;
    [FieldOffset(0)]
    public int ComboIndex;
    [FieldOffset(4)]
    public int ComboLength;

    static AbilityGroupComboState()
    {
      Il2CppClassPointerStore<AbilityGroupComboState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityGroupComboState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityGroupComboState>.NativeClassPtr);
      AbilityGroupComboState.NativeFieldInfoPtr_ComboIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupComboState>.NativeClassPtr, nameof (ComboIndex));
      AbilityGroupComboState.NativeFieldInfoPtr_ComboLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupComboState>.NativeClassPtr, nameof (ComboLength));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityGroupComboState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
