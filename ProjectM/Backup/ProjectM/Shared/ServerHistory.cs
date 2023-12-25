// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ServerHistory
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Auth;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  public class ServerHistory : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entries;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlatformId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FileName;
    private static readonly System.IntPtr NativeFieldInfoPtr_FilePath;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntries_Public_List_1_ServerHistoryEntry_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetServerHistory_Public_Static_Boolean_SteamPlatformSystem_byref_ServerHistory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddToHistory_Public_Static_Void_SteamPlatformSystem_ServerHistoryEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SessionExists_Public_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromHistory_Public_Void_SteamPlatformSystem_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1118971, RefRangeEnd = 1118976, XrefRangeStart = 1118956, XrefRangeEnd = 1118971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<ServerHistoryEntry> GetEntries(int version)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &version;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerHistory.NativeMethodInfoPtr_GetEntries_Public_List_1_ServerHistoryEntry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<ServerHistoryEntry>) null : new List<ServerHistoryEntry>(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1119048, RefRangeEnd = 1119052, XrefRangeStart = 1118976, XrefRangeEnd = 1119048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetServerHistory(
      SteamPlatformSystem steamPlatformSystem,
      out ServerHistory serverHistory)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) steamPlatformSystem);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ServerHistory.NativeMethodInfoPtr_TryGetServerHistory_Public_Static_Boolean_SteamPlatformSystem_byref_ServerHistory_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ServerHistory local = ref serverHistory;
      System.IntPtr pointer = zero;
      ServerHistory serverHistory1 = pointer == System.IntPtr.Zero ? (ServerHistory) null : new ServerHistory(pointer);
      local = serverHistory1;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1119096, RefRangeEnd = 1119097, XrefRangeStart = 1119052, XrefRangeEnd = 1119096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddToHistory(
      SteamPlatformSystem steamPlatformSystem,
      ServerHistoryEntry newEntry)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) steamPlatformSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newEntry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerHistory.NativeMethodInfoPtr_AddToHistory_Public_Static_Void_SteamPlatformSystem_ServerHistoryEntry_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1119111, RefRangeEnd = 1119112, XrefRangeStart = 1119097, XrefRangeEnd = 1119111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SessionExists(string entrySessionId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(entrySessionId);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerHistory.NativeMethodInfoPtr_SessionExists_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1119153, RefRangeEnd = 1119155, XrefRangeStart = 1119112, XrefRangeEnd = 1119153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveFromHistory(SteamPlatformSystem steamPlatformSystem, string sessionId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) steamPlatformSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sessionId);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerHistory.NativeMethodInfoPtr_RemoveFromHistory_Public_Void_SteamPlatformSystem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1119163, RefRangeEnd = 1119164, XrefRangeStart = 1119155, XrefRangeEnd = 1119163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerHistory()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerHistory>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerHistory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerHistory()
    {
      Il2CppClassPointerStore<ServerHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Shared", nameof (ServerHistory));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerHistory>.NativeClassPtr);
      ServerHistory.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHistory>.NativeClassPtr, nameof (Entries));
      ServerHistory.NativeFieldInfoPtr_PlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHistory>.NativeClassPtr, nameof (PlatformId));
      ServerHistory.NativeFieldInfoPtr_FileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHistory>.NativeClassPtr, nameof (FileName));
      ServerHistory.NativeFieldInfoPtr_FilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHistory>.NativeClassPtr, nameof (FilePath));
      ServerHistory.NativeMethodInfoPtr_GetEntries_Public_List_1_ServerHistoryEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHistory>.NativeClassPtr, 100688763);
      ServerHistory.NativeMethodInfoPtr_TryGetServerHistory_Public_Static_Boolean_SteamPlatformSystem_byref_ServerHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHistory>.NativeClassPtr, 100688764);
      ServerHistory.NativeMethodInfoPtr_AddToHistory_Public_Static_Void_SteamPlatformSystem_ServerHistoryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHistory>.NativeClassPtr, 100688765);
      ServerHistory.NativeMethodInfoPtr_SessionExists_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHistory>.NativeClassPtr, 100688766);
      ServerHistory.NativeMethodInfoPtr_RemoveFromHistory_Public_Void_SteamPlatformSystem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHistory>.NativeClassPtr, 100688767);
      ServerHistory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHistory>.NativeClassPtr, 100688768);
    }

    public ServerHistory(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<ServerHistoryEntry> Entries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistory.NativeFieldInfoPtr_Entries));
        return pointer == System.IntPtr.Zero ? (List<ServerHistoryEntry>) null : new List<ServerHistoryEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHistory.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ulong PlatformId
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistory.NativeFieldInfoPtr_PlatformId));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistory.NativeFieldInfoPtr_PlatformId)) = value;
      }
    }

    public static unsafe string FileName
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ServerHistory.NativeFieldInfoPtr_FileName, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerHistory.NativeFieldInfoPtr_FileName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string FilePath
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ServerHistory.NativeFieldInfoPtr_FilePath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerHistory.NativeFieldInfoPtr_FilePath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
