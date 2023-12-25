// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LocalRTCOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LocalRTCOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Flags_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__UseManualAudioInput_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__UseManualAudioOutput_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalAudioDeviceInputStartsMuted_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Flags_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UseManualAudioInput_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UseManualAudioInput_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UseManualAudioOutput_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UseManualAudioOutput_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalAudioDeviceInputStartsMuted_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalAudioDeviceInputStartsMuted_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_LocalRTCOptionsInternal_0;
    [FieldOffset(0)]
    public uint _Flags_k__BackingField;
    [FieldOffset(4)]
    public bool _UseManualAudioInput_k__BackingField;
    [FieldOffset(5)]
    public bool _UseManualAudioOutput_k__BackingField;
    [FieldOffset(6)]
    public bool _LocalAudioDeviceInputStartsMuted_k__BackingField;

    public unsafe uint Flags
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_get_Flags_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_set_Flags_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool UseManualAudioInput
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_get_UseManualAudioInput_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 246537, RefRangeEnd = 246538, XrefRangeStart = 246537, XrefRangeEnd = 246538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_set_UseManualAudioInput_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool UseManualAudioOutput
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_get_UseManualAudioOutput_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 246538, RefRangeEnd = 246539, XrefRangeStart = 246538, XrefRangeEnd = 246539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_set_UseManualAudioOutput_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool LocalAudioDeviceInputStartsMuted
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_get_LocalAudioDeviceInputStartsMuted_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 246539, RefRangeEnd = 246540, XrefRangeStart = 246539, XrefRangeEnd = 246540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_set_LocalAudioDeviceInputStartsMuted_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 957460, RefRangeEnd = 957461, XrefRangeStart = 957448, XrefRangeEnd = 957460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref LocalRTCOptionsInternal other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalRTCOptions.NativeMethodInfoPtr_Set_Internal_Void_byref_LocalRTCOptionsInternal_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LocalRTCOptions()
    {
      Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (LocalRTCOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr);
      LocalRTCOptions.NativeFieldInfoPtr__Flags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, "<Flags>k__BackingField");
      LocalRTCOptions.NativeFieldInfoPtr__UseManualAudioInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, "<UseManualAudioInput>k__BackingField");
      LocalRTCOptions.NativeFieldInfoPtr__UseManualAudioOutput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, "<UseManualAudioOutput>k__BackingField");
      LocalRTCOptions.NativeFieldInfoPtr__LocalAudioDeviceInputStartsMuted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, "<LocalAudioDeviceInputStartsMuted>k__BackingField");
      LocalRTCOptions.NativeMethodInfoPtr_get_Flags_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100670464);
      LocalRTCOptions.NativeMethodInfoPtr_set_Flags_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100670465);
      LocalRTCOptions.NativeMethodInfoPtr_get_UseManualAudioInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100670466);
      LocalRTCOptions.NativeMethodInfoPtr_set_UseManualAudioInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100670467);
      LocalRTCOptions.NativeMethodInfoPtr_get_UseManualAudioOutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100670468);
      LocalRTCOptions.NativeMethodInfoPtr_set_UseManualAudioOutput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100670469);
      LocalRTCOptions.NativeMethodInfoPtr_get_LocalAudioDeviceInputStartsMuted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100670470);
      LocalRTCOptions.NativeMethodInfoPtr_set_LocalAudioDeviceInputStartsMuted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100670471);
      LocalRTCOptions.NativeMethodInfoPtr_Set_Internal_Void_byref_LocalRTCOptionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, 100670472);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalRTCOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
