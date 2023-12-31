// Decompiled with JetBrains decompiler
// Type: ProjectM.Unit_StatsSettings_Asset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

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
  public class Unit_StatsSettings_Asset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_statsEditorData;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID PrefabGuid
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 726435, RefRangeEnd = 726444, XrefRangeStart = 726435, XrefRangeEnd = 726444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Unit_StatsSettings_Asset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749481, XrefRangeEnd = 749521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Unit_StatsSettings_Asset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749521, XrefRangeEnd = 749529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Unit_StatsSettings_Asset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unit_StatsSettings_Asset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Unit_StatsSettings_Asset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Unit_StatsSettings_Asset()
    {
      Il2CppClassPointerStore<Unit_StatsSettings_Asset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Unit_StatsSettings_Asset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Unit_StatsSettings_Asset>.NativeClassPtr);
      Unit_StatsSettings_Asset.NativeFieldInfoPtr_statsEditorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unit_StatsSettings_Asset>.NativeClassPtr, nameof (statsEditorData));
      Unit_StatsSettings_Asset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unit_StatsSettings_Asset>.NativeClassPtr, nameof (_Guid));
      Unit_StatsSettings_Asset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unit_StatsSettings_Asset>.NativeClassPtr, 100666020);
      Unit_StatsSettings_Asset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unit_StatsSettings_Asset>.NativeClassPtr, 100666021);
      Unit_StatsSettings_Asset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unit_StatsSettings_Asset>.NativeClassPtr, 100666022);
    }

    public Unit_StatsSettings_Asset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<Unit_StatsSettings_EditorData> statsEditorData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Unit_StatsSettings_Asset.NativeFieldInfoPtr_statsEditorData));
        return pointer == IntPtr.Zero ? (List<Unit_StatsSettings_EditorData>) null : new List<Unit_StatsSettings_EditorData>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Unit_StatsSettings_Asset.NativeFieldInfoPtr_statsEditorData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Unit_StatsSettings_Asset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Unit_StatsSettings_Asset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
