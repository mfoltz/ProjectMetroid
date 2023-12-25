// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ServerListFilterOptions
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public sealed class ServerListFilterOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EmptyServer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FullServer;
    private static readonly System.IntPtr NativeFieldInfoPtr_Dedicated;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScheduledWipes;
    private static readonly System.IntPtr NativeFieldInfoPtr_StandardSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_PasswordProtected;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousPlayed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FriendsPlaying;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxLatency;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_HardCoreSetting;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysIncludePreviouslyPlayedEvenThoughTheyHavePassword;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanSize;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ServerListFilterOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnlyNameChanged_Public_Boolean_ServerListFilterOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1284835, RefRangeEnd = 1284837, XrefRangeStart = 1284834, XrefRangeEnd = 1284835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(ServerListFilterOptions other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListFilterOptions.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ServerListFilterOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1284838, RefRangeEnd = 1284839, XrefRangeStart = 1284837, XrefRangeEnd = 1284838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool OnlyNameChanged(ServerListFilterOptions other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListFilterOptions.NativeMethodInfoPtr_OnlyNameChanged_Public_Boolean_ServerListFilterOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284839, XrefRangeEnd = 1284843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Equals(Il2CppSystem.Object obj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListFilterOptions.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284843, XrefRangeEnd = 1284844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListFilterOptions.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServerListFilterOptions()
    {
      Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ServerListFilterOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr);
      ServerListFilterOptions.NativeFieldInfoPtr_EmptyServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (EmptyServer));
      ServerListFilterOptions.NativeFieldInfoPtr_FullServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (FullServer));
      ServerListFilterOptions.NativeFieldInfoPtr_Dedicated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (Dedicated));
      ServerListFilterOptions.NativeFieldInfoPtr_ScheduledWipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (ScheduledWipes));
      ServerListFilterOptions.NativeFieldInfoPtr_StandardSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (StandardSettings));
      ServerListFilterOptions.NativeFieldInfoPtr_PasswordProtected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (PasswordProtected));
      ServerListFilterOptions.NativeFieldInfoPtr_PreviousPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (PreviousPlayed));
      ServerListFilterOptions.NativeFieldInfoPtr_FriendsPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (FriendsPlaying));
      ServerListFilterOptions.NativeFieldInfoPtr_MaxLatency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (MaxLatency));
      ServerListFilterOptions.NativeFieldInfoPtr_GameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (GameMode));
      ServerListFilterOptions.NativeFieldInfoPtr_HardCoreSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (HardCoreSetting));
      ServerListFilterOptions.NativeFieldInfoPtr_AlwaysIncludePreviouslyPlayedEvenThoughTheyHavePassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (AlwaysIncludePreviouslyPlayedEvenThoughTheyHavePassword));
      ServerListFilterOptions.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (Name));
      ServerListFilterOptions.NativeFieldInfoPtr_ClanSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, nameof (ClanSize));
      ServerListFilterOptions.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ServerListFilterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, 100669337);
      ServerListFilterOptions.NativeMethodInfoPtr_OnlyNameChanged_Public_Boolean_ServerListFilterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, 100669338);
      ServerListFilterOptions.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, 100669339);
      ServerListFilterOptions.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, 100669340);
    }

    public ServerListFilterOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ServerListFilterOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerListFilterOptions>.NativeClassPtr, data));
    }

    public unsafe FilterSetting EmptyServer
    {
      get
      {
        return *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_EmptyServer));
      }
      [param: In] set
      {
        *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_EmptyServer)) = value;
      }
    }

    public unsafe FilterSetting FullServer
    {
      get
      {
        return *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_FullServer));
      }
      [param: In] set
      {
        *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_FullServer)) = value;
      }
    }

    public unsafe FilterSetting Dedicated
    {
      get
      {
        return *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_Dedicated));
      }
      [param: In] set
      {
        *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_Dedicated)) = value;
      }
    }

    public unsafe FilterSetting ScheduledWipes
    {
      get
      {
        return *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_ScheduledWipes));
      }
      [param: In] set
      {
        *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_ScheduledWipes)) = value;
      }
    }

    public unsafe FilterSetting StandardSettings
    {
      get
      {
        return *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_StandardSettings));
      }
      [param: In] set
      {
        *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_StandardSettings)) = value;
      }
    }

    public unsafe FilterSetting PasswordProtected
    {
      get
      {
        return *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_PasswordProtected));
      }
      [param: In] set
      {
        *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_PasswordProtected)) = value;
      }
    }

    public unsafe FilterSetting PreviousPlayed
    {
      get
      {
        return *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_PreviousPlayed));
      }
      [param: In] set
      {
        *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_PreviousPlayed)) = value;
      }
    }

    public unsafe FilterSetting FriendsPlaying
    {
      get
      {
        return *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_FriendsPlaying));
      }
      [param: In] set
      {
        *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_FriendsPlaying)) = value;
      }
    }

    public unsafe int MaxLatency
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_MaxLatency));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_MaxLatency)) = value;
      }
    }

    public unsafe GameModeTypeFilter GameMode
    {
      get
      {
        return *(GameModeTypeFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_GameMode));
      }
      [param: In] set
      {
        *(GameModeTypeFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_GameMode)) = value;
      }
    }

    public unsafe FilterSetting HardCoreSetting
    {
      get
      {
        return *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_HardCoreSetting));
      }
      [param: In] set
      {
        *(FilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_HardCoreSetting)) = value;
      }
    }

    public unsafe bool AlwaysIncludePreviouslyPlayedEvenThoughTheyHavePassword
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_AlwaysIncludePreviouslyPlayedEvenThoughTheyHavePassword));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_AlwaysIncludePreviouslyPlayedEvenThoughTheyHavePassword)) = value;
      }
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ClanSizeFilterSetting ClanSize
    {
      get
      {
        return *(ClanSizeFilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_ClanSize));
      }
      [param: In] set
      {
        *(ClanSizeFilterSetting*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListFilterOptions.NativeFieldInfoPtr_ClanSize)) = value;
      }
    }
  }
}
