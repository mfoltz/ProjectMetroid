// Decompiled with JetBrains decompiler
// Type: ProjectM.VoiceMapping
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Fmod;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class VoiceMapping : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Voices;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082188, XrefRangeEnd = 1082193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VoiceMapping()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceMapping>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VoiceMapping()
    {
      Il2CppClassPointerStore<VoiceMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VoiceMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceMapping>.NativeClassPtr);
      VoiceMapping.NativeFieldInfoPtr_Voices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceMapping>.NativeClassPtr, nameof (Voices));
      VoiceMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceMapping>.NativeClassPtr, 100685223);
    }

    public VoiceMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<VoiceMapping.Voice> Voices
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceMapping.NativeFieldInfoPtr_Voices));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<VoiceMapping.Voice>) null : new Il2CppReferenceArray<VoiceMapping.Voice>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VoiceMapping.NativeFieldInfoPtr_Voices), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class Voice : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_FmodEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_CueOnStop;
      private static readonly System.IntPtr NativeFieldInfoPtr_ForceStopOnDestroy;
      private static readonly System.IntPtr NativeFieldInfoPtr_DontStopIfRepeating;

      static Voice()
      {
        Il2CppClassPointerStore<VoiceMapping.Voice>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoiceMapping>.NativeClassPtr, nameof (Voice));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceMapping.Voice>.NativeClassPtr);
        VoiceMapping.Voice.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceMapping.Voice>.NativeClassPtr, nameof (Type));
        VoiceMapping.Voice.NativeFieldInfoPtr_FmodEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceMapping.Voice>.NativeClassPtr, nameof (FmodEvent));
        VoiceMapping.Voice.NativeFieldInfoPtr_CueOnStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceMapping.Voice>.NativeClassPtr, nameof (CueOnStop));
        VoiceMapping.Voice.NativeFieldInfoPtr_ForceStopOnDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceMapping.Voice>.NativeClassPtr, nameof (ForceStopOnDestroy));
        VoiceMapping.Voice.NativeFieldInfoPtr_DontStopIfRepeating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceMapping.Voice>.NativeClassPtr, nameof (DontStopIfRepeating));
      }

      public Voice(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Voice()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VoiceMapping.Voice>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VoiceMapping.Voice>.NativeClassPtr, data));
      }

      public unsafe VoiceOverType Type
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceMapping.Voice.NativeFieldInfoPtr_Type));
          return pointer == System.IntPtr.Zero ? (VoiceOverType) null : new VoiceOverType(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VoiceMapping.Voice.NativeFieldInfoPtr_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public FmodEvent FmodEvent
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceMapping.Voice.NativeFieldInfoPtr_FmodEvent);
          return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceMapping.Voice.NativeFieldInfoPtr_FmodEvent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool CueOnStop
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceMapping.Voice.NativeFieldInfoPtr_CueOnStop));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceMapping.Voice.NativeFieldInfoPtr_CueOnStop)) = value;
        }
      }

      public unsafe bool ForceStopOnDestroy
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceMapping.Voice.NativeFieldInfoPtr_ForceStopOnDestroy));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceMapping.Voice.NativeFieldInfoPtr_ForceStopOnDestroy)) = value;
        }
      }

      public unsafe bool DontStopIfRepeating
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceMapping.Voice.NativeFieldInfoPtr_DontStopIfRepeating));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceMapping.Voice.NativeFieldInfoPtr_DontStopIfRepeating)) = value;
        }
      }
    }
  }
}
