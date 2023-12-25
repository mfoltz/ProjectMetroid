// Decompiled with JetBrains decompiler
// Type: ProjectM.Auth.FriendSession
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Auth
{
  public sealed class FriendSession : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserName;

    static FriendSession()
    {
      Il2CppClassPointerStore<FriendSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Auth", nameof (FriendSession));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendSession>.NativeClassPtr);
      FriendSession.NativeFieldInfoPtr_SessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendSession>.NativeClassPtr, nameof (SessionId));
      FriendSession.NativeFieldInfoPtr_UserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendSession>.NativeClassPtr, nameof (UserName));
    }

    public FriendSession(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public FriendSession()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FriendSession>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendSession>.NativeClassPtr, data));
    }

    public unsafe string SessionId
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FriendSession.NativeFieldInfoPtr_SessionId)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FriendSession.NativeFieldInfoPtr_SessionId), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string UserName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FriendSession.NativeFieldInfoPtr_UserName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FriendSession.NativeFieldInfoPtr_UserName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
