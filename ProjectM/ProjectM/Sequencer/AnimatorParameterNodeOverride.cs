// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AnimatorParameterNodeOverride
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
  public class AnimatorParameterNodeOverride : SequenceNodeOverride
  {
    private static readonly IntPtr NativeFieldInfoPtr_GUID;
    private static readonly IntPtr NativeFieldInfoPtr_UseParameterName_Override;
    private static readonly IntPtr NativeFieldInfoPtr_ParameterName_Override;
    private static readonly IntPtr NativeFieldInfoPtr_SetAnimationListeners_Override;
    private static readonly IntPtr NativeFieldInfoPtr_RestoreOnFinish_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseParameterType_Override;
    private static readonly IntPtr NativeFieldInfoPtr_ParameterType_Override;
    private static readonly IntPtr NativeFieldInfoPtr_ParamterFloat_Override;
    private static readonly IntPtr NativeFieldInfoPtr_ParamterInt_Override;
    private static readonly IntPtr NativeFieldInfoPtr_ParamterBool_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseSetAnimationListeners_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseRestoreOnFinish_Override;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateNew_Public_Static_AnimatorParameterNodeOverride_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_AnimatorParameterNodeOverride_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int CurrentVersion
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimatorParameterNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void AddGameObjectReferences(List<GameObject> references)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) references);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimatorParameterNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093876, XrefRangeEnd = 1093885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AnimatorParameterNodeOverride CreateNew(string nodeGuid)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimatorParameterNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_AnimatorParameterNodeOverride_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (AnimatorParameterNodeOverride) null : new AnimatorParameterNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093885, XrefRangeEnd = 1093896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AnimatorParameterNodeOverride CreateDefault()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimatorParameterNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_AnimatorParameterNodeOverride_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (AnimatorParameterNodeOverride) null : new AnimatorParameterNodeOverride(pointer);
    }

    [CallerCount(0)]
    public override unsafe bool HasNodeAnyOverride()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimatorParameterNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093896, XrefRangeEnd = 1093915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetDeterministicHash(UnityEngine.Object sourceAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceAsset);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimatorParameterNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnimatorParameterNodeOverride()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnimatorParameterNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AnimatorParameterNodeOverride()
    {
      Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AnimatorParameterNodeOverride));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr);
      AnimatorParameterNodeOverride.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, nameof (GUID));
      AnimatorParameterNodeOverride.NativeFieldInfoPtr_UseParameterName_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, nameof (UseParameterName_Override));
      AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParameterName_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, nameof (ParameterName_Override));
      AnimatorParameterNodeOverride.NativeFieldInfoPtr_SetAnimationListeners_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, nameof (SetAnimationListeners_Override));
      AnimatorParameterNodeOverride.NativeFieldInfoPtr_RestoreOnFinish_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, nameof (RestoreOnFinish_Override));
      AnimatorParameterNodeOverride.NativeFieldInfoPtr_UseParameterType_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, nameof (UseParameterType_Override));
      AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParameterType_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, nameof (ParameterType_Override));
      AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParamterFloat_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, nameof (ParamterFloat_Override));
      AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParamterInt_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, nameof (ParamterInt_Override));
      AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParamterBool_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, nameof (ParamterBool_Override));
      AnimatorParameterNodeOverride.NativeFieldInfoPtr_UseSetAnimationListeners_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, nameof (UseSetAnimationListeners_Override));
      AnimatorParameterNodeOverride.NativeFieldInfoPtr_UseRestoreOnFinish_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, nameof (UseRestoreOnFinish_Override));
      AnimatorParameterNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, 100686627);
      AnimatorParameterNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, 100686628);
      AnimatorParameterNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_AnimatorParameterNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, 100686629);
      AnimatorParameterNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_AnimatorParameterNodeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, 100686630);
      AnimatorParameterNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, 100686631);
      AnimatorParameterNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, 100686632);
      AnimatorParameterNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterNodeOverride>.NativeClassPtr, 100686633);
    }

    public AnimatorParameterNodeOverride(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string GUID
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_GUID)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool UseParameterName_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_UseParameterName_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_UseParameterName_Override)) = value;
      }
    }

    public unsafe string ParameterName_Override
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParameterName_Override)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParameterName_Override), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool SetAnimationListeners_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_SetAnimationListeners_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_SetAnimationListeners_Override)) = value;
      }
    }

    public unsafe bool RestoreOnFinish_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_RestoreOnFinish_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_RestoreOnFinish_Override)) = value;
      }
    }

    public unsafe bool UseParameterType_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_UseParameterType_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_UseParameterType_Override)) = value;
      }
    }

    public unsafe AnimatorParameterTypeEnum ParameterType_Override
    {
      get
      {
        return *(AnimatorParameterTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParameterType_Override));
      }
      [param: In] set
      {
        *(AnimatorParameterTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParameterType_Override)) = value;
      }
    }

    public unsafe float ParamterFloat_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParamterFloat_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParamterFloat_Override)) = value;
      }
    }

    public unsafe int ParamterInt_Override
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParamterInt_Override));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParamterInt_Override)) = value;
      }
    }

    public unsafe bool ParamterBool_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParamterBool_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_ParamterBool_Override)) = value;
      }
    }

    public unsafe bool UseSetAnimationListeners_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_UseSetAnimationListeners_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_UseSetAnimationListeners_Override)) = value;
      }
    }

    public unsafe bool UseRestoreOnFinish_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_UseRestoreOnFinish_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterNodeOverride.NativeFieldInfoPtr_UseRestoreOnFinish_Override)) = value;
      }
    }
  }
}
