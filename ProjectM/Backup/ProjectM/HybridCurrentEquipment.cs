// Decompiled with JetBrains decompiler
// Type: ProjectM.HybridCurrentEquipment
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HybridCurrentEquipment
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorHeadgearSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorChestSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_GrimoireSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorFootgearSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorLegsSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClothChestSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClothLegsSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloakSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorGlovesSlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponRunCycle;
    [FieldOffset(0)]
    public PrefabGUID ArmorHeadgearSlotId;
    [FieldOffset(4)]
    public PrefabGUID ArmorChestSlotId;
    [FieldOffset(8)]
    public PrefabGUID WeaponSlotId;
    [FieldOffset(12)]
    public PrefabGUID GrimoireSlotId;
    [FieldOffset(16)]
    public PrefabGUID ArmorFootgearSlotId;
    [FieldOffset(20)]
    public PrefabGUID ArmorLegsSlotId;
    [FieldOffset(24)]
    public PrefabGUID ClothChestSlotId;
    [FieldOffset(28)]
    public PrefabGUID ClothLegsSlotId;
    [FieldOffset(32)]
    public PrefabGUID CloakSlotId;
    [FieldOffset(36)]
    public PrefabGUID ArmorGlovesSlotId;
    [FieldOffset(40)]
    public int WeaponRunCycle;

    static HybridCurrentEquipment()
    {
      Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HybridCurrentEquipment));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr);
      HybridCurrentEquipment.NativeFieldInfoPtr_ArmorHeadgearSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr, nameof (ArmorHeadgearSlotId));
      HybridCurrentEquipment.NativeFieldInfoPtr_ArmorChestSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr, nameof (ArmorChestSlotId));
      HybridCurrentEquipment.NativeFieldInfoPtr_WeaponSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr, nameof (WeaponSlotId));
      HybridCurrentEquipment.NativeFieldInfoPtr_GrimoireSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr, nameof (GrimoireSlotId));
      HybridCurrentEquipment.NativeFieldInfoPtr_ArmorFootgearSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr, nameof (ArmorFootgearSlotId));
      HybridCurrentEquipment.NativeFieldInfoPtr_ArmorLegsSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr, nameof (ArmorLegsSlotId));
      HybridCurrentEquipment.NativeFieldInfoPtr_ClothChestSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr, nameof (ClothChestSlotId));
      HybridCurrentEquipment.NativeFieldInfoPtr_ClothLegsSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr, nameof (ClothLegsSlotId));
      HybridCurrentEquipment.NativeFieldInfoPtr_CloakSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr, nameof (CloakSlotId));
      HybridCurrentEquipment.NativeFieldInfoPtr_ArmorGlovesSlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr, nameof (ArmorGlovesSlotId));
      HybridCurrentEquipment.NativeFieldInfoPtr_WeaponRunCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr, nameof (WeaponRunCycle));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridCurrentEquipment>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
