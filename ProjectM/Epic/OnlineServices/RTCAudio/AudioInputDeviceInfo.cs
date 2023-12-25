﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.AudioInputDeviceInfo
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
  public sealed class AudioInputDeviceInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DefaultDevice_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DeviceId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DeviceName_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultDevice_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DefaultDevice_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DeviceId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DeviceId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DeviceName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DeviceName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_AudioInputDeviceInfoInternal_0;

    public unsafe bool DefaultDevice
    {
      [CallerCount(83), CachedScanResults(RefRangeStart = 438794, RefRangeEnd = 438877, XrefRangeStart = 438794, XrefRangeEnd = 438877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfo.NativeMethodInfoPtr_get_DefaultDevice_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 246533, RefRangeEnd = 246534, XrefRangeStart = 246533, XrefRangeEnd = 246534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfo.NativeMethodInfoPtr_set_DefaultDevice_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DeviceId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfo.NativeMethodInfoPtr_get_DeviceId_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfo.NativeMethodInfoPtr_set_DeviceId_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String DeviceName
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfo.NativeMethodInfoPtr_get_DeviceName_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfo.NativeMethodInfoPtr_set_DeviceName_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 944200, RefRangeEnd = 944201, XrefRangeStart = 944186, XrefRangeEnd = 944200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref AudioInputDeviceInfoInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AudioInputDeviceInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_AudioInputDeviceInfoInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AudioInputDeviceInfo()
    {
      Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTCAudio", nameof (AudioInputDeviceInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr);
      AudioInputDeviceInfo.NativeFieldInfoPtr__DefaultDevice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr, "<DefaultDevice>k__BackingField");
      AudioInputDeviceInfo.NativeFieldInfoPtr__DeviceId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr, "<DeviceId>k__BackingField");
      AudioInputDeviceInfo.NativeFieldInfoPtr__DeviceName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr, "<DeviceName>k__BackingField");
      AudioInputDeviceInfo.NativeMethodInfoPtr_get_DefaultDevice_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr, 100666994);
      AudioInputDeviceInfo.NativeMethodInfoPtr_set_DefaultDevice_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr, 100666995);
      AudioInputDeviceInfo.NativeMethodInfoPtr_get_DeviceId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr, 100666996);
      AudioInputDeviceInfo.NativeMethodInfoPtr_set_DeviceId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr, 100666997);
      AudioInputDeviceInfo.NativeMethodInfoPtr_get_DeviceName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr, 100666998);
      AudioInputDeviceInfo.NativeMethodInfoPtr_set_DeviceName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr, 100666999);
      AudioInputDeviceInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_AudioInputDeviceInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr, 100667000);
    }

    public AudioInputDeviceInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AudioInputDeviceInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioInputDeviceInfo>.NativeClassPtr, data));
    }

    public unsafe bool _DefaultDevice_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioInputDeviceInfo.NativeFieldInfoPtr__DefaultDevice_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioInputDeviceInfo.NativeFieldInfoPtr__DefaultDevice_k__BackingField)) = value;
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _DeviceId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioInputDeviceInfo.NativeFieldInfoPtr__DeviceId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioInputDeviceInfo.NativeFieldInfoPtr__DeviceId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _DeviceName_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioInputDeviceInfo.NativeFieldInfoPtr__DeviceName_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioInputDeviceInfo.NativeFieldInfoPtr__DeviceName_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
