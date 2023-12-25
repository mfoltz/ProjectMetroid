// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.GetDesktopCrossplayStatusInfoInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GetDesktopCrossplayStatusInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ServiceInitResult;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Status_Public_get_DesktopCrossplayStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Status_Public_set_Void_DesktopCrossplayStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ServiceInitResult_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ServiceInitResult_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_GetDesktopCrossplayStatusInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_GetDesktopCrossplayStatusInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_GetDesktopCrossplayStatusInfo_0;
    [FieldOffset(0)]
    public DesktopCrossplayStatus m_Status;
    [FieldOffset(4)]
    public int m_ServiceInitResult;

    public unsafe DesktopCrossplayStatus Status
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_get_Status_Public_get_DesktopCrossplayStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DesktopCrossplayStatus*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_set_Status_Public_set_Void_DesktopCrossplayStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int ServiceInitResult
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_get_ServiceInitResult_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_set_ServiceInitResult_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 971955, RefRangeEnd = 971956, XrefRangeStart = 971955, XrefRangeEnd = 971956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref GetDesktopCrossplayStatusInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_GetDesktopCrossplayStatusInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971956, XrefRangeEnd = 971962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Nullable_Unboxed<GetDesktopCrossplayStatusInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_GetDesktopCrossplayStatusInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Get(out GetDesktopCrossplayStatusInfo output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref output;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_GetDesktopCrossplayStatusInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GetDesktopCrossplayStatusInfoInternal()
    {
      Il2CppClassPointerStore<GetDesktopCrossplayStatusInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (GetDesktopCrossplayStatusInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfoInternal>.NativeClassPtr);
      GetDesktopCrossplayStatusInfoInternal.NativeFieldInfoPtr_m_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfoInternal>.NativeClassPtr, nameof (m_Status));
      GetDesktopCrossplayStatusInfoInternal.NativeFieldInfoPtr_m_ServiceInitResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfoInternal>.NativeClassPtr, nameof (m_ServiceInitResult));
      GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_get_Status_Public_get_DesktopCrossplayStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfoInternal>.NativeClassPtr, 100674643);
      GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_set_Status_Public_set_Void_DesktopCrossplayStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfoInternal>.NativeClassPtr, 100674644);
      GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_get_ServiceInitResult_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfoInternal>.NativeClassPtr, 100674645);
      GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_set_ServiceInitResult_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfoInternal>.NativeClassPtr, 100674646);
      GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_GetDesktopCrossplayStatusInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfoInternal>.NativeClassPtr, 100674647);
      GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_GetDesktopCrossplayStatusInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfoInternal>.NativeClassPtr, 100674648);
      GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfoInternal>.NativeClassPtr, 100674649);
      GetDesktopCrossplayStatusInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_GetDesktopCrossplayStatusInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfoInternal>.NativeClassPtr, 100674650);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
