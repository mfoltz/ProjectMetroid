// Decompiled with JetBrains decompiler
// Type: ProjectM.VideoRecordingUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class VideoRecordingUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_KB;
    private static readonly System.IntPtr NativeFieldInfoPtr_MB;
    private static readonly System.IntPtr NativeFieldInfoPtr_Video_Uncompressed_Bitrate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Video_Very_High_Bitrate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Video_High_Bitrate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Video_Medium_Bitrate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Video_Low_Bitrate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Audio_High_Bitrate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Audio_Medium_Bitrate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Audio_Low_Bitrate;
    private static readonly System.IntPtr NativeFieldInfoPtr__Recording;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnlyVideo;
    private static readonly System.IntPtr NativeFieldInfoPtr__NextEncodeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__Framerate;
    private static readonly System.IntPtr NativeFieldInfoPtr__TheadSafeStop;
    private static readonly System.IntPtr NativeFieldInfoPtr__WaitingForFrameEncode;
    private static readonly System.IntPtr NativeFieldInfoPtr__EncodeVideoNext;
    private static readonly System.IntPtr NativeFieldInfoPtr__AudioChannels;
    private static readonly System.IntPtr NativeFieldInfoPtr__AudioBufferSize;
    private static readonly System.IntPtr NativeFieldInfoPtr__AudioSamplesRate;
    private static readonly System.IntPtr NativeFieldInfoPtr__Realtime;
    private static readonly System.IntPtr NativeFieldInfoPtr__Thread;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorkerFailed;
    private static readonly System.IntPtr NativeFieldInfoPtr__VideoSyncHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__AudioSyncHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__FrameBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr__AudioBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdateSound;
    private static readonly System.IntPtr NativeMethodInfoPtr_initialize_audio_video_encoding_Private_Static_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_Boolean_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_initialize_video_only_encoding_Private_Static_Int32_Int32_Int32_Int32_Int32_Boolean_Boolean_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_initialize_audio_only_encoding_Private_Static_Int32_Int32_Int32_Int32_Boolean_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_initialize_audio_video_encoding_pre_post_media_Private_Static_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_Boolean_IntPtr_IntPtr_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_expecting_video_next_Private_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_write_video_frame_Private_Static_Int32_IntPtr_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_write_audio_frame_Private_Static_Int32_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_finish_video_and_audio_encoding_Private_Static_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_finish_video_encoding_Private_Static_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_finish_audio_encoding_Private_Static_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_cleanup_Private_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get__FrameTime_Private_Static_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRecording_Public_Static_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EncodeVideoNext_Public_Static_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AudioBufferSize_Public_Static_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeEncoding_Public_Static_Boolean_EncodingSettings_AudioSetup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetExtension_Public_Static_String_EncodingSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeAudioVideoEncoding_Public_Static_Boolean_Int32_Int32_Int32_Int32_Int32_String_Boolean_Boolean_UInt32_Int32_UInt32_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeVideoOnlyEncoding_Public_Static_Boolean_Int32_Int32_Int32_Int32_String_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EncodeTexture_Public_Static_Boolean_Texture2D_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EncodeAudio_Public_Static_Boolean_Il2CppStructArray_1_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueNonPlanarAudio_Private_Static_Void_Il2CppStructArray_1_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QuePlanarAudio_Private_Static_Void_Il2CppStructArray_1_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EncodeWorker_Private_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteAudioVideoToEncoder_Private_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnhcodeNonPlanarAudio_Private_Static_Int32_AudioData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnhcodeNonPlanarAudio_Private_Static_Int32_Il2CppStructArray_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnhcodePlanarAudio_Private_Static_Int32_AudioData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteVideoToEncoder_Private_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TheadSafeEncodingStop_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FinishEncoding_Public_Static_Boolean_Action_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FinishVideoEncoding_Public_Static_Boolean_Action_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FinishAudioVideoEncoding_Public_Static_Boolean_Action_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleError_Public_Static_Void_Int32_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078490, XrefRangeEnd = 1078492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int initialize_audio_video_encoding(
      int width,
      int height,
      int frame_rate,
      int video_bitrate,
      int sample_rate,
      int per_frame_audio_samples,
      int audio_bitrate,
      bool uncompressed,
      bool fast_compression,
      System.IntPtr filename)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &width;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &frame_rate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &video_bitrate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &sample_rate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &per_frame_audio_samples;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &audio_bitrate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &uncompressed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &fast_compression;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &filename;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_initialize_audio_video_encoding_Private_Static_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078492, XrefRangeEnd = 1078494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int initialize_video_only_encoding(
      int width,
      int height,
      int frame_rate,
      int video_bitrate,
      bool uncompressed,
      bool fast_compression,
      System.IntPtr filename)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &width;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &frame_rate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &video_bitrate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &uncompressed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &fast_compression;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &filename;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_initialize_video_only_encoding_Private_Static_Int32_Int32_Int32_Int32_Int32_Boolean_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078494, XrefRangeEnd = 1078496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int initialize_audio_only_encoding(
      int sample_rate,
      int per_frame_audio_samples,
      int audio_bitrate,
      bool uncompressed,
      System.IntPtr filename)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &sample_rate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &per_frame_audio_samples;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &audio_bitrate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &uncompressed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &filename;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_initialize_audio_only_encoding_Private_Static_Int32_Int32_Int32_Int32_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078496, XrefRangeEnd = 1078498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int initialize_audio_video_encoding_pre_post_media(
      int width,
      int height,
      int frame_rate,
      int video_bitrate,
      int sample_rate,
      int per_frame_audio_samples,
      int audio_bitrate,
      bool uncompressed,
      bool fast_compression,
      System.IntPtr filename,
      System.IntPtr post_media_filename,
      System.IntPtr pre_media_filename)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[12];
      numPtr[0] = (System.IntPtr) &width;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &frame_rate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &video_bitrate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &sample_rate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &per_frame_audio_samples;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &audio_bitrate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &uncompressed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &fast_compression;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &filename;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &post_media_filename;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &pre_media_filename;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_initialize_audio_video_encoding_pre_post_media_Private_Static_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_Boolean_IntPtr_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1078500, RefRangeEnd = 1078502, XrefRangeStart = 1078498, XrefRangeEnd = 1078500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool expecting_video_next()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_expecting_video_next_Private_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1078504, RefRangeEnd = 1078505, XrefRangeStart = 1078502, XrefRangeEnd = 1078504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int write_video_frame(System.IntPtr rgb24Data, int skipped_frames)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rgb24Data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &skipped_frames;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_write_video_frame_Private_Static_Int32_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078505, XrefRangeEnd = 1078507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int write_audio_frame(System.IntPtr aud_samples)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &aud_samples;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_write_audio_frame_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078507, XrefRangeEnd = 1078509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int finish_video_and_audio_encoding()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_finish_video_and_audio_encoding_Private_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078509, XrefRangeEnd = 1078511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int finish_video_encoding()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_finish_video_encoding_Private_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078511, XrefRangeEnd = 1078513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int finish_audio_encoding()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_finish_audio_encoding_Private_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1078515, RefRangeEnd = 1078518, XrefRangeStart = 1078513, XrefRangeEnd = 1078515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void cleanup()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_cleanup_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public static unsafe float _FrameTime
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078518, XrefRangeEnd = 1078522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_get__FrameTime_Private_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public static unsafe bool IsRecording
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078522, XrefRangeEnd = 1078526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_get_IsRecording_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public static unsafe bool EncodeVideoNext
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078526, XrefRangeEnd = 1078530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_get_EncodeVideoNext_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public static unsafe uint AudioBufferSize
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078530, XrefRangeEnd = 1078534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_get_AudioBufferSize_Public_Static_get_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078534, XrefRangeEnd = 1078538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool InitializeEncoding(
      VideoRecordingUtility.EncodingSettings settings,
      VideoRecordingUtility.AudioSetup audioSetup)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) settings));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &audioSetup;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_InitializeEncoding_Public_Static_Boolean_EncodingSettings_AudioSetup_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078538, XrefRangeEnd = 1078542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetExtension(
      VideoRecordingUtility.EncodingSettings encodingSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) encodingSettings));
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_GetExtension_Public_Static_String_EncodingSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1078688, RefRangeEnd = 1078689, XrefRangeStart = 1078542, XrefRangeEnd = 1078688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool InitializeAudioVideoEncoding(
      int width,
      int height,
      int frameRate,
      int videoBitrate,
      int audioBitrate,
      string filename,
      bool uncompressed,
      bool fast_compression,
      uint channels,
      int sampleRate,
      uint sampleBufferSize,
      string preMediaFilname = null,
      string postMediaFilename = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[13];
      numPtr[0] = (System.IntPtr) &width;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &frameRate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &videoBitrate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &audioBitrate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(filename);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &uncompressed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &fast_compression;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &channels;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &sampleRate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &sampleBufferSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(preMediaFilname);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(postMediaFilename);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_InitializeAudioVideoEncoding_Public_Static_Boolean_Int32_Int32_Int32_Int32_Int32_String_Boolean_Boolean_UInt32_Int32_UInt32_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1078775, RefRangeEnd = 1078777, XrefRangeStart = 1078689, XrefRangeEnd = 1078775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool InitializeVideoOnlyEncoding(
      int width,
      int height,
      int frameRate,
      int videoBitrate,
      string filename,
      bool uncompressed,
      bool fast_compression)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &width;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &frameRate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &videoBitrate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(filename);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &uncompressed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &fast_compression;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_InitializeVideoOnlyEncoding_Public_Static_Boolean_Int32_Int32_Int32_Int32_String_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1078827, RefRangeEnd = 1078828, XrefRangeStart = 1078777, XrefRangeEnd = 1078827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool EncodeTexture(Texture2D tex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tex);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_EncodeTexture_Public_Static_Boolean_Texture2D_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1078854, RefRangeEnd = 1078855, XrefRangeStart = 1078828, XrefRangeEnd = 1078854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool EncodeAudio(Il2CppStructArray<float> audioData, int channels)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) audioData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &channels;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_EncodeAudio_Public_Static_Boolean_Il2CppStructArray_1_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1078863, RefRangeEnd = 1078864, XrefRangeStart = 1078855, XrefRangeEnd = 1078863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void QueNonPlanarAudio(Il2CppStructArray<float> audioData, int channels)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) audioData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &channels;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_QueNonPlanarAudio_Private_Static_Void_Il2CppStructArray_1_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078864, XrefRangeEnd = 1078888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void QuePlanarAudio(Il2CppStructArray<float> audioData, int channels)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) audioData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &channels;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_QuePlanarAudio_Private_Static_Void_Il2CppStructArray_1_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078888, XrefRangeEnd = 1078904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void EncodeWorker()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_EncodeWorker_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1078922, RefRangeEnd = 1078923, XrefRangeStart = 1078904, XrefRangeEnd = 1078922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool WriteAudioVideoToEncoder()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_WriteAudioVideoToEncoder_Private_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078923, XrefRangeEnd = 1078939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int EnhcodeNonPlanarAudio(VideoRecordingUtility.AudioData audioData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) audioData));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_EnhcodeNonPlanarAudio_Private_Static_Int32_AudioData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078939, XrefRangeEnd = 1078952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int EnhcodeNonPlanarAudio(Il2CppStructArray<float> audioData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) audioData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_EnhcodeNonPlanarAudio_Private_Static_Int32_Il2CppStructArray_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int EnhcodePlanarAudio(VideoRecordingUtility.AudioData audioData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) audioData));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_EnhcodePlanarAudio_Private_Static_Int32_AudioData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1078983, RefRangeEnd = 1078984, XrefRangeStart = 1078952, XrefRangeEnd = 1078983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool WriteVideoToEncoder()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_WriteVideoToEncoder_Private_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078984, XrefRangeEnd = 1078988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TheadSafeEncodingStop()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_TheadSafeEncodingStop_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1078996, RefRangeEnd = 1078997, XrefRangeStart = 1078988, XrefRangeEnd = 1078996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool FinishEncoding(Il2CppSystem.Action<float> onProgress)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onProgress);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_FinishEncoding_Public_Static_Boolean_Action_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1079023, RefRangeEnd = 1079024, XrefRangeStart = 1078997, XrefRangeEnd = 1079023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool FinishVideoEncoding(Il2CppSystem.Action<float> onProgress)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onProgress);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_FinishVideoEncoding_Public_Static_Boolean_Action_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1079052, RefRangeEnd = 1079053, XrefRangeStart = 1079024, XrefRangeEnd = 1079052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool FinishAudioVideoEncoding(Il2CppSystem.Action<float> onProgress)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onProgress);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_FinishAudioVideoEncoding_Public_Static_Boolean_Action_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079053, XrefRangeEnd = 1079064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Cleanup()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_Cleanup_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079064, XrefRangeEnd = 1079114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void HandleError(int code)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &code;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.NativeMethodInfoPtr_HandleError_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VideoRecordingUtility()
    {
      Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VideoRecordingUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr);
      VideoRecordingUtility.NativeFieldInfoPtr_KB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (KB));
      VideoRecordingUtility.NativeFieldInfoPtr_MB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (MB));
      VideoRecordingUtility.NativeFieldInfoPtr_Video_Uncompressed_Bitrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (Video_Uncompressed_Bitrate));
      VideoRecordingUtility.NativeFieldInfoPtr_Video_Very_High_Bitrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (Video_Very_High_Bitrate));
      VideoRecordingUtility.NativeFieldInfoPtr_Video_High_Bitrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (Video_High_Bitrate));
      VideoRecordingUtility.NativeFieldInfoPtr_Video_Medium_Bitrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (Video_Medium_Bitrate));
      VideoRecordingUtility.NativeFieldInfoPtr_Video_Low_Bitrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (Video_Low_Bitrate));
      VideoRecordingUtility.NativeFieldInfoPtr_Audio_High_Bitrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (Audio_High_Bitrate));
      VideoRecordingUtility.NativeFieldInfoPtr_Audio_Medium_Bitrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (Audio_Medium_Bitrate));
      VideoRecordingUtility.NativeFieldInfoPtr_Audio_Low_Bitrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (Audio_Low_Bitrate));
      VideoRecordingUtility.NativeFieldInfoPtr__Recording = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_Recording));
      VideoRecordingUtility.NativeFieldInfoPtr__OnlyVideo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_OnlyVideo));
      VideoRecordingUtility.NativeFieldInfoPtr__NextEncodeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_NextEncodeTime));
      VideoRecordingUtility.NativeFieldInfoPtr__Framerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_Framerate));
      VideoRecordingUtility.NativeFieldInfoPtr__TheadSafeStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_TheadSafeStop));
      VideoRecordingUtility.NativeFieldInfoPtr__WaitingForFrameEncode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_WaitingForFrameEncode));
      VideoRecordingUtility.NativeFieldInfoPtr__EncodeVideoNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_EncodeVideoNext));
      VideoRecordingUtility.NativeFieldInfoPtr__AudioChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_AudioChannels));
      VideoRecordingUtility.NativeFieldInfoPtr__AudioBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_AudioBufferSize));
      VideoRecordingUtility.NativeFieldInfoPtr__AudioSamplesRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_AudioSamplesRate));
      VideoRecordingUtility.NativeFieldInfoPtr__Realtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_Realtime));
      VideoRecordingUtility.NativeFieldInfoPtr__Thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_Thread));
      VideoRecordingUtility.NativeFieldInfoPtr__WorkerFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_WorkerFailed));
      VideoRecordingUtility.NativeFieldInfoPtr__VideoSyncHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_VideoSyncHandle));
      VideoRecordingUtility.NativeFieldInfoPtr__AudioSyncHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_AudioSyncHandle));
      VideoRecordingUtility.NativeFieldInfoPtr__FrameBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_FrameBuffer));
      VideoRecordingUtility.NativeFieldInfoPtr__AudioBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (_AudioBuffer));
      VideoRecordingUtility.NativeFieldInfoPtr_UpdateSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (UpdateSound));
      VideoRecordingUtility.NativeMethodInfoPtr_initialize_audio_video_encoding_Private_Static_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684926);
      VideoRecordingUtility.NativeMethodInfoPtr_initialize_video_only_encoding_Private_Static_Int32_Int32_Int32_Int32_Int32_Boolean_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684927);
      VideoRecordingUtility.NativeMethodInfoPtr_initialize_audio_only_encoding_Private_Static_Int32_Int32_Int32_Int32_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684928);
      VideoRecordingUtility.NativeMethodInfoPtr_initialize_audio_video_encoding_pre_post_media_Private_Static_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_Boolean_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684929);
      VideoRecordingUtility.NativeMethodInfoPtr_expecting_video_next_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684930);
      VideoRecordingUtility.NativeMethodInfoPtr_write_video_frame_Private_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684931);
      VideoRecordingUtility.NativeMethodInfoPtr_write_audio_frame_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684932);
      VideoRecordingUtility.NativeMethodInfoPtr_finish_video_and_audio_encoding_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684933);
      VideoRecordingUtility.NativeMethodInfoPtr_finish_video_encoding_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684934);
      VideoRecordingUtility.NativeMethodInfoPtr_finish_audio_encoding_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684935);
      VideoRecordingUtility.NativeMethodInfoPtr_cleanup_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684936);
      VideoRecordingUtility.NativeMethodInfoPtr_get__FrameTime_Private_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684937);
      VideoRecordingUtility.NativeMethodInfoPtr_get_IsRecording_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684938);
      VideoRecordingUtility.NativeMethodInfoPtr_get_EncodeVideoNext_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684939);
      VideoRecordingUtility.NativeMethodInfoPtr_get_AudioBufferSize_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684940);
      VideoRecordingUtility.NativeMethodInfoPtr_InitializeEncoding_Public_Static_Boolean_EncodingSettings_AudioSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684941);
      VideoRecordingUtility.NativeMethodInfoPtr_GetExtension_Public_Static_String_EncodingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684942);
      VideoRecordingUtility.NativeMethodInfoPtr_InitializeAudioVideoEncoding_Public_Static_Boolean_Int32_Int32_Int32_Int32_Int32_String_Boolean_Boolean_UInt32_Int32_UInt32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684943);
      VideoRecordingUtility.NativeMethodInfoPtr_InitializeVideoOnlyEncoding_Public_Static_Boolean_Int32_Int32_Int32_Int32_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684944);
      VideoRecordingUtility.NativeMethodInfoPtr_EncodeTexture_Public_Static_Boolean_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684945);
      VideoRecordingUtility.NativeMethodInfoPtr_EncodeAudio_Public_Static_Boolean_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684946);
      VideoRecordingUtility.NativeMethodInfoPtr_QueNonPlanarAudio_Private_Static_Void_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684947);
      VideoRecordingUtility.NativeMethodInfoPtr_QuePlanarAudio_Private_Static_Void_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684948);
      VideoRecordingUtility.NativeMethodInfoPtr_EncodeWorker_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684949);
      VideoRecordingUtility.NativeMethodInfoPtr_WriteAudioVideoToEncoder_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684950);
      VideoRecordingUtility.NativeMethodInfoPtr_EnhcodeNonPlanarAudio_Private_Static_Int32_AudioData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684951);
      VideoRecordingUtility.NativeMethodInfoPtr_EnhcodeNonPlanarAudio_Private_Static_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684952);
      VideoRecordingUtility.NativeMethodInfoPtr_EnhcodePlanarAudio_Private_Static_Int32_AudioData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684953);
      VideoRecordingUtility.NativeMethodInfoPtr_WriteVideoToEncoder_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684954);
      VideoRecordingUtility.NativeMethodInfoPtr_TheadSafeEncodingStop_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684955);
      VideoRecordingUtility.NativeMethodInfoPtr_FinishEncoding_Public_Static_Boolean_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684956);
      VideoRecordingUtility.NativeMethodInfoPtr_FinishVideoEncoding_Public_Static_Boolean_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684957);
      VideoRecordingUtility.NativeMethodInfoPtr_FinishAudioVideoEncoding_Public_Static_Boolean_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684958);
      VideoRecordingUtility.NativeMethodInfoPtr_Cleanup_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684959);
      VideoRecordingUtility.NativeMethodInfoPtr_HandleError_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, 100684960);
    }

    public VideoRecordingUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int KB
    {
      get
      {
        int kb;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr_KB, (void*) &kb);
        return kb;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr_KB, (void*) &value);
      }
    }

    public static unsafe int MB
    {
      get
      {
        int mb;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr_MB, (void*) &mb);
        return mb;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr_MB, (void*) &value);
      }
    }

    public static unsafe int Video_Uncompressed_Bitrate
    {
      get
      {
        int uncompressedBitrate;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr_Video_Uncompressed_Bitrate, (void*) &uncompressedBitrate);
        return uncompressedBitrate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr_Video_Uncompressed_Bitrate, (void*) &value);
      }
    }

    public static unsafe int Video_Very_High_Bitrate
    {
      get
      {
        int videoVeryHighBitrate;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr_Video_Very_High_Bitrate, (void*) &videoVeryHighBitrate);
        return videoVeryHighBitrate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr_Video_Very_High_Bitrate, (void*) &value);
      }
    }

    public static unsafe int Video_High_Bitrate
    {
      get
      {
        int videoHighBitrate;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr_Video_High_Bitrate, (void*) &videoHighBitrate);
        return videoHighBitrate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr_Video_High_Bitrate, (void*) &value);
      }
    }

    public static unsafe int Video_Medium_Bitrate
    {
      get
      {
        int videoMediumBitrate;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr_Video_Medium_Bitrate, (void*) &videoMediumBitrate);
        return videoMediumBitrate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr_Video_Medium_Bitrate, (void*) &value);
      }
    }

    public static unsafe int Video_Low_Bitrate
    {
      get
      {
        int videoLowBitrate;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr_Video_Low_Bitrate, (void*) &videoLowBitrate);
        return videoLowBitrate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr_Video_Low_Bitrate, (void*) &value);
      }
    }

    public static unsafe int Audio_High_Bitrate
    {
      get
      {
        int audioHighBitrate;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr_Audio_High_Bitrate, (void*) &audioHighBitrate);
        return audioHighBitrate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr_Audio_High_Bitrate, (void*) &value);
      }
    }

    public static unsafe int Audio_Medium_Bitrate
    {
      get
      {
        int audioMediumBitrate;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr_Audio_Medium_Bitrate, (void*) &audioMediumBitrate);
        return audioMediumBitrate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr_Audio_Medium_Bitrate, (void*) &value);
      }
    }

    public static unsafe int Audio_Low_Bitrate
    {
      get
      {
        int audioLowBitrate;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr_Audio_Low_Bitrate, (void*) &audioLowBitrate);
        return audioLowBitrate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr_Audio_Low_Bitrate, (void*) &value);
      }
    }

    public static unsafe bool _Recording
    {
      get
      {
        bool recording;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__Recording, (void*) &recording);
        return recording;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__Recording, (void*) &value);
      }
    }

    public static unsafe bool _OnlyVideo
    {
      get
      {
        bool onlyVideo;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__OnlyVideo, (void*) &onlyVideo);
        return onlyVideo;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__OnlyVideo, (void*) &value);
      }
    }

    public static unsafe float _NextEncodeTime
    {
      get
      {
        float nextEncodeTime;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__NextEncodeTime, (void*) &nextEncodeTime);
        return nextEncodeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__NextEncodeTime, (void*) &value);
      }
    }

    public static unsafe int _Framerate
    {
      get
      {
        int framerate;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__Framerate, (void*) &framerate);
        return framerate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__Framerate, (void*) &value);
      }
    }

    public static unsafe bool _TheadSafeStop
    {
      get
      {
        bool theadSafeStop;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__TheadSafeStop, (void*) &theadSafeStop);
        return theadSafeStop;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__TheadSafeStop, (void*) &value);
      }
    }

    public static unsafe bool _WaitingForFrameEncode
    {
      get
      {
        bool waitingForFrameEncode;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__WaitingForFrameEncode, (void*) &waitingForFrameEncode);
        return waitingForFrameEncode;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__WaitingForFrameEncode, (void*) &value);
      }
    }

    public static unsafe bool _EncodeVideoNext
    {
      get
      {
        bool encodeVideoNext;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__EncodeVideoNext, (void*) &encodeVideoNext);
        return encodeVideoNext;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__EncodeVideoNext, (void*) &value);
      }
    }

    public static unsafe uint _AudioChannels
    {
      get
      {
        uint audioChannels;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__AudioChannels, (void*) &audioChannels);
        return audioChannels;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__AudioChannels, (void*) &value);
      }
    }

    public static unsafe uint _AudioBufferSize
    {
      get
      {
        uint audioBufferSize;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__AudioBufferSize, (void*) &audioBufferSize);
        return audioBufferSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__AudioBufferSize, (void*) &value);
      }
    }

    public static unsafe int _AudioSamplesRate
    {
      get
      {
        int audioSamplesRate;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__AudioSamplesRate, (void*) &audioSamplesRate);
        return audioSamplesRate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__AudioSamplesRate, (void*) &value);
      }
    }

    public static unsafe bool _Realtime
    {
      get
      {
        bool realtime;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__Realtime, (void*) &realtime);
        return realtime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__Realtime, (void*) &value);
      }
    }

    public static unsafe Thread _Thread
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__Thread, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Thread) null : new Thread(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__Thread, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe bool _WorkerFailed
    {
      get
      {
        bool workerFailed;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__WorkerFailed, (void*) &workerFailed);
        return workerFailed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__WorkerFailed, (void*) &value);
      }
    }

    public static unsafe AutoResetEvent _VideoSyncHandle
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__VideoSyncHandle, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (AutoResetEvent) null : new AutoResetEvent(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__VideoSyncHandle, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe AutoResetEvent _AudioSyncHandle
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__AudioSyncHandle, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (AutoResetEvent) null : new AutoResetEvent(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__AudioSyncHandle, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe BlockingCollection<VideoRecordingUtility.FrameData> _FrameBuffer
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__FrameBuffer, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BlockingCollection<VideoRecordingUtility.FrameData>) null : new BlockingCollection<VideoRecordingUtility.FrameData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__FrameBuffer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe BlockingCollection<VideoRecordingUtility.AudioData> _AudioBuffer
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr__AudioBuffer, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BlockingCollection<VideoRecordingUtility.AudioData>) null : new BlockingCollection<VideoRecordingUtility.AudioData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr__AudioBuffer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action UpdateSound
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VideoRecordingUtility.NativeFieldInfoPtr_UpdateSound, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VideoRecordingUtility.NativeFieldInfoPtr_UpdateSound, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class EncodingSettings : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Filename;
      private static readonly System.IntPtr NativeFieldInfoPtr_PreMediaFilename;
      private static readonly System.IntPtr NativeFieldInfoPtr_PostMediaFilename;
      private static readonly System.IntPtr NativeFieldInfoPtr_Width;
      private static readonly System.IntPtr NativeFieldInfoPtr_Height;
      private static readonly System.IntPtr NativeFieldInfoPtr_Framerate;
      private static readonly System.IntPtr NativeFieldInfoPtr_VideoBitrate;
      private static readonly System.IntPtr NativeFieldInfoPtr_EncodeAudio;
      private static readonly System.IntPtr NativeFieldInfoPtr_AudioBitrate;
      private static readonly System.IntPtr NativeFieldInfoPtr_Uncompressed;
      private static readonly System.IntPtr NativeFieldInfoPtr_FastCompression;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_FromReplaySettings_Public_Static_EncodingSettings_ReplaySettings_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_String_String_byref___c__DisplayClass11_0_PDM_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078314, XrefRangeEnd = 1078421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.EncodingSettings.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078421, XrefRangeEnd = 1078448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe VideoRecordingUtility.EncodingSettings FromReplaySettings(
        ReplaySettings replaySettings)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) replaySettings);
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.EncodingSettings.NativeMethodInfoPtr_FromReplaySettings_Public_Static_EncodingSettings_ReplaySettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new VideoRecordingUtility.EncodingSettings(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078448, XrefRangeEnd = 1078455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Internal_Static_Void_String_String_byref___c__DisplayClass11_0_PDM_0(
        string key,
        string value,
        ref VideoRecordingUtility.EncodingSettings.__c__DisplayClass11_0 _param2)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(value);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param2);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.EncodingSettings.NativeMethodInfoPtr_Method_Internal_Static_Void_String_String_byref___c__DisplayClass11_0_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static EncodingSettings()
      {
        Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (EncodingSettings));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr);
        VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, nameof (Filename));
        VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_PreMediaFilename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, nameof (PreMediaFilename));
        VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_PostMediaFilename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, nameof (PostMediaFilename));
        VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, nameof (Width));
        VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, nameof (Height));
        VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Framerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, nameof (Framerate));
        VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_VideoBitrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, nameof (VideoBitrate));
        VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_EncodeAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, nameof (EncodeAudio));
        VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_AudioBitrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, nameof (AudioBitrate));
        VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Uncompressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, nameof (Uncompressed));
        VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_FastCompression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, nameof (FastCompression));
        VideoRecordingUtility.EncodingSettings.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, 100684962);
        VideoRecordingUtility.EncodingSettings.NativeMethodInfoPtr_FromReplaySettings_Public_Static_EncodingSettings_ReplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, 100684963);
        VideoRecordingUtility.EncodingSettings.NativeMethodInfoPtr_Method_Internal_Static_Void_String_String_byref___c__DisplayClass11_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, 100684964);
      }

      public EncodingSettings(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public EncodingSettings()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, data));
      }

      public unsafe string Filename
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Filename)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Filename), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string PreMediaFilename
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_PreMediaFilename)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_PreMediaFilename), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string PostMediaFilename
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_PostMediaFilename)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_PostMediaFilename), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int Width
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Width));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Width)) = value;
        }
      }

      public unsafe int Height
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Height));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Height)) = value;
        }
      }

      public unsafe int Framerate
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Framerate));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Framerate)) = value;
        }
      }

      public unsafe int VideoBitrate
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_VideoBitrate));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_VideoBitrate)) = value;
        }
      }

      public unsafe bool EncodeAudio
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_EncodeAudio));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_EncodeAudio)) = value;
        }
      }

      public unsafe int AudioBitrate
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_AudioBitrate));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_AudioBitrate)) = value;
        }
      }

      public unsafe bool Uncompressed
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Uncompressed));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_Uncompressed)) = value;
        }
      }

      public unsafe bool FastCompression
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_FastCompression));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.NativeFieldInfoPtr_FastCompression)) = value;
        }
      }

      [ObfuscatedName("ProjectM.VideoRecordingUtility/EncodingSettings/<>c__DisplayClass11_0")]
      public sealed class __c__DisplayClass11_0 : Il2CppSystem.ValueType
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_builder;

        static __c__DisplayClass11_0()
        {
          Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings>.NativeClassPtr, "<>c__DisplayClass11_0");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings.__c__DisplayClass11_0>.NativeClassPtr);
          VideoRecordingUtility.EncodingSettings.__c__DisplayClass11_0.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings.__c__DisplayClass11_0>.NativeClassPtr, nameof (builder));
        }

        public __c__DisplayClass11_0(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public __c__DisplayClass11_0()
        {
          // ISSUE: cast to a reference type
          // ISSUE: untyped stack allocation
          System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings.__c__DisplayClass11_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          // ISSUE: explicit constructor call
          base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoRecordingUtility.EncodingSettings.__c__DisplayClass11_0>.NativeClassPtr, data));
        }

        public unsafe StringBuilder builder
        {
          get
          {
            System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.__c__DisplayClass11_0.NativeFieldInfoPtr_builder));
            return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.EncodingSettings.__c__DisplayClass11_0.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AudioSetup
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Channels;
      private static readonly System.IntPtr NativeFieldInfoPtr_SampleRate;
      private static readonly System.IntPtr NativeFieldInfoPtr_SampleBufferSize;
      [FieldOffset(0)]
      public uint Channels;
      [FieldOffset(4)]
      public int SampleRate;
      [FieldOffset(8)]
      public uint SampleBufferSize;

      static AudioSetup()
      {
        Il2CppClassPointerStore<VideoRecordingUtility.AudioSetup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (AudioSetup));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoRecordingUtility.AudioSetup>.NativeClassPtr);
        VideoRecordingUtility.AudioSetup.NativeFieldInfoPtr_Channels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.AudioSetup>.NativeClassPtr, nameof (Channels));
        VideoRecordingUtility.AudioSetup.NativeFieldInfoPtr_SampleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.AudioSetup>.NativeClassPtr, nameof (SampleRate));
        VideoRecordingUtility.AudioSetup.NativeFieldInfoPtr_SampleBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.AudioSetup>.NativeClassPtr, nameof (SampleBufferSize));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoRecordingUtility.AudioSetup>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum IntoCodes
    {
      ENCODED_VIDEO,
      ENCODED_AUDIO,
      ENCODED_AUDIO_AND_VIDEO,
    }

    public enum ErrorCodes
    {
      ERROR_DEQUEING_FIFO = -20, // 0xFFFFFFEC
      ERROR_ENQUEING_FIFO = -19, // 0xFFFFFFED
      ERROR_CREATING_FIFO = -18, // 0xFFFFFFEE
      ERROR_INIT_AUDIO_RESPAMLER = -17, // 0xFFFFFFEF
      ERROR_WRITING_HEADER = -16, // 0xFFFFFFF0
      ERROR_ENCODING_SAMPLES_RECEIVE = -15, // 0xFFFFFFF1
      ERROR_ENCODING_SAMPLES_SEND = -14, // 0xFFFFFFF2
      ERROR_INIT_RESMPL_CONTEXT = -13, // 0xFFFFFFF3
      ERROR_OPENING_AUD_CODEC = -12, // 0xFFFFFFF4
      ERROR_FINDING_AUD_CODEC = -11, // 0xFFFFFFF5
      ERROR_ENCODING_FRAME_RECEIVE = -10, // 0xFFFFFFF6
      ERROR_ENCODING_FRAME_SEND = -9, // 0xFFFFFFF7
      ERROR_ALLOCATING_PIC_BUF = -8, // 0xFFFFFFF8
      ERROR_ALLOCATING_FRAME = -7, // 0xFFFFFFF9
      ERROR_OPENING_FILE = -6, // 0xFFFFFFFA
      ERROR_OPENING_VID_CODEC = -5, // 0xFFFFFFFB
      ERROR_CONTEXT_ALLOCATING = -4, // 0xFFFFFFFC
      ERROR_CONTEXT_CREATION = -3, // 0xFFFFFFFD
      ERROR_FINDING_VID_CODEC = -2, // 0xFFFFFFFE
      RES_NOT_MUL_OF_TWO = -1, // 0xFFFFFFFF
    }

    public sealed class FrameData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FramesSkipped;
      private static readonly System.IntPtr NativeFieldInfoPtr_RGBBuffer;

      static FrameData()
      {
        Il2CppClassPointerStore<VideoRecordingUtility.FrameData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (FrameData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoRecordingUtility.FrameData>.NativeClassPtr);
        VideoRecordingUtility.FrameData.NativeFieldInfoPtr_FramesSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.FrameData>.NativeClassPtr, nameof (FramesSkipped));
        VideoRecordingUtility.FrameData.NativeFieldInfoPtr_RGBBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.FrameData>.NativeClassPtr, nameof (RGBBuffer));
      }

      public FrameData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public FrameData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VideoRecordingUtility.FrameData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoRecordingUtility.FrameData>.NativeClassPtr, data));
      }

      public unsafe int FramesSkipped
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.FrameData.NativeFieldInfoPtr_FramesSkipped));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.FrameData.NativeFieldInfoPtr_FramesSkipped)) = value;
        }
      }

      public unsafe Il2CppStructArray<byte> RGBBuffer
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.FrameData.NativeFieldInfoPtr_RGBBuffer));
          return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.FrameData.NativeFieldInfoPtr_RGBBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class AudioData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_StereoData;
      private static readonly System.IntPtr NativeFieldInfoPtr_LeftData;
      private static readonly System.IntPtr NativeFieldInfoPtr_RightData;

      static AudioData()
      {
        Il2CppClassPointerStore<VideoRecordingUtility.AudioData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (AudioData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoRecordingUtility.AudioData>.NativeClassPtr);
        VideoRecordingUtility.AudioData.NativeFieldInfoPtr_StereoData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.AudioData>.NativeClassPtr, nameof (StereoData));
        VideoRecordingUtility.AudioData.NativeFieldInfoPtr_LeftData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.AudioData>.NativeClassPtr, nameof (LeftData));
        VideoRecordingUtility.AudioData.NativeFieldInfoPtr_RightData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoRecordingUtility.AudioData>.NativeClassPtr, nameof (RightData));
      }

      public AudioData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public AudioData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VideoRecordingUtility.AudioData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoRecordingUtility.AudioData>.NativeClassPtr, data));
      }

      public unsafe Il2CppStructArray<float> StereoData
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.AudioData.NativeFieldInfoPtr_StereoData));
          return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : new Il2CppStructArray<float>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.AudioData.NativeFieldInfoPtr_StereoData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppStructArray<float> LeftData
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.AudioData.NativeFieldInfoPtr_LeftData));
          return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : new Il2CppStructArray<float>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.AudioData.NativeFieldInfoPtr_LeftData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppStructArray<float> RightData
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.AudioData.NativeFieldInfoPtr_RightData));
          return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : new Il2CppStructArray<float>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VideoRecordingUtility.AudioData.NativeFieldInfoPtr_RightData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class OnCameraRenderCallback : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderTexture_RenderTexture_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderTexture_RenderTexture_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OnCameraRenderCallback(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoRecordingUtility.OnCameraRenderCallback>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.OnCameraRenderCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(157)]
      [CachedScanResults(RefRangeStart = 29843, RefRangeEnd = 30000, XrefRangeStart = 29843, XrefRangeEnd = 30000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(RenderTexture src, RenderTexture dest)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dest);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.OnCameraRenderCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderTexture_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        RenderTexture src,
        RenderTexture dest,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dest);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.OnCameraRenderCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderTexture_RenderTexture_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.OnCameraRenderCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OnCameraRenderCallback()
      {
        Il2CppClassPointerStore<VideoRecordingUtility.OnCameraRenderCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (OnCameraRenderCallback));
        VideoRecordingUtility.OnCameraRenderCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility.OnCameraRenderCallback>.NativeClassPtr, 100684965);
        VideoRecordingUtility.OnCameraRenderCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility.OnCameraRenderCallback>.NativeClassPtr, 100684966);
        VideoRecordingUtility.OnCameraRenderCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderTexture_RenderTexture_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility.OnCameraRenderCallback>.NativeClassPtr, 100684967);
        VideoRecordingUtility.OnCameraRenderCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility.OnCameraRenderCallback>.NativeClassPtr, 100684968);
      }

      public OnCameraRenderCallback(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator VideoRecordingUtility.OnCameraRenderCallback(
        [In] System.Action<RenderTexture, RenderTexture> obj0)
      {
        return DelegateSupport.ConvertDelegate<VideoRecordingUtility.OnCameraRenderCallback>((System.Delegate) obj0);
      }

      public static VideoRecordingUtility.OnCameraRenderCallback operator +(
        [In] VideoRecordingUtility.OnCameraRenderCallback obj0,
        [In] VideoRecordingUtility.OnCameraRenderCallback obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<VideoRecordingUtility.OnCameraRenderCallback>();
      }

      public static VideoRecordingUtility.OnCameraRenderCallback operator -(
        [In] VideoRecordingUtility.OnCameraRenderCallback obj0,
        [In] VideoRecordingUtility.OnCameraRenderCallback obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (VideoRecordingUtility.OnCameraRenderCallback) @delegate : @delegate.Cast<VideoRecordingUtility.OnCameraRenderCallback>();
      }
    }

    public sealed class OnAudioDataCallback : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Single_Int32_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OnAudioDataCallback(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoRecordingUtility.OnAudioDataCallback>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.OnAudioDataCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078455, XrefRangeEnd = 1078486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(Il2CppStructArray<float> data, int channels)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &channels;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.OnAudioDataCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078486, XrefRangeEnd = 1078490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        Il2CppStructArray<float> data,
        int channels,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &channels;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.OnAudioDataCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VideoRecordingUtility.OnAudioDataCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OnAudioDataCallback()
      {
        Il2CppClassPointerStore<VideoRecordingUtility.OnAudioDataCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoRecordingUtility>.NativeClassPtr, nameof (OnAudioDataCallback));
        VideoRecordingUtility.OnAudioDataCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility.OnAudioDataCallback>.NativeClassPtr, 100684969);
        VideoRecordingUtility.OnAudioDataCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility.OnAudioDataCallback>.NativeClassPtr, 100684970);
        VideoRecordingUtility.OnAudioDataCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility.OnAudioDataCallback>.NativeClassPtr, 100684971);
        VideoRecordingUtility.OnAudioDataCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoRecordingUtility.OnAudioDataCallback>.NativeClassPtr, 100684972);
      }

      public OnAudioDataCallback(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator VideoRecordingUtility.OnAudioDataCallback(
        [In] System.Action<Il2CppStructArray<float>, int> obj0)
      {
        return DelegateSupport.ConvertDelegate<VideoRecordingUtility.OnAudioDataCallback>((System.Delegate) obj0);
      }

      public static VideoRecordingUtility.OnAudioDataCallback operator +(
        [In] VideoRecordingUtility.OnAudioDataCallback obj0,
        [In] VideoRecordingUtility.OnAudioDataCallback obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<VideoRecordingUtility.OnAudioDataCallback>();
      }

      public static VideoRecordingUtility.OnAudioDataCallback operator -(
        [In] VideoRecordingUtility.OnAudioDataCallback obj0,
        [In] VideoRecordingUtility.OnAudioDataCallback obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (VideoRecordingUtility.OnAudioDataCallback) @delegate : @delegate.Cast<VideoRecordingUtility.OnAudioDataCallback>();
      }
    }
  }
}
