// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Stats.IngestStatOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Stats
{
  [StructLayout(LayoutKind.Explicit)]
  public struct IngestStatOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Stats;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StatsCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Stats_Public_set_Void_Il2CppReferenceArray_1_IngestData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IngestStatOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_IngestStatOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_Stats;
    [FieldOffset(24)]
    public uint m_StatsCount;
    [FieldOffset(32)]
    public System.IntPtr m_TargetUserId;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939547, XrefRangeEnd = 939551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IngestStatOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<IngestData> Stats
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 939557, RefRangeEnd = 939559, XrefRangeStart = 939551, XrefRangeEnd = 939557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IngestStatOptionsInternal.NativeMethodInfoPtr_set_Stats_Public_set_Void_Il2CppReferenceArray_1_IngestData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId TargetUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939559, XrefRangeEnd = 939563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IngestStatOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 939572, RefRangeEnd = 939573, XrefRangeStart = 939563, XrefRangeEnd = 939572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref IngestStatOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IngestStatOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IngestStatOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939573, XrefRangeEnd = 939590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<IngestStatOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IngestStatOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_IngestStatOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939590, XrefRangeEnd = 939596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IngestStatOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IngestStatOptionsInternal()
    {
      Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Stats", nameof (IngestStatOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr);
      IngestStatOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      IngestStatOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      IngestStatOptionsInternal.NativeFieldInfoPtr_m_Stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, nameof (m_Stats));
      IngestStatOptionsInternal.NativeFieldInfoPtr_m_StatsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, nameof (m_StatsCount));
      IngestStatOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
      IngestStatOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, 100665756);
      IngestStatOptionsInternal.NativeMethodInfoPtr_set_Stats_Public_set_Void_Il2CppReferenceArray_1_IngestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, 100665757);
      IngestStatOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, 100665758);
      IngestStatOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IngestStatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, 100665759);
      IngestStatOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_IngestStatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, 100665760);
      IngestStatOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, 100665761);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
