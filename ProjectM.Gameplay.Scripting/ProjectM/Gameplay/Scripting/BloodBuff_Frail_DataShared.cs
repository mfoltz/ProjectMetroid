// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BloodBuff_Frail_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff_Frail_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQualityThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModificationId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArmorModificationId;
    [FieldOffset(0)]
    public float BloodQualityThreshold;
    [FieldOffset(4)]
    public float WeaponLevel;
    [FieldOffset(8)]
    public ModificationId WeaponModificationId;
    [FieldOffset(12)]
    public float SpellLevel;
    [FieldOffset(16)]
    public ModificationId SpellModificationId;
    [FieldOffset(20)]
    public float ArmorLevel;
    [FieldOffset(24)]
    public ModificationId ArmorModificationId;

    static BloodBuff_Frail_DataShared()
    {
      Il2CppClassPointerStore<BloodBuff_Frail_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BloodBuff_Frail_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff_Frail_DataShared>.NativeClassPtr);
      BloodBuff_Frail_DataShared.NativeFieldInfoPtr_BloodQualityThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Frail_DataShared>.NativeClassPtr, nameof (BloodQualityThreshold));
      BloodBuff_Frail_DataShared.NativeFieldInfoPtr_WeaponLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Frail_DataShared>.NativeClassPtr, nameof (WeaponLevel));
      BloodBuff_Frail_DataShared.NativeFieldInfoPtr_WeaponModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Frail_DataShared>.NativeClassPtr, nameof (WeaponModificationId));
      BloodBuff_Frail_DataShared.NativeFieldInfoPtr_SpellLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Frail_DataShared>.NativeClassPtr, nameof (SpellLevel));
      BloodBuff_Frail_DataShared.NativeFieldInfoPtr_SpellModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Frail_DataShared>.NativeClassPtr, nameof (SpellModificationId));
      BloodBuff_Frail_DataShared.NativeFieldInfoPtr_ArmorLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Frail_DataShared>.NativeClassPtr, nameof (ArmorLevel));
      BloodBuff_Frail_DataShared.NativeFieldInfoPtr_ArmorModificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff_Frail_DataShared>.NativeClassPtr, nameof (ArmorModificationId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff_Frail_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
