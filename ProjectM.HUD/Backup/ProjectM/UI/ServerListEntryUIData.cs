// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ServerListEntryUIData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Auth;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public sealed class ServerListEntryUIData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsLoading;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsWrongVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsLAN;

    static ServerListEntryUIData()
    {
      Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ServerListEntryUIData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr);
      ServerListEntryUIData.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr, nameof (Data));
      ServerListEntryUIData.NativeFieldInfoPtr_IsLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr, nameof (IsLoading));
      ServerListEntryUIData.NativeFieldInfoPtr_IsWrongVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr, nameof (IsWrongVersion));
      ServerListEntryUIData.NativeFieldInfoPtr_IsLAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr, nameof (IsLAN));
    }

    public ServerListEntryUIData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ServerListEntryUIData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerListEntryUIData>.NativeClassPtr, data));
    }

    public ServerListEntryData Data
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryUIData.NativeFieldInfoPtr_Data);
        return new ServerListEntryData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryUIData.NativeFieldInfoPtr_Data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerListEntryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool IsLoading
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryUIData.NativeFieldInfoPtr_IsLoading));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryUIData.NativeFieldInfoPtr_IsLoading)) = value;
      }
    }

    public unsafe bool IsWrongVersion
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryUIData.NativeFieldInfoPtr_IsWrongVersion));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryUIData.NativeFieldInfoPtr_IsWrongVersion)) = value;
      }
    }

    public unsafe bool IsLAN
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryUIData.NativeFieldInfoPtr_IsLAN));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListEntryUIData.NativeFieldInfoPtr_IsLAN)) = value;
      }
    }
  }
}
