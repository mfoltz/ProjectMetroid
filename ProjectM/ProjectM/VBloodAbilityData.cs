// Decompiled with JetBrains decompiler
// Type: ProjectM.VBloodAbilityData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VBloodAbilityData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilitySchool;
    [FieldOffset(0)]
    public AbilityTypeEnum AbilityType;
    [FieldOffset(4)]
    public AbilitySchoolType AbilitySchool;

    static VBloodAbilityData()
    {
      Il2CppClassPointerStore<VBloodAbilityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VBloodAbilityData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodAbilityData>.NativeClassPtr);
      VBloodAbilityData.NativeFieldInfoPtr_AbilityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodAbilityData>.NativeClassPtr, nameof (AbilityType));
      VBloodAbilityData.NativeFieldInfoPtr_AbilitySchool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodAbilityData>.NativeClassPtr, nameof (AbilitySchool));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodAbilityData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
