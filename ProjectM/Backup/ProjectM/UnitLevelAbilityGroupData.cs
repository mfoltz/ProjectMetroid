// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitLevelAbilityGroupData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitLevelAbilityGroupData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroup;
    [FieldOffset(0)]
    public int UnitLevel;
    [FieldOffset(4)]
    public PrefabGUID AbilityGroup;

    static UnitLevelAbilityGroupData()
    {
      Il2CppClassPointerStore<UnitLevelAbilityGroupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UnitLevelAbilityGroupData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitLevelAbilityGroupData>.NativeClassPtr);
      UnitLevelAbilityGroupData.NativeFieldInfoPtr_UnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitLevelAbilityGroupData>.NativeClassPtr, nameof (UnitLevel));
      UnitLevelAbilityGroupData.NativeFieldInfoPtr_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitLevelAbilityGroupData>.NativeClassPtr, nameof (AbilityGroup));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitLevelAbilityGroupData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
