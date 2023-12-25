// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_UserMapZoneElement
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_UserMapZoneElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IsChunkInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserZoneEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneStartChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneType;
    [FieldOffset(0)]
    public bool IsChunkInstance;
    [FieldOffset(4)]
    public NetworkId UserZoneEntity;
    [FieldOffset(12)]
    public TerrainChunk ZoneStartChunk;
    [FieldOffset(20)]
    public WorldZone ZoneType;

    static Snapshot_UserMapZoneElement()
    {
      Il2CppClassPointerStore<Snapshot_UserMapZoneElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_UserMapZoneElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_UserMapZoneElement>.NativeClassPtr);
      Snapshot_UserMapZoneElement.NativeFieldInfoPtr_IsChunkInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_UserMapZoneElement>.NativeClassPtr, nameof (IsChunkInstance));
      Snapshot_UserMapZoneElement.NativeFieldInfoPtr_UserZoneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_UserMapZoneElement>.NativeClassPtr, nameof (UserZoneEntity));
      Snapshot_UserMapZoneElement.NativeFieldInfoPtr_ZoneStartChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_UserMapZoneElement>.NativeClassPtr, nameof (ZoneStartChunk));
      Snapshot_UserMapZoneElement.NativeFieldInfoPtr_ZoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_UserMapZoneElement>.NativeClassPtr, nameof (ZoneType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_UserMapZoneElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
