// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.RegisterEventOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RegisterEventOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EventName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EventType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamDefsCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamDefs;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EventName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EventType_Public_set_Void_AntiCheatCommonEventType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParamDefs_Public_set_Void_Il2CppReferenceArray_1_RegisterEventParamDef_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RegisterEventOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RegisterEventOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public uint m_EventId;
    [FieldOffset(8)]
    public System.IntPtr m_EventName;
    [FieldOffset(16)]
    public AntiCheatCommonEventType m_EventType;
    [FieldOffset(20)]
    public uint m_ParamDefsCount;
    [FieldOffset(24)]
    public System.IntPtr m_ParamDefs;

    public unsafe uint EventId
    {
      [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String EventName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970680, XrefRangeEnd = 970684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_set_EventName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonEventType EventType
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_set_EventType_Public_set_Void_AntiCheatCommonEventType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<RegisterEventParamDef> ParamDefs
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 970690, RefRangeEnd = 970692, XrefRangeStart = 970684, XrefRangeEnd = 970690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_set_ParamDefs_Public_set_Void_Il2CppReferenceArray_1_RegisterEventParamDef_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 970697, RefRangeEnd = 970698, XrefRangeStart = 970692, XrefRangeEnd = 970697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref RegisterEventOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RegisterEventOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970698, XrefRangeEnd = 970713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<RegisterEventOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RegisterEventOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970713, XrefRangeEnd = 970718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RegisterEventOptionsInternal()
    {
      Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (RegisterEventOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr);
      RegisterEventOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      RegisterEventOptionsInternal.NativeFieldInfoPtr_m_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, nameof (m_EventId));
      RegisterEventOptionsInternal.NativeFieldInfoPtr_m_EventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, nameof (m_EventName));
      RegisterEventOptionsInternal.NativeFieldInfoPtr_m_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, nameof (m_EventType));
      RegisterEventOptionsInternal.NativeFieldInfoPtr_m_ParamDefsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, nameof (m_ParamDefsCount));
      RegisterEventOptionsInternal.NativeFieldInfoPtr_m_ParamDefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, nameof (m_ParamDefs));
      RegisterEventOptionsInternal.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100674265);
      RegisterEventOptionsInternal.NativeMethodInfoPtr_set_EventName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100674266);
      RegisterEventOptionsInternal.NativeMethodInfoPtr_set_EventType_Public_set_Void_AntiCheatCommonEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100674267);
      RegisterEventOptionsInternal.NativeMethodInfoPtr_set_ParamDefs_Public_set_Void_Il2CppReferenceArray_1_RegisterEventParamDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100674268);
      RegisterEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RegisterEventOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100674269);
      RegisterEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RegisterEventOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100674270);
      RegisterEventOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100674271);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
