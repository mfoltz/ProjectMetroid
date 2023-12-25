// Decompiled with JetBrains decompiler
// Type: ProjectM.Auth.ServerListEntryData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ProjectM.Network;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Auth
{
  [Serializable]
  public sealed class ServerListEntryData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsRecommended;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasIP;
    private static readonly System.IntPtr NativeFieldInfoPtr_IpAddressInt;
    private static readonly System.IntPtr NativeFieldInfoPtr_IpAddress;
    private static readonly System.IntPtr NativeFieldInfoPtr_GamePort;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryPort;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentPlayers;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPlayers;
    private static readonly System.IntPtr NativeFieldInfoPtr_FriendsPlaying;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsPasswordProtected;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsFavorited;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDedicated;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ping;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExtendedData;
    private static readonly System.IntPtr NativeFieldInfoPtr_Category;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSecure;
    private static readonly System.IntPtr NativeFieldInfoPtr_Tags;
    private static readonly System.IntPtr NativeFieldInfoPtr_SteamVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivityLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsHardCore;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviouslyPlayed;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasStandardSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsOld;
    private static readonly System.IntPtr NativeFieldInfoPtr_DebugData;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasScheduledWipes;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasScrambledVBloods;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOfficial_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsTrusted_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsBanned_Public_get_Boolean_0;

    public unsafe bool IsOfficial
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 1137066, RefRangeEnd = 1137072, XrefRangeStart = 1137066, XrefRangeEnd = 1137066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListEntryData.NativeMethodInfoPtr_get_IsOfficial_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsTrusted
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 1137072, RefRangeEnd = 1137076, XrefRangeStart = 1137072, XrefRangeEnd = 1137072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListEntryData.NativeMethodInfoPtr_get_IsTrusted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsBanned
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListEntryData.NativeMethodInfoPtr_get_IsBanned_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static ServerListEntryData()
    {
      Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Auth", nameof (ServerListEntryData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr);
      ServerListEntryData.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (Priority));
      ServerListEntryData.NativeFieldInfoPtr_IsRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (IsRecommended));
      ServerListEntryData.NativeFieldInfoPtr_HasIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (HasIP));
      ServerListEntryData.NativeFieldInfoPtr_IpAddressInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (IpAddressInt));
      ServerListEntryData.NativeFieldInfoPtr_IpAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (IpAddress));
      ServerListEntryData.NativeFieldInfoPtr_GamePort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (GamePort));
      ServerListEntryData.NativeFieldInfoPtr_QueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (QueryPort));
      ServerListEntryData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (Name));
      ServerListEntryData.NativeFieldInfoPtr_GameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (GameMode));
      ServerListEntryData.NativeFieldInfoPtr_SessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (SessionId));
      ServerListEntryData.NativeFieldInfoPtr_CurrentPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (CurrentPlayers));
      ServerListEntryData.NativeFieldInfoPtr_MaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (MaxPlayers));
      ServerListEntryData.NativeFieldInfoPtr_FriendsPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (FriendsPlaying));
      ServerListEntryData.NativeFieldInfoPtr_IsPasswordProtected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (IsPasswordProtected));
      ServerListEntryData.NativeFieldInfoPtr_IsFavorited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (IsFavorited));
      ServerListEntryData.NativeFieldInfoPtr_IsDedicated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (IsDedicated));
      ServerListEntryData.NativeFieldInfoPtr_Ping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (Ping));
      ServerListEntryData.NativeFieldInfoPtr_ExtendedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (ExtendedData));
      ServerListEntryData.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (Category));
      ServerListEntryData.NativeFieldInfoPtr_IsSecure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (IsSecure));
      ServerListEntryData.NativeFieldInfoPtr_Tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (Tags));
      ServerListEntryData.NativeFieldInfoPtr_SteamVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (SteamVersion));
      ServerListEntryData.NativeFieldInfoPtr_ActivityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (ActivityLevel));
      ServerListEntryData.NativeFieldInfoPtr_IsHardCore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (IsHardCore));
      ServerListEntryData.NativeFieldInfoPtr_PreviouslyPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (PreviouslyPlayed));
      ServerListEntryData.NativeFieldInfoPtr_HasStandardSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (HasStandardSettings));
      ServerListEntryData.NativeFieldInfoPtr_ClanSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (ClanSize));
      ServerListEntryData.NativeFieldInfoPtr_IsOld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (IsOld));
      ServerListEntryData.NativeFieldInfoPtr_DebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (DebugData));
      ServerListEntryData.NativeFieldInfoPtr_HasScheduledWipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (HasScheduledWipes));
      ServerListEntryData.NativeFieldInfoPtr_HasScrambledVBloods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (HasScrambledVBloods));
      ServerListEntryData.NativeMethodInfoPtr_get_IsOfficial_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, 100690032);
      ServerListEntryData.NativeMethodInfoPtr_get_IsTrusted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, 100690033);
      ServerListEntryData.NativeMethodInfoPtr_get_IsBanned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, 100690034);
    }

    public ServerListEntryData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ServerListEntryData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, data));
    }

    public unsafe float Priority
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_Priority));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_Priority)) = value;
      }
    }

    public unsafe bool IsRecommended
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsRecommended));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsRecommended)) = value;
      }
    }

    public unsafe bool HasIP
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_HasIP));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_HasIP)) = value;
      }
    }

    public unsafe uint IpAddressInt
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IpAddressInt));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IpAddressInt)) = value;
      }
    }

    public unsafe string IpAddress
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IpAddress)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IpAddress), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ushort GamePort
    {
      get
      {
        return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_GamePort));
      }
      [param: In] set
      {
        *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_GamePort)) = value;
      }
    }

    public unsafe ushort QueryPort
    {
      get
      {
        return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_QueryPort));
      }
      [param: In] set
      {
        *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_QueryPort)) = value;
      }
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe GameModeType GameMode
    {
      get
      {
        return *(GameModeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_GameMode));
      }
      [param: In] set
      {
        *(GameModeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_GameMode)) = value;
      }
    }

    public unsafe string SessionId
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_SessionId)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_SessionId), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int CurrentPlayers
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_CurrentPlayers));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_CurrentPlayers)) = value;
      }
    }

    public unsafe int MaxPlayers
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_MaxPlayers));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_MaxPlayers)) = value;
      }
    }

    public unsafe string FriendsPlaying
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_FriendsPlaying)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_FriendsPlaying), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool IsPasswordProtected
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsPasswordProtected));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsPasswordProtected)) = value;
      }
    }

    public unsafe bool IsFavorited
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsFavorited));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsFavorited)) = value;
      }
    }

    public unsafe bool IsDedicated
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsDedicated));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsDedicated)) = value;
      }
    }

    public unsafe int Ping
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_Ping));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_Ping)) = value;
      }
    }

    public unsafe Nullable_Unboxed<ServerListExtendedData> ExtendedData
    {
      get
      {
        return *(Nullable_Unboxed<ServerListExtendedData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_ExtendedData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_ExtendedData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ServerListExtendedData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ServerCategory Category
    {
      get
      {
        return *(ServerCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_Category));
      }
      [param: In] set
      {
        *(ServerCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_Category)) = value;
      }
    }

    public unsafe bool IsSecure
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsSecure));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsSecure)) = value;
      }
    }

    public unsafe List<string> Tags
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_Tags));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_Tags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int SteamVersion
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_SteamVersion));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_SteamVersion)) = value;
      }
    }

    public unsafe ServerActivityLevel ActivityLevel
    {
      get
      {
        return *(ServerActivityLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_ActivityLevel));
      }
      [param: In] set
      {
        *(ServerActivityLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_ActivityLevel)) = value;
      }
    }

    public unsafe bool IsHardCore
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsHardCore));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsHardCore)) = value;
      }
    }

    public unsafe bool PreviouslyPlayed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_PreviouslyPlayed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_PreviouslyPlayed)) = value;
      }
    }

    public unsafe bool HasStandardSettings
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_HasStandardSettings));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_HasStandardSettings)) = value;
      }
    }

    public unsafe int ClanSize
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_ClanSize));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_ClanSize)) = value;
      }
    }

    public unsafe bool IsOld
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsOld));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_IsOld)) = value;
      }
    }

    public unsafe ServerListEntryData.WeightData DebugData
    {
      get
      {
        return *(ServerListEntryData.WeightData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_DebugData));
      }
      [param: In] set
      {
        *(ServerListEntryData.WeightData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_DebugData)) = value;
      }
    }

    public unsafe bool HasScheduledWipes
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_HasScheduledWipes));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_HasScheduledWipes)) = value;
      }
    }

    public unsafe bool HasScrambledVBloods
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_HasScrambledVBloods));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryData.NativeFieldInfoPtr_HasScrambledVBloods)) = value;
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct WeightData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_LatencyWeight;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlayerWeight;
      private static readonly System.IntPtr NativeFieldInfoPtr_ActivityWeight;
      private static readonly System.IntPtr NativeFieldInfoPtr_FriendsPlayingWeight;
      private static readonly System.IntPtr NativeFieldInfoPtr_PreviouslyPlayedWeight;
      private static readonly System.IntPtr NativeFieldInfoPtr_StandardSettingsWeight;
      [FieldOffset(0)]
      public float LatencyWeight;
      [FieldOffset(4)]
      public float PlayerWeight;
      [FieldOffset(8)]
      public float ActivityWeight;
      [FieldOffset(12)]
      public float FriendsPlayingWeight;
      [FieldOffset(16)]
      public float PreviouslyPlayedWeight;
      [FieldOffset(20)]
      public float StandardSettingsWeight;

      static WeightData()
      {
        Il2CppClassPointerStore<ServerListEntryData.WeightData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, nameof (WeightData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListEntryData.WeightData>.NativeClassPtr);
        ServerListEntryData.WeightData.NativeFieldInfoPtr_LatencyWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData.WeightData>.NativeClassPtr, nameof (LatencyWeight));
        ServerListEntryData.WeightData.NativeFieldInfoPtr_PlayerWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData.WeightData>.NativeClassPtr, nameof (PlayerWeight));
        ServerListEntryData.WeightData.NativeFieldInfoPtr_ActivityWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData.WeightData>.NativeClassPtr, nameof (ActivityWeight));
        ServerListEntryData.WeightData.NativeFieldInfoPtr_FriendsPlayingWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData.WeightData>.NativeClassPtr, nameof (FriendsPlayingWeight));
        ServerListEntryData.WeightData.NativeFieldInfoPtr_PreviouslyPlayedWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData.WeightData>.NativeClassPtr, nameof (PreviouslyPlayedWeight));
        ServerListEntryData.WeightData.NativeFieldInfoPtr_StandardSettingsWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryData.WeightData>.NativeClassPtr, nameof (StandardSettingsWeight));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerListEntryData.WeightData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
