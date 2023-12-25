// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceNodeOverride
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class SequenceNodeOverride : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseDuration_Override;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration_Override;
    private static readonly System.IntPtr NativeFieldInfoPtr__Version;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentVersion_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateVersion_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentVersion_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashFromObjectIfNotNull_Protected_Int32_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Abstract_Virtual_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasAnyOverride_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnVersionChange_Public_Virtual_New_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddGameObjectReferences_Public_Abstract_Virtual_New_Void_List_1_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDeterministicHash_Public_Abstract_Virtual_New_Int32_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    public virtual unsafe int CurrentVersion
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1098176, RefRangeEnd = 1098188, XrefRangeStart = 1098176, XrefRangeEnd = 1098176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ValidateVersion()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverride.NativeMethodInfoPtr_ValidateVersion_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 1098188, RefRangeEnd = 1098206, XrefRangeStart = 1098188, XrefRangeEnd = 1098188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetCurrentVersion()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverride.NativeMethodInfoPtr_SetCurrentVersion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1098206, RefRangeEnd = 1098209, XrefRangeStart = 1098206, XrefRangeEnd = 1098206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetHashFromObjectIfNotNull(Il2CppSystem.Object obj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverride.NativeMethodInfoPtr_GetHashFromObjectIfNotNull_Protected_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool HasNodeAnyOverride()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool HasAnyOverride()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverride.NativeMethodInfoPtr_HasAnyOverride_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnVersionChange(int previousVersion, int newVersion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &previousVersion;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newVersion;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceNodeOverride.NativeMethodInfoPtr_OnVersionChange_Public_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void AddGameObjectReferences(List<GameObject> references)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) references);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Abstract_Virtual_New_Void_List_1_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe int GetDeterministicHash(UnityEngine.Object sourceAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceAsset);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Abstract_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceNodeOverride()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceNodeOverride.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceNodeOverride()
    {
      Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceNodeOverride));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr);
      SequenceNodeOverride.NativeFieldInfoPtr_NodeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, nameof (NodeGuid));
      SequenceNodeOverride.NativeFieldInfoPtr_UseOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, nameof (UseOverride));
      SequenceNodeOverride.NativeFieldInfoPtr_UseDuration_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, nameof (UseDuration_Override));
      SequenceNodeOverride.NativeFieldInfoPtr_Duration_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, nameof (Duration_Override));
      SequenceNodeOverride.NativeFieldInfoPtr__Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, nameof (_Version));
      SequenceNodeOverride.NativeFieldInfoPtr__CurrentVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, "<CurrentVersion>k__BackingField");
      SequenceNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, 100687211);
      SequenceNodeOverride.NativeMethodInfoPtr_ValidateVersion_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, 100687212);
      SequenceNodeOverride.NativeMethodInfoPtr_SetCurrentVersion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, 100687213);
      SequenceNodeOverride.NativeMethodInfoPtr_GetHashFromObjectIfNotNull_Protected_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, 100687214);
      SequenceNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, 100687215);
      SequenceNodeOverride.NativeMethodInfoPtr_HasAnyOverride_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, 100687216);
      SequenceNodeOverride.NativeMethodInfoPtr_OnVersionChange_Public_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, 100687217);
      SequenceNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Abstract_Virtual_New_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, 100687218);
      SequenceNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Abstract_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, 100687219);
      SequenceNodeOverride.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNodeOverride>.NativeClassPtr, 100687220);
    }

    public SequenceNodeOverride(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string NodeGuid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverride.NativeFieldInfoPtr_NodeGuid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverride.NativeFieldInfoPtr_NodeGuid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool UseOverride
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverride.NativeFieldInfoPtr_UseOverride));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverride.NativeFieldInfoPtr_UseOverride)) = value;
      }
    }

    public unsafe bool UseDuration_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverride.NativeFieldInfoPtr_UseDuration_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverride.NativeFieldInfoPtr_UseDuration_Override)) = value;
      }
    }

    public unsafe float Duration_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverride.NativeFieldInfoPtr_Duration_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverride.NativeFieldInfoPtr_Duration_Override)) = value;
      }
    }

    public unsafe int _Version
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverride.NativeFieldInfoPtr__Version));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverride.NativeFieldInfoPtr__Version)) = value;
      }
    }

    public unsafe int _CurrentVersion_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverride.NativeFieldInfoPtr__CurrentVersion_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceNodeOverride.NativeFieldInfoPtr__CurrentVersion_k__BackingField)) = value;
      }
    }
  }
}
