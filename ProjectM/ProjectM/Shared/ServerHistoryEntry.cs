// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ServerHistoryEntry
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  public class ServerHistoryEntry : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectAddress;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideInContinue;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryPort;
    private static readonly System.IntPtr NativeFieldInfoPtr_UTCLastPlayed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Version;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerHistoryEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerHistoryEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerHistoryEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerHistoryEntry()
    {
      Il2CppClassPointerStore<ServerHistoryEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Shared", nameof (ServerHistoryEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerHistoryEntry>.NativeClassPtr);
      ServerHistoryEntry.NativeFieldInfoPtr_SessionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHistoryEntry>.NativeClassPtr, nameof (SessionGUID));
      ServerHistoryEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHistoryEntry>.NativeClassPtr, nameof (Name));
      ServerHistoryEntry.NativeFieldInfoPtr_ConnectAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHistoryEntry>.NativeClassPtr, nameof (ConnectAddress));
      ServerHistoryEntry.NativeFieldInfoPtr_HideInContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHistoryEntry>.NativeClassPtr, nameof (HideInContinue));
      ServerHistoryEntry.NativeFieldInfoPtr_QueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHistoryEntry>.NativeClassPtr, nameof (QueryPort));
      ServerHistoryEntry.NativeFieldInfoPtr_UTCLastPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHistoryEntry>.NativeClassPtr, nameof (UTCLastPlayed));
      ServerHistoryEntry.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHistoryEntry>.NativeClassPtr, nameof (Version));
      ServerHistoryEntry.NativeFieldInfoPtr_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerHistoryEntry>.NativeClassPtr, nameof (UserId));
      ServerHistoryEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerHistoryEntry>.NativeClassPtr, 100688762);
    }

    public ServerHistoryEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string SessionGUID
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_SessionGUID)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_SessionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ConnectAddress ConnectAddress
    {
      get
      {
        return *(ConnectAddress*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_ConnectAddress));
      }
      [param: In] set
      {
        *(ConnectAddress*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_ConnectAddress)) = value;
      }
    }

    public unsafe bool HideInContinue
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_HideInContinue));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_HideInContinue)) = value;
      }
    }

    public unsafe ushort QueryPort
    {
      get
      {
        return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_QueryPort));
      }
      [param: In] set
      {
        *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_QueryPort)) = value;
      }
    }

    public unsafe long UTCLastPlayed
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_UTCLastPlayed));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_UTCLastPlayed)) = value;
      }
    }

    public unsafe int Version
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_Version));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_Version)) = value;
      }
    }

    public unsafe ulong UserId
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_UserId));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerHistoryEntry.NativeFieldInfoPtr_UserId)) = value;
      }
    }
  }
}
