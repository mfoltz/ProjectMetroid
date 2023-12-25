// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LocalRTCOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LocalRTCOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UseManualAudioInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UseManualAudioOutput;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalAudioDeviceInputStartsMuted;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Flags_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UseManualAudioInput_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UseManualAudioInput_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UseManualAudioOutput_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UseManualAudioOutput_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalAudioDeviceInputStartsMuted_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalAudioDeviceInputStartsMuted_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LocalRTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_LocalRTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LocalRTCOptions_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public uint m_Flags;
    [FieldOffset(8)]
    public int m_UseManualAudioInput;
    [FieldOffset(12)]
    public int m_UseManualAudioOutput;
    [FieldOffset(16)]
    public int m_LocalAudioDeviceInputStartsMuted;

    public unsafe uint Flags
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_get_Flags_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool UseManualAudioInput
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957461, XrefRangeEnd = 957465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_get_UseManualAudioInput_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957465, XrefRangeEnd = 957469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_set_UseManualAudioInput_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool UseManualAudioOutput
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957469, XrefRangeEnd = 957473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_get_UseManualAudioOutput_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957473, XrefRangeEnd = 957477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_set_UseManualAudioOutput_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool LocalAudioDeviceInputStartsMuted
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957477, XrefRangeEnd = 957481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_get_LocalAudioDeviceInputStartsMuted_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957481, XrefRangeEnd = 957485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_set_LocalAudioDeviceInputStartsMuted_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957485, XrefRangeEnd = 957497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LocalRTCOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LocalRTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957497, XrefRangeEnd = 957519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Nullable_Unboxed<LocalRTCOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_LocalRTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957519, XrefRangeEnd = 957520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out LocalRTCOptions output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref output;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalRTCOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LocalRTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LocalRTCOptionsInternal()
    {
      Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (LocalRTCOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr);
      LocalRTCOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      LocalRTCOptionsInternal.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, nameof (m_Flags));
      LocalRTCOptionsInternal.NativeFieldInfoPtr_m_UseManualAudioInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, nameof (m_UseManualAudioInput));
      LocalRTCOptionsInternal.NativeFieldInfoPtr_m_UseManualAudioOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, nameof (m_UseManualAudioOutput));
      LocalRTCOptionsInternal.NativeFieldInfoPtr_m_LocalAudioDeviceInputStartsMuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, nameof (m_LocalAudioDeviceInputStartsMuted));
      LocalRTCOptionsInternal.NativeMethodInfoPtr_get_Flags_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100670473);
      LocalRTCOptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100670474);
      LocalRTCOptionsInternal.NativeMethodInfoPtr_get_UseManualAudioInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100670475);
      LocalRTCOptionsInternal.NativeMethodInfoPtr_set_UseManualAudioInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100670476);
      LocalRTCOptionsInternal.NativeMethodInfoPtr_get_UseManualAudioOutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100670477);
      LocalRTCOptionsInternal.NativeMethodInfoPtr_set_UseManualAudioOutput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100670478);
      LocalRTCOptionsInternal.NativeMethodInfoPtr_get_LocalAudioDeviceInputStartsMuted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100670479);
      LocalRTCOptionsInternal.NativeMethodInfoPtr_set_LocalAudioDeviceInputStartsMuted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100670480);
      LocalRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100670481);
      LocalRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100670482);
      LocalRTCOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100670483);
      LocalRTCOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, 100670484);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalRTCOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
