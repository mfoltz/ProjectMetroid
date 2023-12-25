// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.AudioBuffer
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
  public sealed class AudioBuffer : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Frames_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__SampleRate_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Channels_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Frames_Public_get_Il2CppStructArray_1_Int16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Frames_Public_set_Void_Il2CppStructArray_1_Int16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SampleRate_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SampleRate_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Channels_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Channels_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_AudioBufferInternal_0;

    public unsafe Il2CppStructArray<short> Frames
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioBuffer.NativeMethodInfoPtr_get_Frames_Public_get_Il2CppStructArray_1_Int16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<short>) null : new Il2CppStructArray<short>(nativeObject);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AudioBuffer.NativeMethodInfoPtr_set_Frames_Public_set_Void_Il2CppStructArray_1_Int16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint SampleRate
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioBuffer.NativeMethodInfoPtr_get_SampleRate_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 204781, RefRangeEnd = 204792, XrefRangeStart = 204781, XrefRangeEnd = 204792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AudioBuffer.NativeMethodInfoPtr_set_SampleRate_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint Channels
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioBuffer.NativeMethodInfoPtr_get_Channels_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 204792, RefRangeEnd = 204801, XrefRangeStart = 204792, XrefRangeEnd = 204801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AudioBuffer.NativeMethodInfoPtr_set_Channels_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944121, XrefRangeEnd = 944123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref AudioBufferInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioBuffer.NativeMethodInfoPtr_Set_Internal_Void_byref_AudioBufferInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AudioBuffer()
    {
      Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTCAudio", nameof (AudioBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr);
      AudioBuffer.NativeFieldInfoPtr__Frames_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr, "<Frames>k__BackingField");
      AudioBuffer.NativeFieldInfoPtr__SampleRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr, "<SampleRate>k__BackingField");
      AudioBuffer.NativeFieldInfoPtr__Channels_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr, "<Channels>k__BackingField");
      AudioBuffer.NativeMethodInfoPtr_get_Frames_Public_get_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr, 100666966);
      AudioBuffer.NativeMethodInfoPtr_set_Frames_Public_set_Void_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr, 100666967);
      AudioBuffer.NativeMethodInfoPtr_get_SampleRate_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr, 100666968);
      AudioBuffer.NativeMethodInfoPtr_set_SampleRate_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr, 100666969);
      AudioBuffer.NativeMethodInfoPtr_get_Channels_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr, 100666970);
      AudioBuffer.NativeMethodInfoPtr_set_Channels_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr, 100666971);
      AudioBuffer.NativeMethodInfoPtr_Set_Internal_Void_byref_AudioBufferInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr, 100666972);
    }

    public AudioBuffer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AudioBuffer()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioBuffer>.NativeClassPtr, data));
    }

    public unsafe Il2CppStructArray<short> _Frames_k__BackingField
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioBuffer.NativeFieldInfoPtr__Frames_k__BackingField));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<short>) null : new Il2CppStructArray<short>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioBuffer.NativeFieldInfoPtr__Frames_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe uint _SampleRate_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioBuffer.NativeFieldInfoPtr__SampleRate_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioBuffer.NativeFieldInfoPtr__SampleRate_k__BackingField)) = value;
      }
    }

    public unsafe uint _Channels_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioBuffer.NativeFieldInfoPtr__Channels_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioBuffer.NativeFieldInfoPtr__Channels_k__BackingField)) = value;
      }
    }
  }
}
