// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.AudioOutputDeviceInfoInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAudio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AudioOutputDeviceInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultDevice;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceName;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultDevice_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DefaultDevice_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DeviceId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DeviceId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DeviceName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DeviceName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AudioOutputDeviceInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AudioOutputDeviceInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AudioOutputDeviceInfo_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public int m_DefaultDevice;
    [FieldOffset(8)]
    public System.IntPtr m_DeviceId;
    [FieldOffset(16)]
    public System.IntPtr m_DeviceName;

    public unsafe bool DefaultDevice
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944359, XrefRangeEnd = 944363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_get_DefaultDevice_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944363, XrefRangeEnd = 944367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_set_DefaultDevice_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DeviceId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944367, XrefRangeEnd = 944371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_get_DeviceId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944371, XrefRangeEnd = 944375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_set_DeviceId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DeviceName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944375, XrefRangeEnd = 944379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_get_DeviceName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944379, XrefRangeEnd = 944383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_set_DeviceName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944383, XrefRangeEnd = 944395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref AudioOutputDeviceInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AudioOutputDeviceInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944395, XrefRangeEnd = 944415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<AudioOutputDeviceInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AudioOutputDeviceInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944415, XrefRangeEnd = 944420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944420, XrefRangeEnd = 944421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out AudioOutputDeviceInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AudioOutputDeviceInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref AudioOutputDeviceInfo local = ref output;
      System.IntPtr pointer = zero;
      AudioOutputDeviceInfo outputDeviceInfo = pointer == System.IntPtr.Zero ? (AudioOutputDeviceInfo) null : new AudioOutputDeviceInfo(pointer);
      local = outputDeviceInfo;
    }

    static AudioOutputDeviceInfoInternal()
    {
      Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTCAudio", nameof (AudioOutputDeviceInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr);
      AudioOutputDeviceInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
      AudioOutputDeviceInfoInternal.NativeFieldInfoPtr_m_DefaultDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, nameof (m_DefaultDevice));
      AudioOutputDeviceInfoInternal.NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, nameof (m_DeviceId));
      AudioOutputDeviceInfoInternal.NativeFieldInfoPtr_m_DeviceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, nameof (m_DeviceName));
      AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_get_DefaultDevice_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100667041);
      AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_set_DefaultDevice_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100667042);
      AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_get_DeviceId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100667043);
      AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_set_DeviceId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100667044);
      AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_get_DeviceName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100667045);
      AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_set_DeviceName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100667046);
      AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AudioOutputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100667047);
      AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AudioOutputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100667048);
      AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100667049);
      AudioOutputDeviceInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AudioOutputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, 100667050);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioOutputDeviceInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
