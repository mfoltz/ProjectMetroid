// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.AudioBufferInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAudio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AudioBufferInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Frames;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_FramesCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SampleRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Channels;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Frames_Public_get_Il2CppStructArray_1_Int16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Frames_Public_set_Void_Il2CppStructArray_1_Int16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SampleRate_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SampleRate_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Channels_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Channels_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AudioBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AudioBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AudioBuffer_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Frames;
    [FieldOffset(16)]
    public uint m_FramesCount;
    [FieldOffset(20)]
    public uint m_SampleRate;
    [FieldOffset(24)]
    public uint m_Channels;

    public unsafe Il2CppStructArray<short> Frames
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 944129, RefRangeEnd = 944131, XrefRangeStart = 944123, XrefRangeEnd = 944129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_get_Frames_Public_get_Il2CppStructArray_1_Int16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<short>) null : new Il2CppStructArray<short>(nativeObject);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 944137, RefRangeEnd = 944139, XrefRangeStart = 944131, XrefRangeEnd = 944137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_set_Frames_Public_set_Void_Il2CppStructArray_1_Int16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint SampleRate
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 23498, RefRangeEnd = 23499, XrefRangeStart = 23498, XrefRangeEnd = 23499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_get_SampleRate_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 23499, RefRangeEnd = 23501, XrefRangeStart = 23499, XrefRangeEnd = 23501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_set_SampleRate_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint Channels
    {
      [CallerCount(264), CachedScanResults(RefRangeStart = 39170, RefRangeEnd = 39434, XrefRangeStart = 39170, XrefRangeEnd = 39434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_get_Channels_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 20483, RefRangeEnd = 20486, XrefRangeStart = 20483, XrefRangeEnd = 20486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_set_Channels_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944139, XrefRangeEnd = 944140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref AudioBuffer other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AudioBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944140, XrefRangeEnd = 944149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<AudioBuffer> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AudioBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944149, XrefRangeEnd = 944153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944153, XrefRangeEnd = 944155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out AudioBuffer output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AudioBuffer_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref AudioBuffer local = ref output;
      System.IntPtr pointer = zero;
      AudioBuffer audioBuffer = pointer == System.IntPtr.Zero ? (AudioBuffer) null : new AudioBuffer(pointer);
      local = audioBuffer;
    }

    static AudioBufferInternal()
    {
      Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTCAudio", nameof (AudioBufferInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr);
      AudioBufferInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, nameof (m_ApiVersion));
      AudioBufferInternal.NativeFieldInfoPtr_m_Frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, nameof (m_Frames));
      AudioBufferInternal.NativeFieldInfoPtr_m_FramesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, nameof (m_FramesCount));
      AudioBufferInternal.NativeFieldInfoPtr_m_SampleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, nameof (m_SampleRate));
      AudioBufferInternal.NativeFieldInfoPtr_m_Channels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, nameof (m_Channels));
      AudioBufferInternal.NativeMethodInfoPtr_get_Frames_Public_get_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666973);
      AudioBufferInternal.NativeMethodInfoPtr_set_Frames_Public_set_Void_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666974);
      AudioBufferInternal.NativeMethodInfoPtr_get_SampleRate_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666975);
      AudioBufferInternal.NativeMethodInfoPtr_set_SampleRate_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666976);
      AudioBufferInternal.NativeMethodInfoPtr_get_Channels_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666977);
      AudioBufferInternal.NativeMethodInfoPtr_set_Channels_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666978);
      AudioBufferInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AudioBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666979);
      AudioBufferInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AudioBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666980);
      AudioBufferInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666981);
      AudioBufferInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AudioBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666982);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
