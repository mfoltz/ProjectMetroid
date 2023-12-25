// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.SetClientDetailsOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetClientDetailsOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientInputMethod;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientFlags_Public_set_Void_AntiCheatCommonClientFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientInputMethod_Public_set_Void_AntiCheatCommonClientInput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetClientDetailsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetClientDetailsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_ClientHandle;
    [FieldOffset(16)]
    public AntiCheatCommonClientFlags m_ClientFlags;
    [FieldOffset(20)]
    public AntiCheatCommonClientInput m_ClientInputMethod;

    public unsafe System.IntPtr ClientHandle
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonClientFlags ClientFlags
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptionsInternal.NativeMethodInfoPtr_set_ClientFlags_Public_set_Void_AntiCheatCommonClientFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonClientInput ClientInputMethod
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 23499, RefRangeEnd = 23501, XrefRangeStart = 23499, XrefRangeEnd = 23501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptionsInternal.NativeMethodInfoPtr_set_ClientInputMethod_Public_set_Void_AntiCheatCommonClientInput_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 970049, RefRangeEnd = 970051, XrefRangeStart = 970049, XrefRangeEnd = 970051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref SetClientDetailsOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetClientDetailsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970751, XrefRangeEnd = 970759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Nullable_Unboxed<SetClientDetailsOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetClientDetailsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970759, XrefRangeEnd = 970763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetClientDetailsOptionsInternal()
    {
      Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (SetClientDetailsOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr);
      SetClientDetailsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      SetClientDetailsOptionsInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, nameof (m_ClientHandle));
      SetClientDetailsOptionsInternal.NativeFieldInfoPtr_m_ClientFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, nameof (m_ClientFlags));
      SetClientDetailsOptionsInternal.NativeFieldInfoPtr_m_ClientInputMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, nameof (m_ClientInputMethod));
      SetClientDetailsOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, 100674291);
      SetClientDetailsOptionsInternal.NativeMethodInfoPtr_set_ClientFlags_Public_set_Void_AntiCheatCommonClientFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, 100674292);
      SetClientDetailsOptionsInternal.NativeMethodInfoPtr_set_ClientInputMethod_Public_set_Void_AntiCheatCommonClientInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, 100674293);
      SetClientDetailsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetClientDetailsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, 100674294);
      SetClientDetailsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetClientDetailsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, 100674295);
      SetClientDetailsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, 100674296);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
