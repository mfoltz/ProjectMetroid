// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.GetDesktopCrossplayStatusInfo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GetDesktopCrossplayStatusInfo
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Status_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServiceInitResult_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Status_Public_get_DesktopCrossplayStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Status_Public_set_Void_DesktopCrossplayStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ServiceInitResult_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ServiceInitResult_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_GetDesktopCrossplayStatusInfoInternal_0;
    [FieldOffset(0)]
    public DesktopCrossplayStatus _Status_k__BackingField;
    [FieldOffset(4)]
    public int _ServiceInitResult_k__BackingField;

    public unsafe DesktopCrossplayStatus Status
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetDesktopCrossplayStatusInfo.NativeMethodInfoPtr_get_Status_Public_get_DesktopCrossplayStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DesktopCrossplayStatus*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetDesktopCrossplayStatusInfo.NativeMethodInfoPtr_set_Status_Public_set_Void_DesktopCrossplayStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int ServiceInitResult
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetDesktopCrossplayStatusInfo.NativeMethodInfoPtr_get_ServiceInitResult_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetDesktopCrossplayStatusInfo.NativeMethodInfoPtr_set_ServiceInitResult_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 971955, RefRangeEnd = 971956, XrefRangeStart = 971955, XrefRangeEnd = 971955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref GetDesktopCrossplayStatusInfoInternal other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetDesktopCrossplayStatusInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_GetDesktopCrossplayStatusInfoInternal_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GetDesktopCrossplayStatusInfo()
    {
      Il2CppClassPointerStore<GetDesktopCrossplayStatusInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (GetDesktopCrossplayStatusInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfo>.NativeClassPtr);
      GetDesktopCrossplayStatusInfo.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfo>.NativeClassPtr, "<Status>k__BackingField");
      GetDesktopCrossplayStatusInfo.NativeFieldInfoPtr__ServiceInitResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfo>.NativeClassPtr, "<ServiceInitResult>k__BackingField");
      GetDesktopCrossplayStatusInfo.NativeMethodInfoPtr_get_Status_Public_get_DesktopCrossplayStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfo>.NativeClassPtr, 100674638);
      GetDesktopCrossplayStatusInfo.NativeMethodInfoPtr_set_Status_Public_set_Void_DesktopCrossplayStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfo>.NativeClassPtr, 100674639);
      GetDesktopCrossplayStatusInfo.NativeMethodInfoPtr_get_ServiceInitResult_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfo>.NativeClassPtr, 100674640);
      GetDesktopCrossplayStatusInfo.NativeMethodInfoPtr_set_ServiceInitResult_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfo>.NativeClassPtr, 100674641);
      GetDesktopCrossplayStatusInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_GetDesktopCrossplayStatusInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfo>.NativeClassPtr, 100674642);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetDesktopCrossplayStatusInfo>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
