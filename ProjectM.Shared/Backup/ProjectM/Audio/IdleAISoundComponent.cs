// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.IdleAISoundComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Fmod;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Audio
{
  public class IdleAISoundComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_audioPitchSemitonesToRatioScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_audioPitchRatioToSemitonesScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_IdleSounds;
    private static readonly System.IntPtr NativeMethodInfoPtr_AudioVolumeConvertRatioToDecibel_Public_Static_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AudioVolumeConvertDecibelToRatio_Public_Static_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AudioPitchSemitonesToRatio_Public_Static_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AudioPitchRatioToSemitones_Public_Static_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795795, XrefRangeEnd = 795796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float AudioVolumeConvertRatioToDecibel(float volumeRatio)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &volumeRatio;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundComponent.NativeMethodInfoPtr_AudioVolumeConvertRatioToDecibel_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795796, XrefRangeEnd = 795797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float AudioVolumeConvertDecibelToRatio(float volumeDecibel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &volumeDecibel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundComponent.NativeMethodInfoPtr_AudioVolumeConvertDecibelToRatio_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795802, RefRangeEnd = 795803, XrefRangeStart = 795797, XrefRangeEnd = 795802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float AudioPitchSemitonesToRatio(float pitchSemitones)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pitchSemitones;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundComponent.NativeMethodInfoPtr_AudioPitchSemitonesToRatio_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795803, XrefRangeEnd = 795808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float AudioPitchRatioToSemitones(float pitchRatio)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pitchRatio;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundComponent.NativeMethodInfoPtr_AudioPitchRatioToSemitones_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795808, XrefRangeEnd = 795836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IdleAISoundComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795836, XrefRangeEnd = 795844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IdleAISoundComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdleAISoundComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IdleAISoundComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IdleAISoundComponent()
    {
      Il2CppClassPointerStore<IdleAISoundComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Audio", nameof (IdleAISoundComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundComponent>.NativeClassPtr);
      IdleAISoundComponent.NativeFieldInfoPtr_audioPitchSemitonesToRatioScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundComponent>.NativeClassPtr, nameof (audioPitchSemitonesToRatioScale));
      IdleAISoundComponent.NativeFieldInfoPtr_audioPitchRatioToSemitonesScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundComponent>.NativeClassPtr, nameof (audioPitchRatioToSemitonesScale));
      IdleAISoundComponent.NativeFieldInfoPtr_IdleSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundComponent>.NativeClassPtr, nameof (IdleSounds));
      IdleAISoundComponent.NativeMethodInfoPtr_AudioVolumeConvertRatioToDecibel_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundComponent>.NativeClassPtr, 100670231);
      IdleAISoundComponent.NativeMethodInfoPtr_AudioVolumeConvertDecibelToRatio_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundComponent>.NativeClassPtr, 100670232);
      IdleAISoundComponent.NativeMethodInfoPtr_AudioPitchSemitonesToRatio_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundComponent>.NativeClassPtr, 100670233);
      IdleAISoundComponent.NativeMethodInfoPtr_AudioPitchRatioToSemitones_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundComponent>.NativeClassPtr, 100670234);
      IdleAISoundComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundComponent>.NativeClassPtr, 100670235);
      IdleAISoundComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundComponent>.NativeClassPtr, 100670236);
    }

    public IdleAISoundComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float audioPitchSemitonesToRatioScale
    {
      get
      {
        float semitonesToRatioScale;
        IL2CPP.il2cpp_field_static_get_value(IdleAISoundComponent.NativeFieldInfoPtr_audioPitchSemitonesToRatioScale, (void*) &semitonesToRatioScale);
        return semitonesToRatioScale;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(IdleAISoundComponent.NativeFieldInfoPtr_audioPitchSemitonesToRatioScale, (void*) &value);
      }
    }

    public static unsafe float audioPitchRatioToSemitonesScale
    {
      get
      {
        float toSemitonesScale;
        IL2CPP.il2cpp_field_static_get_value(IdleAISoundComponent.NativeFieldInfoPtr_audioPitchRatioToSemitonesScale, (void*) &toSemitonesScale);
        return toSemitonesScale;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(IdleAISoundComponent.NativeFieldInfoPtr_audioPitchRatioToSemitonesScale, (void*) &value);
      }
    }

    public unsafe List<IdleAISoundComponent.IdleSound> IdleSounds
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.NativeFieldInfoPtr_IdleSounds));
        return pointer == System.IntPtr.Zero ? (List<IdleAISoundComponent.IdleSound>) null : new List<IdleAISoundComponent.IdleSound>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.NativeFieldInfoPtr_IdleSounds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class IdleSound : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Sound;
      private static readonly System.IntPtr NativeFieldInfoPtr_StopBehaviour;
      private static readonly System.IntPtr NativeFieldInfoPtr_StopModeEnum;
      private static readonly System.IntPtr NativeFieldInfoPtr_VolumeDecibel;
      private static readonly System.IntPtr NativeFieldInfoPtr_PitchSemitones;
      private static readonly System.IntPtr NativeFieldInfoPtr_SetMovementParameter;

      static IdleSound()
      {
        Il2CppClassPointerStore<IdleAISoundComponent.IdleSound>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundComponent>.NativeClassPtr, nameof (IdleSound));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundComponent.IdleSound>.NativeClassPtr);
        IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundComponent.IdleSound>.NativeClassPtr, nameof (Sound));
        IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_StopBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundComponent.IdleSound>.NativeClassPtr, nameof (StopBehaviour));
        IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_StopModeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundComponent.IdleSound>.NativeClassPtr, nameof (StopModeEnum));
        IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_VolumeDecibel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundComponent.IdleSound>.NativeClassPtr, nameof (VolumeDecibel));
        IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_PitchSemitones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundComponent.IdleSound>.NativeClassPtr, nameof (PitchSemitones));
        IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_SetMovementParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundComponent.IdleSound>.NativeClassPtr, nameof (SetMovementParameter));
      }

      public IdleSound(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public IdleSound()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IdleAISoundComponent.IdleSound>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundComponent.IdleSound>.NativeClassPtr, data));
      }

      public FmodEvent Sound
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_Sound);
          return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_Sound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe IdleSoundStopBehaviour StopBehaviour
      {
        get
        {
          return *(IdleSoundStopBehaviour*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_StopBehaviour));
        }
        [param: In] set
        {
          *(IdleSoundStopBehaviour*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_StopBehaviour)) = value;
        }
      }

      public unsafe IdleAIStudioEventStopModeEnum StopModeEnum
      {
        get
        {
          return *(IdleAIStudioEventStopModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_StopModeEnum));
        }
        [param: In] set
        {
          *(IdleAIStudioEventStopModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_StopModeEnum)) = value;
        }
      }

      public unsafe float VolumeDecibel
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_VolumeDecibel));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_VolumeDecibel)) = value;
        }
      }

      public unsafe float PitchSemitones
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_PitchSemitones));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_PitchSemitones)) = value;
        }
      }

      public unsafe bool SetMovementParameter
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_SetMovementParameter));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundComponent.IdleSound.NativeFieldInfoPtr_SetMovementParameter)) = value;
        }
      }
    }
  }
}
