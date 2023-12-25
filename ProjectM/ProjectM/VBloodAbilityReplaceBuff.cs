// Decompiled with JetBrains decompiler
// Type: ProjectM.VBloodAbilityReplaceBuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VBloodAbilityReplaceBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGUID;
    [FieldOffset(0)]
    public AbilityTypeEnum AbilityType;
    [FieldOffset(4)]
    public PrefabGUID AbilityGUID;

    static VBloodAbilityReplaceBuff()
    {
      Il2CppClassPointerStore<VBloodAbilityReplaceBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VBloodAbilityReplaceBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodAbilityReplaceBuff>.NativeClassPtr);
      VBloodAbilityReplaceBuff.NativeFieldInfoPtr_AbilityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodAbilityReplaceBuff>.NativeClassPtr, nameof (AbilityType));
      VBloodAbilityReplaceBuff.NativeFieldInfoPtr_AbilityGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodAbilityReplaceBuff>.NativeClassPtr, nameof (AbilityGUID));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodAbilityReplaceBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
