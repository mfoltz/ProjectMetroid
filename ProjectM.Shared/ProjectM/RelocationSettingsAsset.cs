// Decompiled with JetBrains decompiler
// Type: ProjectM.RelocationSettingsAsset
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
  public class RelocationSettingsAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_TimeMinMax;
    private static readonly IntPtr NativeFieldInfoPtr_CombatAreaData;
    private static readonly IntPtr NativeMethodInfoPtr_get_CombatAreaRelocationDistance_Public_get_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe float CombatAreaRelocationDistance
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 723610, RefRangeEnd = 723615, XrefRangeStart = 723610, XrefRangeEnd = 723610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(RelocationSettingsAsset.NativeMethodInfoPtr_get_CombatAreaRelocationDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RelocationSettingsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelocationSettingsAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RelocationSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RelocationSettingsAsset()
    {
      Il2CppClassPointerStore<RelocationSettingsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RelocationSettingsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelocationSettingsAsset>.NativeClassPtr);
      RelocationSettingsAsset.NativeFieldInfoPtr_TimeMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelocationSettingsAsset>.NativeClassPtr, nameof (TimeMinMax));
      RelocationSettingsAsset.NativeFieldInfoPtr_CombatAreaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelocationSettingsAsset>.NativeClassPtr, nameof (CombatAreaData));
      RelocationSettingsAsset.NativeMethodInfoPtr_get_CombatAreaRelocationDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelocationSettingsAsset>.NativeClassPtr, 100663971);
      RelocationSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelocationSettingsAsset>.NativeClassPtr, 100663972);
    }

    public RelocationSettingsAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector2 TimeMinMax
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelocationSettingsAsset.NativeFieldInfoPtr_TimeMinMax));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelocationSettingsAsset.NativeFieldInfoPtr_TimeMinMax)) = value;
      }
    }

    public unsafe RelocationData_CombatArea CombatAreaData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelocationSettingsAsset.NativeFieldInfoPtr_CombatAreaData));
        return pointer == IntPtr.Zero ? (RelocationData_CombatArea) null : new RelocationData_CombatArea(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RelocationSettingsAsset.NativeFieldInfoPtr_CombatAreaData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
