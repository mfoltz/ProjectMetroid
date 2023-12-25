// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ParticleNodeOverride
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class ParticleNodeOverride : SequenceNodeOverride
  {
    private static readonly IntPtr NativeFieldInfoPtr_GUID;
    private static readonly IntPtr NativeFieldInfoPtr_ParticleSystem;
    private static readonly IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly IntPtr NativeFieldInfoPtr_UseScale_Override;
    private static readonly IntPtr NativeFieldInfoPtr_Scale_Override;
    private static readonly IntPtr NativeFieldInfoPtr_VisualEffectParameters;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateNew_Public_Static_ParticleNodeOverride_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_ParticleNodeOverride_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetVFXParametersAsSequenceEditorVisualEffects_Public_List_1_Sequence_Editor_VisualEffectParameter_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetVisualEffectData_Public_List_1_VisualEffectOverride_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int CurrentVersion
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ParticleNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093962, XrefRangeEnd = 1093969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void AddGameObjectReferences(List<GameObject> references)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) references);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ParticleNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093969, XrefRangeEnd = 1093975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ParticleNodeOverride CreateNew(string nodeGuid)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_ParticleNodeOverride_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ParticleNodeOverride) null : new ParticleNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093975, XrefRangeEnd = 1093983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ParticleNodeOverride CreateDefault()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_ParticleNodeOverride_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ParticleNodeOverride) null : new ParticleNodeOverride(pointer);
    }

    [CallerCount(0)]
    public override unsafe bool HasNodeAnyOverride()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ParticleNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093983, XrefRangeEnd = 1094002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<Sequence_Editor_VisualEffectParameter> GetVFXParametersAsSequenceEditorVisualEffects()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleNodeOverride.NativeMethodInfoPtr_GetVFXParametersAsSequenceEditorVisualEffects_Public_List_1_Sequence_Editor_VisualEffectParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (List<Sequence_Editor_VisualEffectParameter>) null : new List<Sequence_Editor_VisualEffectParameter>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1094022, RefRangeEnd = 1094023, XrefRangeStart = 1094002, XrefRangeEnd = 1094022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<VisualEffectOverride> GetVisualEffectData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleNodeOverride.NativeMethodInfoPtr_GetVisualEffectData_Public_List_1_VisualEffectOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (List<VisualEffectOverride>) null : new List<VisualEffectOverride>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094023, XrefRangeEnd = 1094039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetDeterministicHash(UnityEngine.Object sourceAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceAsset);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ParticleNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ParticleNodeOverride()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ParticleNodeOverride()
    {
      Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ParticleNodeOverride));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr);
      ParticleNodeOverride.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, nameof (GUID));
      ParticleNodeOverride.NativeFieldInfoPtr_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, nameof (ParticleSystem));
      ParticleNodeOverride.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, nameof (Prefab));
      ParticleNodeOverride.NativeFieldInfoPtr_UseScale_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, nameof (UseScale_Override));
      ParticleNodeOverride.NativeFieldInfoPtr_Scale_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, nameof (Scale_Override));
      ParticleNodeOverride.NativeFieldInfoPtr_VisualEffectParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, nameof (VisualEffectParameters));
      ParticleNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, 100686649);
      ParticleNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, 100686650);
      ParticleNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_ParticleNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, 100686651);
      ParticleNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_ParticleNodeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, 100686652);
      ParticleNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, 100686653);
      ParticleNodeOverride.NativeMethodInfoPtr_GetVFXParametersAsSequenceEditorVisualEffects_Public_List_1_Sequence_Editor_VisualEffectParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, 100686654);
      ParticleNodeOverride.NativeMethodInfoPtr_GetVisualEffectData_Public_List_1_VisualEffectOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, 100686655);
      ParticleNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, 100686656);
      ParticleNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleNodeOverride>.NativeClassPtr, 100686657);
    }

    public ParticleNodeOverride(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string GUID
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleNodeOverride.NativeFieldInfoPtr_GUID)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleNodeOverride.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ParticleSystem ParticleSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleNodeOverride.NativeFieldInfoPtr_ParticleSystem));
        return pointer == IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleNodeOverride.NativeFieldInfoPtr_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Prefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleNodeOverride.NativeFieldInfoPtr_Prefab));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleNodeOverride.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool UseScale_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleNodeOverride.NativeFieldInfoPtr_UseScale_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleNodeOverride.NativeFieldInfoPtr_UseScale_Override)) = value;
      }
    }

    public unsafe float3 Scale_Override
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleNodeOverride.NativeFieldInfoPtr_Scale_Override));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleNodeOverride.NativeFieldInfoPtr_Scale_Override)) = value;
      }
    }

    public unsafe List<VisualEffectOverride> VisualEffectParameters
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleNodeOverride.NativeFieldInfoPtr_VisualEffectParameters));
        return pointer == IntPtr.Zero ? (List<VisualEffectOverride>) null : new List<VisualEffectOverride>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleNodeOverride.NativeFieldInfoPtr_VisualEffectParameters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
