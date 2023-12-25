// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.GetAudioInputDeviceByIndexOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAudio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GetAudioInputDeviceByIndexOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DeviceInfoIndex_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DeviceInfoIndex_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DeviceInfoIndex_Public_set_Void_UInt32_0;
    [FieldOffset(0)]
    public uint _DeviceInfoIndex_k__BackingField;

    public unsafe uint DeviceInfoIndex
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetAudioInputDeviceByIndexOptions.NativeMethodInfoPtr_get_DeviceInfoIndex_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetAudioInputDeviceByIndexOptions.NativeMethodInfoPtr_set_DeviceInfoIndex_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static GetAudioInputDeviceByIndexOptions()
    {
      Il2CppClassPointerStore<GetAudioInputDeviceByIndexOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTCAudio", nameof (GetAudioInputDeviceByIndexOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetAudioInputDeviceByIndexOptions>.NativeClassPtr);
      GetAudioInputDeviceByIndexOptions.NativeFieldInfoPtr__DeviceInfoIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAudioInputDeviceByIndexOptions>.NativeClassPtr, "<DeviceInfoIndex>k__BackingField");
      GetAudioInputDeviceByIndexOptions.NativeMethodInfoPtr_get_DeviceInfoIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetAudioInputDeviceByIndexOptions>.NativeClassPtr, 100667074);
      GetAudioInputDeviceByIndexOptions.NativeMethodInfoPtr_set_DeviceInfoIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetAudioInputDeviceByIndexOptions>.NativeClassPtr, 100667075);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetAudioInputDeviceByIndexOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
