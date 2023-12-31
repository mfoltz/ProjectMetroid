// Decompiled with JetBrains decompiler
// Type: ProjectM.KnockbackPowerEditorData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class KnockbackPowerEditorData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_StunMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseWeaponLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurationFactor;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749124, XrefRangeEnd = 749125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KnockbackPowerEditorData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KnockbackPowerEditorData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KnockbackPowerEditorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static KnockbackPowerEditorData()
    {
      Il2CppClassPointerStore<KnockbackPowerEditorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (KnockbackPowerEditorData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackPowerEditorData>.NativeClassPtr);
      KnockbackPowerEditorData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPowerEditorData>.NativeClassPtr, nameof (Guid));
      KnockbackPowerEditorData.NativeFieldInfoPtr_StunMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPowerEditorData>.NativeClassPtr, nameof (StunMode));
      KnockbackPowerEditorData.NativeFieldInfoPtr_UseWeaponLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPowerEditorData>.NativeClassPtr, nameof (UseWeaponLevel));
      KnockbackPowerEditorData.NativeFieldInfoPtr_WeaponLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPowerEditorData>.NativeClassPtr, nameof (WeaponLevel));
      KnockbackPowerEditorData.NativeFieldInfoPtr_DistanceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPowerEditorData>.NativeClassPtr, nameof (DistanceFactor));
      KnockbackPowerEditorData.NativeFieldInfoPtr_DurationFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPowerEditorData>.NativeClassPtr, nameof (DurationFactor));
      KnockbackPowerEditorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnockbackPowerEditorData>.NativeClassPtr, 100665965);
    }

    public KnockbackPowerEditorData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerEditorData.NativeFieldInfoPtr_Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerEditorData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe KnockbackStunMode StunMode
    {
      get
      {
        return *(KnockbackStunMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerEditorData.NativeFieldInfoPtr_StunMode));
      }
      [param: In] set
      {
        *(KnockbackStunMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerEditorData.NativeFieldInfoPtr_StunMode)) = value;
      }
    }

    public unsafe bool UseWeaponLevel
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerEditorData.NativeFieldInfoPtr_UseWeaponLevel));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerEditorData.NativeFieldInfoPtr_UseWeaponLevel)) = value;
      }
    }

    public unsafe int WeaponLevel
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerEditorData.NativeFieldInfoPtr_WeaponLevel));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerEditorData.NativeFieldInfoPtr_WeaponLevel)) = value;
      }
    }

    public unsafe float DistanceFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerEditorData.NativeFieldInfoPtr_DistanceFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerEditorData.NativeFieldInfoPtr_DistanceFactor)) = value;
      }
    }

    public unsafe float DurationFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerEditorData.NativeFieldInfoPtr_DurationFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KnockbackPowerEditorData.NativeFieldInfoPtr_DurationFactor)) = value;
      }
    }
  }
}
