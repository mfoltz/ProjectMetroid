// Decompiled with JetBrains decompiler
// Type: ProjectM.UserInfoElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UserInfoElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_FilteredName;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlatformId;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Voip_TimeSinceUpdate;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsConnected;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsAdmin;
    [FieldOffset(0)]
    public FixedString64 Name;
    [FieldOffset(64)]
    public FixedString64 FilteredName;
    [FieldOffset(128)]
    public ulong PlatformId;
    [FieldOffset(136)]
    public NetworkId NetworkId;
    [FieldOffset(144)]
    public float Voip_TimeSinceUpdate;
    [FieldOffset(148)]
    public bool IsConnected;
    [FieldOffset(149)]
    public bool IsAdmin;

    static UserInfoElement()
    {
      Il2CppClassPointerStore<UserInfoElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UserInfoElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserInfoElement>.NativeClassPtr);
      UserInfoElement.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoElement>.NativeClassPtr, nameof (Name));
      UserInfoElement.NativeFieldInfoPtr_FilteredName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoElement>.NativeClassPtr, nameof (FilteredName));
      UserInfoElement.NativeFieldInfoPtr_PlatformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoElement>.NativeClassPtr, nameof (PlatformId));
      UserInfoElement.NativeFieldInfoPtr_NetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoElement>.NativeClassPtr, nameof (NetworkId));
      UserInfoElement.NativeFieldInfoPtr_Voip_TimeSinceUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoElement>.NativeClassPtr, nameof (Voip_TimeSinceUpdate));
      UserInfoElement.NativeFieldInfoPtr_IsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoElement>.NativeClassPtr, nameof (IsConnected));
      UserInfoElement.NativeFieldInfoPtr_IsAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoElement>.NativeClassPtr, nameof (IsAdmin));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserInfoElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
