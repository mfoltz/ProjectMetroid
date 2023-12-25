// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.DestroyedEntity
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DestroyedEntity
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_UsersToSendTo;
    [FieldOffset(0)]
    public PrefabGUID PrefabGUID;
    [FieldOffset(4)]
    public NetworkId NetworkId;
    [FieldOffset(12)]
    public UserBitMask128 UsersToSendTo;

    static DestroyedEntity()
    {
      Il2CppClassPointerStore<DestroyedEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (DestroyedEntity));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyedEntity>.NativeClassPtr);
      DestroyedEntity.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyedEntity>.NativeClassPtr, nameof (PrefabGUID));
      DestroyedEntity.NativeFieldInfoPtr_NetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyedEntity>.NativeClassPtr, nameof (NetworkId));
      DestroyedEntity.NativeFieldInfoPtr_UsersToSendTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyedEntity>.NativeClassPtr, nameof (UsersToSendTo));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyedEntity>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
