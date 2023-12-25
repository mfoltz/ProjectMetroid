// Decompiled with JetBrains decompiler
// Type: ProjectM.VideoRecordingSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using FMOD;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Diagnostics;
using ProjectM.Audio;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class VideoRecordingSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__FramesToEncode;
    private static readonly System.IntPtr NativeFieldInfoPtr__EncodedFrames;
    private static readonly System.IntPtr NativeFieldInfoPtr__EncodingTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr__DefaultOutputMode;
    private static readonly System.IntPtr NativeFieldInfoPtr__StudioManagerSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalResolution;
    private static readonly System.IntPtr NativeFieldInfoPtr_EncodingFinished;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEncodingVideo_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartVideoEncoding_Public_Void_EncodingSettings_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StopVideoEncoding_Public_Boolean_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioSetup_Private_Boolean_byref_UInt32_byref_Int32_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleFrameRecorded_Private_Void_Texture2D_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SampleAudio_Private_Boolean_Il2CppStructArray_1_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnCreate_b__9_0_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe bool IsEncodingVideo
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1078067, RefRangeEnd = 1078069, XrefRangeStart = 1078059, XrefRangeEnd = 1078067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingSystem.NativeMethodInfoPtr_get_IsEncodingVideo_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078069, XrefRangeEnd = 1078086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VideoRecordingSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078086, XrefRangeEnd = 1078143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VideoRecordingSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078143, XrefRangeEnd = 1078213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartVideoEncoding(
      VideoRecordingUtility.EncodingSettings settings,
      float videoLength = 0.0f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) settings));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &videoLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VideoRecordingSystem.NativeMethodInfoPtr_StartVideoEncoding_Public_Void_EncodingSettings_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1078255, RefRangeEnd = 1078258, XrefRangeStart = 1078213, XrefRangeEnd = 1078255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool StopVideoEncoding(bool successfull, bool aborted)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &successfull;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aborted;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingSystem.NativeMethodInfoPtr_StopVideoEncoding_Public_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1078289, RefRangeEnd = 1078290, XrefRangeStart = 1078258, XrefRangeEnd = 1078289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetAudioSetup(out uint channels, out int sampleRate, out uint dspBufferSize)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref channels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref sampleRate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref dspBufferSize;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingSystem.NativeMethodInfoPtr_GetAudioSetup_Private_Boolean_byref_UInt32_byref_Int32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078290, XrefRangeEnd = 1078308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleFrameRecorded(Texture2D texture)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VideoRecordingSystem.NativeMethodInfoPtr_HandleFrameRecorded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078308, XrefRangeEnd = 1078312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SampleAudio(Il2CppStructArray<float> buffer, int channels)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &channels;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingSystem.NativeMethodInfoPtr_SampleAudio_Private_Boolean_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VideoRecordingSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VideoRecordingSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078312, XrefRangeEnd = 1078314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnCreate_b__9_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VideoRecordingSystem.NativeMethodInfoPtr__OnCreate_b__9_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VideoRecordingSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VideoRecordingSystem()
    {
      Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VideoRecordingSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr);
      VideoRecordingSystem.NativeFieldInfoPtr__FramesToEncode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, nameof (_FramesToEncode));
      VideoRecordingSystem.NativeFieldInfoPtr__EncodedFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, nameof (_EncodedFrames));
      VideoRecordingSystem.NativeFieldInfoPtr__EncodingTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, nameof (_EncodingTimer));
      VideoRecordingSystem.NativeFieldInfoPtr__DefaultOutputMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, nameof (_DefaultOutputMode));
      VideoRecordingSystem.NativeFieldInfoPtr__StudioManagerSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, nameof (_StudioManagerSystem));
      VideoRecordingSystem.NativeFieldInfoPtr__OriginalResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, nameof (_OriginalResolution));
      VideoRecordingSystem.NativeFieldInfoPtr_EncodingFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, nameof (EncodingFinished));
      VideoRecordingSystem.NativeMethodInfoPtr_get_IsEncodingVideo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, 100684912);
      VideoRecordingSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, 100684913);
      VideoRecordingSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, 100684914);
      VideoRecordingSystem.NativeMethodInfoPtr_StartVideoEncoding_Public_Void_EncodingSettings_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, 100684915);
      VideoRecordingSystem.NativeMethodInfoPtr_StopVideoEncoding_Public_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, 100684916);
      VideoRecordingSystem.NativeMethodInfoPtr_GetAudioSetup_Private_Boolean_byref_UInt32_byref_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, 100684917);
      VideoRecordingSystem.NativeMethodInfoPtr_HandleFrameRecorded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, 100684918);
      VideoRecordingSystem.NativeMethodInfoPtr_SampleAudio_Private_Boolean_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, 100684919);
      VideoRecordingSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, 100684920);
      VideoRecordingSystem.NativeMethodInfoPtr__OnCreate_b__9_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, 100684921);
      VideoRecordingSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, 100684922);
    }

    public VideoRecordingSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int _FramesToEncode
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr__FramesToEncode));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr__FramesToEncode)) = value;
      }
    }

    public unsafe int _EncodedFrames
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr__EncodedFrames));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr__EncodedFrames)) = value;
      }
    }

    public unsafe Stopwatch _EncodingTimer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr__EncodingTimer));
        return pointer == System.IntPtr.Zero ? (Stopwatch) null : new Stopwatch(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr__EncodingTimer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe OUTPUTTYPE _DefaultOutputMode
    {
      get
      {
        return *(OUTPUTTYPE*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr__DefaultOutputMode));
      }
      [param: In] set
      {
        *(OUTPUTTYPE*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr__DefaultOutputMode)) = value;
      }
    }

    public unsafe StudioManagerSystem _StudioManagerSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr__StudioManagerSystem));
        return pointer == System.IntPtr.Zero ? (StudioManagerSystem) null : new StudioManagerSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr__StudioManagerSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int2 _OriginalResolution
    {
      get
      {
        return *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr__OriginalResolution));
      }
      [param: In] set
      {
        *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr__OriginalResolution)) = value;
      }
    }

    public unsafe EncodingFinishedFunc EncodingFinished
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr_EncodingFinished));
        return pointer == System.IntPtr.Zero ? (EncodingFinishedFunc) null : new EncodingFinishedFunc(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingSystem.NativeFieldInfoPtr_EncodingFinished), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.VideoRecordingSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StartVideoEncoding_b__11_0_Internal_Boolean_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoRecordingSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VideoRecordingSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078051, XrefRangeEnd = 1078059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _StartVideoEncoding_b__11_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingSystem.__c.NativeMethodInfoPtr__StartVideoEncoding_b__11_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<VideoRecordingSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoRecordingSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoRecordingSystem.__c>.NativeClassPtr);
        VideoRecordingSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingSystem.__c>.NativeClassPtr, "<>9");
        VideoRecordingSystem.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingSystem.__c>.NativeClassPtr, "<>9__11_0");
        VideoRecordingSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingSystem.__c>.NativeClassPtr, 100684924);
        VideoRecordingSystem.__c.NativeMethodInfoPtr__StartVideoEncoding_b__11_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingSystem.__c>.NativeClassPtr, 100684925);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe VideoRecordingSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VideoRecordingSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (VideoRecordingSystem.__c) null : new VideoRecordingSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VideoRecordingSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<bool> __9__11_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VideoRecordingSystem.__c.NativeFieldInfoPtr___9__11_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<bool>) null : new Il2CppSystem.Func<bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VideoRecordingSystem.__c.NativeFieldInfoPtr___9__11_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
