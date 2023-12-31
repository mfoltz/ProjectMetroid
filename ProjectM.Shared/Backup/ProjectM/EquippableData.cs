// Decompiled with JetBrains decompiler
// Type: ProjectM.EquippableData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EquippableData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentType;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponType;
    private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentSet;
    private static readonly System.IntPtr NativeFieldInfoPtr_SCTBrokenText;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurabilitySettings;
    [FieldOffset(0)]
    public PrefabGUID BuffGuid;
    [FieldOffset(4)]
    public EquipmentType EquipmentType;
    [FieldOffset(8)]
    public WeaponType WeaponType;
    [FieldOffset(12)]
    public PrefabGUID EquipmentSet;
    [FieldOffset(16)]
    public AssetGuid SCTBrokenText;
    [FieldOffset(32)]
    public Item_DurabilitySettings DurabilitySettings;

    static EquippableData()
    {
      Il2CppClassPointerStore<EquippableData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EquippableData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquippableData>.NativeClassPtr);
      EquippableData.NativeFieldInfoPtr_BuffGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableData>.NativeClassPtr, nameof (BuffGuid));
      EquippableData.NativeFieldInfoPtr_EquipmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableData>.NativeClassPtr, nameof (EquipmentType));
      EquippableData.NativeFieldInfoPtr_WeaponType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableData>.NativeClassPtr, nameof (WeaponType));
      EquippableData.NativeFieldInfoPtr_EquipmentSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableData>.NativeClassPtr, nameof (EquipmentSet));
      EquippableData.NativeFieldInfoPtr_SCTBrokenText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableData>.NativeClassPtr, nameof (SCTBrokenText));
      EquippableData.NativeFieldInfoPtr_DurabilitySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableData>.NativeClassPtr, nameof (DurabilitySettings));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquippableData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
