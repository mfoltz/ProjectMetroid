// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.NetworkedPrefabData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NetworkedPrefabData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationOffset;
    [FieldOffset(0)]
    public PrefabGUID PrefabGUID;
    [FieldOffset(4)]
    public float3 PositionOffset;
    [FieldOffset(16)]
    public quaternion RotationOffset;

    static NetworkedPrefabData()
    {
      Il2CppClassPointerStore<NetworkedPrefabData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (NetworkedPrefabData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedPrefabData>.NativeClassPtr);
      NetworkedPrefabData.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedPrefabData>.NativeClassPtr, nameof (PrefabGUID));
      NetworkedPrefabData.NativeFieldInfoPtr_PositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedPrefabData>.NativeClassPtr, nameof (PositionOffset));
      NetworkedPrefabData.NativeFieldInfoPtr_RotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedPrefabData>.NativeClassPtr, nameof (RotationOffset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkedPrefabData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
