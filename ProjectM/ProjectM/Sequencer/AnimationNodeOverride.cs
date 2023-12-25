// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AnimationNodeOverride
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
  public class AnimationNodeOverride : SequenceNodeOverride
  {
    private static readonly IntPtr NativeFieldInfoPtr_AnimationCollection;
    private static readonly IntPtr NativeFieldInfoPtr_AnimationCollectionGuid;
    private static readonly IntPtr NativeFieldInfoPtr_AnimationName;
    private static readonly IntPtr NativeFieldInfoPtr_UseChestAimIk_Override;
    private static readonly IntPtr NativeFieldInfoPtr_ChestAimIk_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseFinishPlaying_Override;
    private static readonly IntPtr NativeFieldInfoPtr_FinishPlaying_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseAnimationType_Override;
    private static readonly IntPtr NativeFieldInfoPtr_AnimationType_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseBlendIn_Override;
    private static readonly IntPtr NativeFieldInfoPtr_BlendIn_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseBlendOut_Override;
    private static readonly IntPtr NativeFieldInfoPtr_BlendOut_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseBlendOutIfRunning_Override;
    private static readonly IntPtr NativeFieldInfoPtr_BlendOutIfRunning_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseExitIfRunning_Override;
    private static readonly IntPtr NativeFieldInfoPtr_ExitIfRunning_Override;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateNew_Public_Static_AnimationNodeOverride_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_AnimationNodeOverride_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int CurrentVersion
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimationNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimationNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public override unsafe bool HasNodeAnyOverride()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimationNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093841, XrefRangeEnd = 1093847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AnimationNodeOverride CreateNew(string nodeGuid)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimationNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_AnimationNodeOverride_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (AnimationNodeOverride) null : new AnimationNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093847, XrefRangeEnd = 1093855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AnimationNodeOverride CreateDefault()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimationNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_AnimationNodeOverride_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (AnimationNodeOverride) null : new AnimationNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093855, XrefRangeEnd = 1093876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetDeterministicHash(UnityEngine.Object sourceAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceAsset);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimationNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnimationNodeOverride()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnimationNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AnimationNodeOverride()
    {
      Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AnimationNodeOverride));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr);
      AnimationNodeOverride.NativeFieldInfoPtr_AnimationCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (AnimationCollection));
      AnimationNodeOverride.NativeFieldInfoPtr_AnimationCollectionGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (AnimationCollectionGuid));
      AnimationNodeOverride.NativeFieldInfoPtr_AnimationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (AnimationName));
      AnimationNodeOverride.NativeFieldInfoPtr_UseChestAimIk_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (UseChestAimIk_Override));
      AnimationNodeOverride.NativeFieldInfoPtr_ChestAimIk_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (ChestAimIk_Override));
      AnimationNodeOverride.NativeFieldInfoPtr_UseFinishPlaying_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (UseFinishPlaying_Override));
      AnimationNodeOverride.NativeFieldInfoPtr_FinishPlaying_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (FinishPlaying_Override));
      AnimationNodeOverride.NativeFieldInfoPtr_UseAnimationType_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (UseAnimationType_Override));
      AnimationNodeOverride.NativeFieldInfoPtr_AnimationType_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (AnimationType_Override));
      AnimationNodeOverride.NativeFieldInfoPtr_UseBlendIn_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (UseBlendIn_Override));
      AnimationNodeOverride.NativeFieldInfoPtr_BlendIn_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (BlendIn_Override));
      AnimationNodeOverride.NativeFieldInfoPtr_UseBlendOut_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (UseBlendOut_Override));
      AnimationNodeOverride.NativeFieldInfoPtr_BlendOut_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (BlendOut_Override));
      AnimationNodeOverride.NativeFieldInfoPtr_UseBlendOutIfRunning_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (UseBlendOutIfRunning_Override));
      AnimationNodeOverride.NativeFieldInfoPtr_BlendOutIfRunning_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (BlendOutIfRunning_Override));
      AnimationNodeOverride.NativeFieldInfoPtr_UseExitIfRunning_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (UseExitIfRunning_Override));
      AnimationNodeOverride.NativeFieldInfoPtr_ExitIfRunning_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, nameof (ExitIfRunning_Override));
      AnimationNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, 100686620);
      AnimationNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, 100686621);
      AnimationNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, 100686622);
      AnimationNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_AnimationNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, 100686623);
      AnimationNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_AnimationNodeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, 100686624);
      AnimationNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, 100686625);
      AnimationNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationNodeOverride>.NativeClassPtr, 100686626);
    }

    public AnimationNodeOverride(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AnimationCollection AnimationCollection
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_AnimationCollection));
        return pointer == IntPtr.Zero ? (AnimationCollection) null : new AnimationCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_AnimationCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string AnimationCollectionGuid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_AnimationCollectionGuid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_AnimationCollectionGuid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string AnimationName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_AnimationName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_AnimationName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool UseChestAimIk_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseChestAimIk_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseChestAimIk_Override)) = value;
      }
    }

    public unsafe bool ChestAimIk_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_ChestAimIk_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_ChestAimIk_Override)) = value;
      }
    }

    public unsafe bool UseFinishPlaying_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseFinishPlaying_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseFinishPlaying_Override)) = value;
      }
    }

    public unsafe bool FinishPlaying_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_FinishPlaying_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_FinishPlaying_Override)) = value;
      }
    }

    public unsafe bool UseAnimationType_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseAnimationType_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseAnimationType_Override)) = value;
      }
    }

    public unsafe AnimationTypeEnum AnimationType_Override
    {
      get
      {
        return *(AnimationTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_AnimationType_Override));
      }
      [param: In] set
      {
        *(AnimationTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_AnimationType_Override)) = value;
      }
    }

    public unsafe bool UseBlendIn_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseBlendIn_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseBlendIn_Override)) = value;
      }
    }

    public unsafe float BlendIn_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_BlendIn_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_BlendIn_Override)) = value;
      }
    }

    public unsafe bool UseBlendOut_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseBlendOut_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseBlendOut_Override)) = value;
      }
    }

    public unsafe float BlendOut_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_BlendOut_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_BlendOut_Override)) = value;
      }
    }

    public unsafe bool UseBlendOutIfRunning_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseBlendOutIfRunning_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseBlendOutIfRunning_Override)) = value;
      }
    }

    public unsafe float BlendOutIfRunning_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_BlendOutIfRunning_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_BlendOutIfRunning_Override)) = value;
      }
    }

    public unsafe bool UseExitIfRunning_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseExitIfRunning_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_UseExitIfRunning_Override)) = value;
      }
    }

    public unsafe bool ExitIfRunning_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_ExitIfRunning_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationNodeOverride.NativeFieldInfoPtr_ExitIfRunning_Override)) = value;
      }
    }
  }
}
