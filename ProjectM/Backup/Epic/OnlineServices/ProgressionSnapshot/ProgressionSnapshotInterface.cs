// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.ProgressionSnapshot.ProgressionSnapshotInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.ProgressionSnapshot
{
  public sealed class ProgressionSnapshotInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AddprogressionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_BeginsnapshotApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeletesnapshotApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndsnapshotApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_InvalidProgressionsnapshotid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubmitsnapshotApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddProgression_Public_Result_byref_AddProgressionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginSnapshot_Public_Result_byref_BeginSnapshotOptions_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeleteSnapshot_Public_Void_byref_DeleteSnapshotOptions_Object_OnDeleteSnapshotCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndSnapshot_Public_Result_byref_EndSnapshotOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SubmitSnapshot_Public_Void_byref_SubmitSnapshotOptions_Object_OnSubmitSnapshotCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDeleteSnapshotCallbackInternalImplementation_Internal_Static_Void_byref_DeleteSnapshotCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSubmitSnapshotCallbackInternalImplementation_Internal_Static_Void_byref_SubmitSnapshotCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProgressionSnapshotInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947909, XrefRangeEnd = 947917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result AddProgression(ref AddProgressionOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_AddProgression_Public_Result_byref_AddProgressionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947917, XrefRangeEnd = 947928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result BeginSnapshot(ref BeginSnapshotOptions options, out uint outSnapshotId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outSnapshotId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_BeginSnapshot_Public_Result_byref_BeginSnapshotOptions_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947928, XrefRangeEnd = 947947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeleteSnapshot(
      ref DeleteSnapshotOptions options,
      Il2CppSystem.Object clientData,
      OnDeleteSnapshotCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_DeleteSnapshot_Public_Void_byref_DeleteSnapshotOptions_Object_OnDeleteSnapshotCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947947, XrefRangeEnd = 947955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result EndSnapshot(ref EndSnapshotOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_EndSnapshot_Public_Result_byref_EndSnapshotOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947955, XrefRangeEnd = 947974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SubmitSnapshot(
      ref SubmitSnapshotOptions options,
      Il2CppSystem.Object clientData,
      OnSubmitSnapshotCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_SubmitSnapshot_Public_Void_byref_SubmitSnapshotOptions_Object_OnSubmitSnapshotCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947974, XrefRangeEnd = 947981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnDeleteSnapshotCallbackInternalImplementation(
      ref DeleteSnapshotCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_OnDeleteSnapshotCallbackInternalImplementation_Internal_Static_Void_byref_DeleteSnapshotCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947981, XrefRangeEnd = 947988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnSubmitSnapshotCallbackInternalImplementation(
      ref SubmitSnapshotCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_OnSubmitSnapshotCallbackInternalImplementation_Internal_Static_Void_byref_SubmitSnapshotCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProgressionSnapshotInterface()
    {
      Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.ProgressionSnapshot", nameof (ProgressionSnapshotInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr);
      ProgressionSnapshotInterface.NativeFieldInfoPtr_AddprogressionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, nameof (AddprogressionApiLatest));
      ProgressionSnapshotInterface.NativeFieldInfoPtr_BeginsnapshotApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, nameof (BeginsnapshotApiLatest));
      ProgressionSnapshotInterface.NativeFieldInfoPtr_DeletesnapshotApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, nameof (DeletesnapshotApiLatest));
      ProgressionSnapshotInterface.NativeFieldInfoPtr_EndsnapshotApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, nameof (EndsnapshotApiLatest));
      ProgressionSnapshotInterface.NativeFieldInfoPtr_InvalidProgressionsnapshotid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, nameof (InvalidProgressionsnapshotid));
      ProgressionSnapshotInterface.NativeFieldInfoPtr_SubmitsnapshotApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, nameof (SubmitsnapshotApiLatest));
      ProgressionSnapshotInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100668035);
      ProgressionSnapshotInterface.NativeMethodInfoPtr_AddProgression_Public_Result_byref_AddProgressionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100668037);
      ProgressionSnapshotInterface.NativeMethodInfoPtr_BeginSnapshot_Public_Result_byref_BeginSnapshotOptions_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100668038);
      ProgressionSnapshotInterface.NativeMethodInfoPtr_DeleteSnapshot_Public_Void_byref_DeleteSnapshotOptions_Object_OnDeleteSnapshotCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100668039);
      ProgressionSnapshotInterface.NativeMethodInfoPtr_EndSnapshot_Public_Result_byref_EndSnapshotOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100668040);
      ProgressionSnapshotInterface.NativeMethodInfoPtr_SubmitSnapshot_Public_Void_byref_SubmitSnapshotOptions_Object_OnSubmitSnapshotCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100668041);
      ProgressionSnapshotInterface.NativeMethodInfoPtr_OnDeleteSnapshotCallbackInternalImplementation_Internal_Static_Void_byref_DeleteSnapshotCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100668042);
      ProgressionSnapshotInterface.NativeMethodInfoPtr_OnSubmitSnapshotCallbackInternalImplementation_Internal_Static_Void_byref_SubmitSnapshotCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100668043);
    }

    public ProgressionSnapshotInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AddprogressionApiLatest
    {
      get
      {
        int addprogressionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_AddprogressionApiLatest, (void*) &addprogressionApiLatest);
        return addprogressionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_AddprogressionApiLatest, (void*) &value);
      }
    }

    public static unsafe int BeginsnapshotApiLatest
    {
      get
      {
        int beginsnapshotApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_BeginsnapshotApiLatest, (void*) &beginsnapshotApiLatest);
        return beginsnapshotApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_BeginsnapshotApiLatest, (void*) &value);
      }
    }

    public static unsafe int DeletesnapshotApiLatest
    {
      get
      {
        int deletesnapshotApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_DeletesnapshotApiLatest, (void*) &deletesnapshotApiLatest);
        return deletesnapshotApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_DeletesnapshotApiLatest, (void*) &value);
      }
    }

    public static unsafe int EndsnapshotApiLatest
    {
      get
      {
        int endsnapshotApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_EndsnapshotApiLatest, (void*) &endsnapshotApiLatest);
        return endsnapshotApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_EndsnapshotApiLatest, (void*) &value);
      }
    }

    public static unsafe int InvalidProgressionsnapshotid
    {
      get
      {
        int progressionsnapshotid;
        IL2CPP.il2cpp_field_static_get_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_InvalidProgressionsnapshotid, (void*) &progressionsnapshotid);
        return progressionsnapshotid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_InvalidProgressionsnapshotid, (void*) &value);
      }
    }

    public static unsafe int SubmitsnapshotApiLatest
    {
      get
      {
        int submitsnapshotApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_SubmitsnapshotApiLatest, (void*) &submitsnapshotApiLatest);
        return submitsnapshotApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_SubmitsnapshotApiLatest, (void*) &value);
      }
    }
  }
}
