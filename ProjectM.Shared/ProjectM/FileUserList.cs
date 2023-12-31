// Decompiled with JetBrains decompiler
// Type: ProjectM.FileUserList
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Networking;

#nullable disable
namespace ProjectM
{
  public class FileUserList : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Set;
    private static readonly System.IntPtr NativeFieldInfoPtr__DefaultFileInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalFileInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr__WebRequest;
    private static readonly System.IntPtr NativeFieldInfoPtr__RequestFailCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__NextRefreshTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__MinRefreshTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__SourceType;
    private static readonly System.IntPtr NativeFieldInfoPtr__RequestURL;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSourceType_Private_UserListSourceType_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsTimeForRefresh_Private_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshLocal_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshURL_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRequest_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessContent_Private_Int32_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 734612, RefRangeEnd = 734618, XrefRangeStart = 734560, XrefRangeEnd = 734612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FileUserList(string fileOrUrl, float minRefreshTime = 60f)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileUserList>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fileOrUrl);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minRefreshTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734618, XrefRangeEnd = 734625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UserListSourceType GetSourceType(string fileName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fileName);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr_GetSourceType_Private_UserListSourceType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UserListSourceType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734625, XrefRangeEnd = 734626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsTimeForRefresh(bool forceRefresh)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &forceRefresh;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr_IsTimeForRefresh_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 734639, RefRangeEnd = 734647, XrefRangeStart = 734626, XrefRangeEnd = 734639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Refresh(bool forceRefresh = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &forceRefresh;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr_Refresh_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 734671, RefRangeEnd = 734673, XrefRangeStart = 734647, XrefRangeEnd = 734671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshLocal(bool forceRefresh)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &forceRefresh;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr_RefreshLocal_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734673, XrefRangeEnd = 734685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshURL(bool forceRefresh)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &forceRefresh;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr_RefreshURL_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 734741, RefRangeEnd = 734744, XrefRangeStart = 734685, XrefRangeEnd = 734741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateRequest()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr_UpdateRequest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 734765, RefRangeEnd = 734768, XrefRangeStart = 734744, XrefRangeEnd = 734765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int ProcessContent(string rawContent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(rawContent);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr_ProcessContent_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 734821, RefRangeEnd = 734826, XrefRangeStart = 734768, XrefRangeEnd = 734821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Save()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 734830, RefRangeEnd = 734831, XrefRangeStart = 734826, XrefRangeEnd = 734830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Add(ulong item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &item;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr_Add_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 734835, RefRangeEnd = 734837, XrefRangeStart = 734831, XrefRangeEnd = 734835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Remove(ulong item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &item;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr_Remove_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 734841, RefRangeEnd = 734850, XrefRangeStart = 734837, XrefRangeEnd = 734841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Contains(ulong item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &item;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr_Contains_Public_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 734854, RefRangeEnd = 734857, XrefRangeStart = 734850, XrefRangeEnd = 734854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator<ulong> GetEnumerator()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator<ulong>) null : new IEnumerator<ulong>(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 734854, RefRangeEnd = 734857, XrefRangeStart = 734854, XrefRangeEnd = 734857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FileUserList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static FileUserList()
    {
      Il2CppClassPointerStore<FileUserList>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FileUserList));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileUserList>.NativeClassPtr);
      FileUserList.NativeFieldInfoPtr__Set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, nameof (_Set));
      FileUserList.NativeFieldInfoPtr__DefaultFileInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, nameof (_DefaultFileInfo));
      FileUserList.NativeFieldInfoPtr__LocalFileInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, nameof (_LocalFileInfo));
      FileUserList.NativeFieldInfoPtr__WebRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, nameof (_WebRequest));
      FileUserList.NativeFieldInfoPtr__RequestFailCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, nameof (_RequestFailCount));
      FileUserList.NativeFieldInfoPtr__NextRefreshTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, nameof (_NextRefreshTime));
      FileUserList.NativeFieldInfoPtr__MinRefreshTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, nameof (_MinRefreshTime));
      FileUserList.NativeFieldInfoPtr__SourceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, nameof (_SourceType));
      FileUserList.NativeFieldInfoPtr__RequestURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, nameof (_RequestURL));
      FileUserList.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664877);
      FileUserList.NativeMethodInfoPtr_GetSourceType_Private_UserListSourceType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664878);
      FileUserList.NativeMethodInfoPtr_IsTimeForRefresh_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664879);
      FileUserList.NativeMethodInfoPtr_Refresh_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664880);
      FileUserList.NativeMethodInfoPtr_RefreshLocal_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664881);
      FileUserList.NativeMethodInfoPtr_RefreshURL_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664882);
      FileUserList.NativeMethodInfoPtr_UpdateRequest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664883);
      FileUserList.NativeMethodInfoPtr_ProcessContent_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664884);
      FileUserList.NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664885);
      FileUserList.NativeMethodInfoPtr_Add_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664886);
      FileUserList.NativeMethodInfoPtr_Remove_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664887);
      FileUserList.NativeMethodInfoPtr_Contains_Public_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664888);
      FileUserList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664889);
      FileUserList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, 100664890);
    }

    public FileUserList(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HashSet<ulong> _Set
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__Set));
        return pointer == System.IntPtr.Zero ? (HashSet<ulong>) null : new HashSet<ulong>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__Set), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FileInfo _DefaultFileInfo
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__DefaultFileInfo));
        return pointer == System.IntPtr.Zero ? (FileInfo) null : new FileInfo(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__DefaultFileInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FileInfo _LocalFileInfo
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__LocalFileInfo));
        return pointer == System.IntPtr.Zero ? (FileInfo) null : new FileInfo(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__LocalFileInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityWebRequest _WebRequest
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__WebRequest));
        return pointer == System.IntPtr.Zero ? (UnityWebRequest) null : new UnityWebRequest(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__WebRequest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _RequestFailCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__RequestFailCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__RequestFailCount)) = value;
      }
    }

    public unsafe float _NextRefreshTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__NextRefreshTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__NextRefreshTime)) = value;
      }
    }

    public unsafe float _MinRefreshTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__MinRefreshTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__MinRefreshTime)) = value;
      }
    }

    public unsafe UserListSourceType _SourceType
    {
      get
      {
        return *(UserListSourceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__SourceType));
      }
      [param: In] set
      {
        *(UserListSourceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__SourceType)) = value;
      }
    }

    public unsafe string _RequestURL
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__RequestURL)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FileUserList.NativeFieldInfoPtr__RequestURL), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [ObfuscatedName("ProjectM.FileUserList/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__17_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Save_b__17_0_Internal_String_UInt64_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileUserList.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FileUserList.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _Save_b__17_0(ulong s)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &s;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(FileUserList.__c.NativeMethodInfoPtr__Save_b__17_0_Internal_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<FileUserList.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileUserList>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileUserList.__c>.NativeClassPtr);
        FileUserList.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUserList.__c>.NativeClassPtr, "<>9");
        FileUserList.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileUserList.__c>.NativeClassPtr, "<>9__17_0");
        FileUserList.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList.__c>.NativeClassPtr, 100664892);
        FileUserList.__c.NativeMethodInfoPtr__Save_b__17_0_Internal_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileUserList.__c>.NativeClassPtr, 100664893);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe FileUserList.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(FileUserList.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (FileUserList.__c) null : new FileUserList.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(FileUserList.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ulong, string> __9__17_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(FileUserList.__c.NativeFieldInfoPtr___9__17_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ulong, string>) null : new Il2CppSystem.Func<ulong, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(FileUserList.__c.NativeFieldInfoPtr___9__17_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
