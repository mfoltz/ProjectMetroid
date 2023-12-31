// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.JewelInstance
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct JewelInstance
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellSchool;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_TierIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideAbilityType;
    [FieldOffset(0)]
    public PrefabGUID SpellSchool;
    [FieldOffset(4)]
    public PrefabGUID Ability;
    [FieldOffset(8)]
    public byte TierIndex;
    [FieldOffset(12)]
    public PrefabGUID OverrideAbilityType;

    static JewelInstance()
    {
      Il2CppClassPointerStore<JewelInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (JewelInstance));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelInstance>.NativeClassPtr);
      JewelInstance.NativeFieldInfoPtr_SpellSchool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelInstance>.NativeClassPtr, nameof (SpellSchool));
      JewelInstance.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelInstance>.NativeClassPtr, nameof (Ability));
      JewelInstance.NativeFieldInfoPtr_TierIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelInstance>.NativeClassPtr, nameof (TierIndex));
      JewelInstance.NativeFieldInfoPtr_OverrideAbilityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelInstance>.NativeClassPtr, nameof (OverrideAbilityType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelInstance>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
