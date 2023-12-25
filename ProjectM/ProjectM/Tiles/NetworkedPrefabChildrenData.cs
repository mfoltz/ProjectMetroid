// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.NetworkedPrefabChildrenData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NetworkedPrefabChildrenData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedChildren;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlySpawnChildren;
    [FieldOffset(0)]
    public BlobArray<NetworkedPrefabData> NetworkedChildren;
    [FieldOffset(8)]
    public bool OnlySpawnChildren;

    static NetworkedPrefabChildrenData()
    {
      Il2CppClassPointerStore<NetworkedPrefabChildrenData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (NetworkedPrefabChildrenData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedPrefabChildrenData>.NativeClassPtr);
      NetworkedPrefabChildrenData.NativeFieldInfoPtr_NetworkedChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedPrefabChildrenData>.NativeClassPtr, nameof (NetworkedChildren));
      NetworkedPrefabChildrenData.NativeFieldInfoPtr_OnlySpawnChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedPrefabChildrenData>.NativeClassPtr, nameof (OnlySpawnChildren));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkedPrefabChildrenData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
