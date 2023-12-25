// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.FullscreenEffectNodeOverride
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
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class FullscreenEffectNodeOverride : SequenceNodeOverride
  {
    private static readonly IntPtr NativeFieldInfoPtr_GUID;
    private static readonly IntPtr NativeFieldInfoPtr_Profile;
    private static readonly IntPtr NativeFieldInfoPtr_UseFadeIn_Override;
    private static readonly IntPtr NativeFieldInfoPtr_FadeIn_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseFadeOut_Override;
    private static readonly IntPtr NativeFieldInfoPtr_FadeOut_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseWeight_Override;
    private static readonly IntPtr NativeFieldInfoPtr_Weight_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseImportance_Override;
    private static readonly IntPtr NativeFieldInfoPtr_Importance_Override;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateNew_Public_Static_FullscreenEffectNodeOverride_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_FullscreenEffectNodeOverride_0;
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullscreenEffectNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullscreenEffectNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093915, XrefRangeEnd = 1093921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe FullscreenEffectNodeOverride CreateNew(string nodeGuid)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FullscreenEffectNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_FullscreenEffectNodeOverride_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (FullscreenEffectNodeOverride) null : new FullscreenEffectNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093921, XrefRangeEnd = 1093929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe FullscreenEffectNodeOverride CreateDefault()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(FullscreenEffectNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_FullscreenEffectNodeOverride_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (FullscreenEffectNodeOverride) null : new FullscreenEffectNodeOverride(pointer);
    }

    [CallerCount(0)]
    public override unsafe bool HasNodeAnyOverride()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullscreenEffectNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093929, XrefRangeEnd = 1093937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetDeterministicHash(UnityEngine.Object sourceAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceAsset);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullscreenEffectNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FullscreenEffectNodeOverride()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FullscreenEffectNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FullscreenEffectNodeOverride()
    {
      Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (FullscreenEffectNodeOverride));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr);
      FullscreenEffectNodeOverride.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, nameof (GUID));
      FullscreenEffectNodeOverride.NativeFieldInfoPtr_Profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, nameof (Profile));
      FullscreenEffectNodeOverride.NativeFieldInfoPtr_UseFadeIn_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, nameof (UseFadeIn_Override));
      FullscreenEffectNodeOverride.NativeFieldInfoPtr_FadeIn_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, nameof (FadeIn_Override));
      FullscreenEffectNodeOverride.NativeFieldInfoPtr_UseFadeOut_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, nameof (UseFadeOut_Override));
      FullscreenEffectNodeOverride.NativeFieldInfoPtr_FadeOut_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, nameof (FadeOut_Override));
      FullscreenEffectNodeOverride.NativeFieldInfoPtr_UseWeight_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, nameof (UseWeight_Override));
      FullscreenEffectNodeOverride.NativeFieldInfoPtr_Weight_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, nameof (Weight_Override));
      FullscreenEffectNodeOverride.NativeFieldInfoPtr_UseImportance_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, nameof (UseImportance_Override));
      FullscreenEffectNodeOverride.NativeFieldInfoPtr_Importance_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, nameof (Importance_Override));
      FullscreenEffectNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, 100686634);
      FullscreenEffectNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, 100686635);
      FullscreenEffectNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_FullscreenEffectNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, 100686636);
      FullscreenEffectNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_FullscreenEffectNodeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, 100686637);
      FullscreenEffectNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, 100686638);
      FullscreenEffectNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, 100686639);
      FullscreenEffectNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenEffectNodeOverride>.NativeClassPtr, 100686640);
    }

    public FullscreenEffectNodeOverride(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string GUID
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_GUID)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe VolumeProfile Profile
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_Profile));
        return pointer == IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_Profile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool UseFadeIn_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_UseFadeIn_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_UseFadeIn_Override)) = value;
      }
    }

    public unsafe float FadeIn_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_FadeIn_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_FadeIn_Override)) = value;
      }
    }

    public unsafe bool UseFadeOut_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_UseFadeOut_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_UseFadeOut_Override)) = value;
      }
    }

    public unsafe float FadeOut_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_FadeOut_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_FadeOut_Override)) = value;
      }
    }

    public unsafe bool UseWeight_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_UseWeight_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_UseWeight_Override)) = value;
      }
    }

    public unsafe float Weight_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_Weight_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_Weight_Override)) = value;
      }
    }

    public unsafe bool UseImportance_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_UseImportance_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_UseImportance_Override)) = value;
      }
    }

    public unsafe int Importance_Override
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_Importance_Override));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenEffectNodeOverride.NativeFieldInfoPtr_Importance_Override)) = value;
      }
    }
  }
}
