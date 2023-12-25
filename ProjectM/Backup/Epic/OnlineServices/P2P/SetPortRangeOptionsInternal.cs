// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SetPortRangeOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetPortRangeOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Port;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxAdditionalPortsToTry;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Port_Public_set_Void_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxAdditionalPortsToTry_Public_set_Void_UInt16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetPortRangeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetPortRangeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public ushort m_Port;
    [FieldOffset(6)]
    public ushort m_MaxAdditionalPortsToTry;

    public unsafe ushort Port
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptionsInternal.NativeMethodInfoPtr_set_Port_Public_set_Void_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ushort MaxAdditionalPortsToTry
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptionsInternal.NativeMethodInfoPtr_set_MaxAdditionalPortsToTry_Public_set_Void_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 952382, RefRangeEnd = 952383, XrefRangeStart = 952382, XrefRangeEnd = 952382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref SetPortRangeOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetPortRangeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952383, XrefRangeEnd = 952389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Nullable_Unboxed<SetPortRangeOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetPortRangeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetPortRangeOptionsInternal()
    {
      Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (SetPortRangeOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr);
      SetPortRangeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      SetPortRangeOptionsInternal.NativeFieldInfoPtr_m_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, nameof (m_Port));
      SetPortRangeOptionsInternal.NativeFieldInfoPtr_m_MaxAdditionalPortsToTry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, nameof (m_MaxAdditionalPortsToTry));
      SetPortRangeOptionsInternal.NativeMethodInfoPtr_set_Port_Public_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, 100669249);
      SetPortRangeOptionsInternal.NativeMethodInfoPtr_set_MaxAdditionalPortsToTry_Public_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, 100669250);
      SetPortRangeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetPortRangeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, 100669251);
      SetPortRangeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetPortRangeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, 100669252);
      SetPortRangeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, 100669253);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
