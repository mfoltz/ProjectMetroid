// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ServerListDataEntry
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
  public class ServerListDataEntry : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Address;
    private static readonly System.IntPtr NativeFieldInfoPtr_Port;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285499, XrefRangeEnd = 1285500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerListDataEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerListDataEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListDataEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerListDataEntry()
    {
      Il2CppClassPointerStore<ServerListDataEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ServerListDataEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListDataEntry>.NativeClassPtr);
      ServerListDataEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListDataEntry>.NativeClassPtr, nameof (Name));
      ServerListDataEntry.NativeFieldInfoPtr_Address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListDataEntry>.NativeClassPtr, nameof (Address));
      ServerListDataEntry.NativeFieldInfoPtr_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListDataEntry>.NativeClassPtr, nameof (Port));
      ServerListDataEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListDataEntry>.NativeClassPtr, 100669399);
    }

    public ServerListDataEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListDataEntry.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListDataEntry.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Address
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListDataEntry.NativeFieldInfoPtr_Address)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListDataEntry.NativeFieldInfoPtr_Address), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int Port
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListDataEntry.NativeFieldInfoPtr_Port));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListDataEntry.NativeFieldInfoPtr_Port)) = value;
      }
    }
  }
}
