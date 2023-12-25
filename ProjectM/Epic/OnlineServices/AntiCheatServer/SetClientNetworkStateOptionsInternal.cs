// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatServer.SetClientNetworkStateOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatServer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetClientNetworkStateOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IsNetworkActive;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsNetworkActive_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetClientNetworkStateOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetClientNetworkStateOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_ClientHandle;
    [FieldOffset(16)]
    public int m_IsNetworkActive;

    public unsafe System.IntPtr ClientHandle
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsNetworkActive
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969360, XrefRangeEnd = 969364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_set_IsNetworkActive_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 969368, RefRangeEnd = 969369, XrefRangeStart = 969364, XrefRangeEnd = 969368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref SetClientNetworkStateOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetClientNetworkStateOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969369, XrefRangeEnd = 969379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Nullable_Unboxed<SetClientNetworkStateOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetClientNetworkStateOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969379, XrefRangeEnd = 969383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetClientNetworkStateOptionsInternal()
    {
      Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatServer", nameof (SetClientNetworkStateOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr);
      SetClientNetworkStateOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      SetClientNetworkStateOptionsInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, nameof (m_ClientHandle));
      SetClientNetworkStateOptionsInternal.NativeFieldInfoPtr_m_IsNetworkActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, nameof (m_IsNetworkActive));
      SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, 100673902);
      SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_set_IsNetworkActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, 100673903);
      SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetClientNetworkStateOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, 100673904);
      SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetClientNetworkStateOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, 100673905);
      SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, 100673906);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
