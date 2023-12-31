// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitRespawnSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class UnitRespawnSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_MinDuration;
    private static readonly IntPtr NativeFieldInfoPtr_MaxDuration;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitRespawnSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitRespawnSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitRespawnSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitRespawnSettings()
    {
      Il2CppClassPointerStore<UnitRespawnSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitRespawnSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitRespawnSettings>.NativeClassPtr);
      UnitRespawnSettings.NativeFieldInfoPtr_MinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitRespawnSettings>.NativeClassPtr, nameof (MinDuration));
      UnitRespawnSettings.NativeFieldInfoPtr_MaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitRespawnSettings>.NativeClassPtr, nameof (MaxDuration));
      UnitRespawnSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitRespawnSettings>.NativeClassPtr, 100666011);
    }

    public UnitRespawnSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MinDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitRespawnSettings.NativeFieldInfoPtr_MinDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitRespawnSettings.NativeFieldInfoPtr_MinDuration)) = value;
      }
    }

    public unsafe float MaxDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitRespawnSettings.NativeFieldInfoPtr_MaxDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitRespawnSettings.NativeFieldInfoPtr_MaxDuration)) = value;
      }
    }
  }
}
