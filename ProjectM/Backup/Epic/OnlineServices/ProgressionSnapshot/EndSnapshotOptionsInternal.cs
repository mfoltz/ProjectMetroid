// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.ProgressionSnapshot.EndSnapshotOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.ProgressionSnapshot
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EndSnapshotOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SnapshotId;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SnapshotId_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_EndSnapshotOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_EndSnapshotOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public uint m_SnapshotId;

    public unsafe uint SnapshotId
    {
      [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EndSnapshotOptionsInternal.NativeMethodInfoPtr_set_SnapshotId_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 937918, RefRangeEnd = 937935, XrefRangeStart = 937918, XrefRangeEnd = 937935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref EndSnapshotOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EndSnapshotOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_EndSnapshotOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947889, XrefRangeEnd = 947893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Nullable_Unboxed<EndSnapshotOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EndSnapshotOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_EndSnapshotOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EndSnapshotOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EndSnapshotOptionsInternal()
    {
      Il2CppClassPointerStore<EndSnapshotOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.ProgressionSnapshot", nameof (EndSnapshotOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndSnapshotOptionsInternal>.NativeClassPtr);
      EndSnapshotOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndSnapshotOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      EndSnapshotOptionsInternal.NativeFieldInfoPtr_m_SnapshotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndSnapshotOptionsInternal>.NativeClassPtr, nameof (m_SnapshotId));
      EndSnapshotOptionsInternal.NativeMethodInfoPtr_set_SnapshotId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndSnapshotOptionsInternal>.NativeClassPtr, 100668015);
      EndSnapshotOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_EndSnapshotOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndSnapshotOptionsInternal>.NativeClassPtr, 100668016);
      EndSnapshotOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_EndSnapshotOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndSnapshotOptionsInternal>.NativeClassPtr, 100668017);
      EndSnapshotOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndSnapshotOptionsInternal>.NativeClassPtr, 100668018);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EndSnapshotOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
