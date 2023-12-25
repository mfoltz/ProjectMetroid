// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.PresenceModification
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Presence
{
  public sealed class PresenceModification : Handle
  {
    private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationDatarecordidApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationDeletedataApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationJoininfoMaxLength;
    private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationSetdataApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationSetjoininfoApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationSetrawrichtextApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationSetstatusApiLatest;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_DeleteData_Public_Result_byref_PresenceModificationDeleteDataOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Result_byref_PresenceModificationSetDataOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetJoinInfo_Public_Result_byref_PresenceModificationSetJoinInfoOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetRawRichText_Public_Result_byref_PresenceModificationSetRawRichTextOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetStatus_Public_Result_byref_PresenceModificationSetStatusOptions_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PresenceModification()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948787, XrefRangeEnd = 948800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result DeleteData(ref PresenceModificationDeleteDataOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr_DeleteData_Public_Result_byref_PresenceModificationDeleteDataOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948800, XrefRangeEnd = 948801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Release()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948801, XrefRangeEnd = 948814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetData(ref PresenceModificationSetDataOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr_SetData_Public_Result_byref_PresenceModificationSetDataOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948814, XrefRangeEnd = 948825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetJoinInfo(ref PresenceModificationSetJoinInfoOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr_SetJoinInfo_Public_Result_byref_PresenceModificationSetJoinInfoOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948825, XrefRangeEnd = 948836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetRawRichText(
      ref PresenceModificationSetRawRichTextOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr_SetRawRichText_Public_Result_byref_PresenceModificationSetRawRichTextOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948836, XrefRangeEnd = 948843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetStatus(ref PresenceModificationSetStatusOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref options;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr_SetStatus_Public_Result_byref_PresenceModificationSetStatusOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PresenceModification()
    {
      Il2CppClassPointerStore<PresenceModification>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Presence", nameof (PresenceModification));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr);
      PresenceModification.NativeFieldInfoPtr_PresencemodificationDatarecordidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationDatarecordidApiLatest));
      PresenceModification.NativeFieldInfoPtr_PresencemodificationDeletedataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationDeletedataApiLatest));
      PresenceModification.NativeFieldInfoPtr_PresencemodificationJoininfoMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationJoininfoMaxLength));
      PresenceModification.NativeFieldInfoPtr_PresencemodificationSetdataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationSetdataApiLatest));
      PresenceModification.NativeFieldInfoPtr_PresencemodificationSetjoininfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationSetjoininfoApiLatest));
      PresenceModification.NativeFieldInfoPtr_PresencemodificationSetrawrichtextApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationSetrawrichtextApiLatest));
      PresenceModification.NativeFieldInfoPtr_PresencemodificationSetstatusApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationSetstatusApiLatest));
      PresenceModification.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100668249);
      PresenceModification.NativeMethodInfoPtr_DeleteData_Public_Result_byref_PresenceModificationDeleteDataOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100668251);
      PresenceModification.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100668252);
      PresenceModification.NativeMethodInfoPtr_SetData_Public_Result_byref_PresenceModificationSetDataOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100668253);
      PresenceModification.NativeMethodInfoPtr_SetJoinInfo_Public_Result_byref_PresenceModificationSetJoinInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100668254);
      PresenceModification.NativeMethodInfoPtr_SetRawRichText_Public_Result_byref_PresenceModificationSetRawRichTextOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100668255);
      PresenceModification.NativeMethodInfoPtr_SetStatus_Public_Result_byref_PresenceModificationSetStatusOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100668256);
    }

    public PresenceModification(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int PresencemodificationDatarecordidApiLatest
    {
      get
      {
        int datarecordidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationDatarecordidApiLatest, (void*) &datarecordidApiLatest);
        return datarecordidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationDatarecordidApiLatest, (void*) &value);
      }
    }

    public static unsafe int PresencemodificationDeletedataApiLatest
    {
      get
      {
        int deletedataApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationDeletedataApiLatest, (void*) &deletedataApiLatest);
        return deletedataApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationDeletedataApiLatest, (void*) &value);
      }
    }

    public static unsafe int PresencemodificationJoininfoMaxLength
    {
      get
      {
        int joininfoMaxLength;
        IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationJoininfoMaxLength, (void*) &joininfoMaxLength);
        return joininfoMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationJoininfoMaxLength, (void*) &value);
      }
    }

    public static unsafe int PresencemodificationSetdataApiLatest
    {
      get
      {
        int setdataApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetdataApiLatest, (void*) &setdataApiLatest);
        return setdataApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetdataApiLatest, (void*) &value);
      }
    }

    public static unsafe int PresencemodificationSetjoininfoApiLatest
    {
      get
      {
        int setjoininfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetjoininfoApiLatest, (void*) &setjoininfoApiLatest);
        return setjoininfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetjoininfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int PresencemodificationSetrawrichtextApiLatest
    {
      get
      {
        int setrawrichtextApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetrawrichtextApiLatest, (void*) &setrawrichtextApiLatest);
        return setrawrichtextApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetrawrichtextApiLatest, (void*) &value);
      }
    }

    public static unsafe int PresencemodificationSetstatusApiLatest
    {
      get
      {
        int setstatusApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetstatusApiLatest, (void*) &setstatusApiLatest);
        return setstatusApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetstatusApiLatest, (void*) &value);
      }
    }
  }
}
