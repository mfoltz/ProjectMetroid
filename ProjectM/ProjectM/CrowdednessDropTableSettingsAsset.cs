// Decompiled with JetBrains decompiler
// Type: ProjectM.CrowdednessDropTableSettingsAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class CrowdednessDropTableSettingsAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Settings;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012823, XrefRangeEnd = 1012836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(Entity entity, EntityManager dstManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CrowdednessDropTableSettingsAsset.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CrowdednessDropTableSettingsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrowdednessDropTableSettingsAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CrowdednessDropTableSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CrowdednessDropTableSettingsAsset()
    {
      Il2CppClassPointerStore<CrowdednessDropTableSettingsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CrowdednessDropTableSettingsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrowdednessDropTableSettingsAsset>.NativeClassPtr);
      CrowdednessDropTableSettingsAsset.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdednessDropTableSettingsAsset>.NativeClassPtr, nameof (Settings));
      CrowdednessDropTableSettingsAsset.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdednessDropTableSettingsAsset>.NativeClassPtr, 100678923);
      CrowdednessDropTableSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdednessDropTableSettingsAsset>.NativeClassPtr, 100678924);
    }

    public CrowdednessDropTableSettingsAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<CrowdednessDropTableSettingsAsset.CrowdednessSetting> Settings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdednessDropTableSettingsAsset.NativeFieldInfoPtr_Settings));
        return pointer == System.IntPtr.Zero ? (List<CrowdednessDropTableSettingsAsset.CrowdednessSetting>) null : new List<CrowdednessDropTableSettingsAsset.CrowdednessSetting>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdednessDropTableSettingsAsset.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct CrowdednessSetting
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DropChance;
      [FieldOffset(0)]
      public float DropChance;

      static CrowdednessSetting()
      {
        Il2CppClassPointerStore<CrowdednessDropTableSettingsAsset.CrowdednessSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrowdednessDropTableSettingsAsset>.NativeClassPtr, nameof (CrowdednessSetting));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrowdednessDropTableSettingsAsset.CrowdednessSetting>.NativeClassPtr);
        CrowdednessDropTableSettingsAsset.CrowdednessSetting.NativeFieldInfoPtr_DropChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdednessDropTableSettingsAsset.CrowdednessSetting>.NativeClassPtr, nameof (DropChance));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CrowdednessDropTableSettingsAsset.CrowdednessSetting>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
