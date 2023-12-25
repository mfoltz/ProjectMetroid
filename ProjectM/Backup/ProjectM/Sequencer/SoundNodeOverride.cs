// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SoundNodeOverride
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Fmod;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class SoundNodeOverride : SequenceNodeOverride
  {
    private static readonly IntPtr NativeFieldInfoPtr_Event;
    private static readonly IntPtr NativeFieldInfoPtr_UseVolume_Override;
    private static readonly IntPtr NativeFieldInfoPtr_Volume_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UsePitch_Override;
    private static readonly IntPtr NativeFieldInfoPtr_Pitch_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseCueOnStop_Override;
    private static readonly IntPtr NativeFieldInfoPtr_CueOnStop_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseForceStop_Override;
    private static readonly IntPtr NativeFieldInfoPtr_ForceStop_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseMinDistance_Override;
    private static readonly IntPtr NativeFieldInfoPtr_MinDistance_Override;
    private static readonly IntPtr NativeFieldInfoPtr_UseMaxDistance_Override;
    private static readonly IntPtr NativeFieldInfoPtr_MaxDistance_Override;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateNew_Public_Static_SoundNodeOverride_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_SoundNodeOverride_0;
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SoundNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SoundNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094061, XrefRangeEnd = 1094067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SoundNodeOverride CreateNew(string nodeGuid)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SoundNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_SoundNodeOverride_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (SoundNodeOverride) null : new SoundNodeOverride(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094067, XrefRangeEnd = 1094075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SoundNodeOverride CreateDefault()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SoundNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_SoundNodeOverride_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (SoundNodeOverride) null : new SoundNodeOverride(pointer);
    }

    [CallerCount(0)]
    public override unsafe bool HasNodeAnyOverride()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SoundNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094075, XrefRangeEnd = 1094094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetDeterministicHash(UnityEngine.Object sourceAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceAsset);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SoundNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SoundNodeOverride()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SoundNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SoundNodeOverride()
    {
      Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SoundNodeOverride));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr);
      SoundNodeOverride.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, nameof (Event));
      SoundNodeOverride.NativeFieldInfoPtr_UseVolume_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, nameof (UseVolume_Override));
      SoundNodeOverride.NativeFieldInfoPtr_Volume_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, nameof (Volume_Override));
      SoundNodeOverride.NativeFieldInfoPtr_UsePitch_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, nameof (UsePitch_Override));
      SoundNodeOverride.NativeFieldInfoPtr_Pitch_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, nameof (Pitch_Override));
      SoundNodeOverride.NativeFieldInfoPtr_UseCueOnStop_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, nameof (UseCueOnStop_Override));
      SoundNodeOverride.NativeFieldInfoPtr_CueOnStop_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, nameof (CueOnStop_Override));
      SoundNodeOverride.NativeFieldInfoPtr_UseForceStop_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, nameof (UseForceStop_Override));
      SoundNodeOverride.NativeFieldInfoPtr_ForceStop_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, nameof (ForceStop_Override));
      SoundNodeOverride.NativeFieldInfoPtr_UseMinDistance_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, nameof (UseMinDistance_Override));
      SoundNodeOverride.NativeFieldInfoPtr_MinDistance_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, nameof (MinDistance_Override));
      SoundNodeOverride.NativeFieldInfoPtr_UseMaxDistance_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, nameof (UseMaxDistance_Override));
      SoundNodeOverride.NativeFieldInfoPtr_MaxDistance_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, nameof (MaxDistance_Override));
      SoundNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, 100686665);
      SoundNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, 100686666);
      SoundNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_SoundNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, 100686667);
      SoundNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_SoundNodeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, 100686668);
      SoundNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, 100686669);
      SoundNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, 100686670);
      SoundNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundNodeOverride>.NativeClassPtr, 100686671);
    }

    public SoundNodeOverride(IntPtr pointer)
      : base(pointer)
    {
    }

    public FmodEvent Event
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_Event);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_Event), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe bool UseVolume_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_UseVolume_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_UseVolume_Override)) = value;
      }
    }

    public unsafe float Volume_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_Volume_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_Volume_Override)) = value;
      }
    }

    public unsafe bool UsePitch_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_UsePitch_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_UsePitch_Override)) = value;
      }
    }

    public unsafe float Pitch_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_Pitch_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_Pitch_Override)) = value;
      }
    }

    public unsafe bool UseCueOnStop_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_UseCueOnStop_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_UseCueOnStop_Override)) = value;
      }
    }

    public unsafe bool CueOnStop_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_CueOnStop_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_CueOnStop_Override)) = value;
      }
    }

    public unsafe bool UseForceStop_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_UseForceStop_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_UseForceStop_Override)) = value;
      }
    }

    public unsafe bool ForceStop_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_ForceStop_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_ForceStop_Override)) = value;
      }
    }

    public unsafe bool UseMinDistance_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_UseMinDistance_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_UseMinDistance_Override)) = value;
      }
    }

    public unsafe float MinDistance_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_MinDistance_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_MinDistance_Override)) = value;
      }
    }

    public unsafe bool UseMaxDistance_Override
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_UseMaxDistance_Override));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_UseMaxDistance_Override)) = value;
      }
    }

    public unsafe float MaxDistance_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_MaxDistance_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundNodeOverride.NativeFieldInfoPtr_MaxDistance_Override)) = value;
      }
    }
  }
}
