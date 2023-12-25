// Decompiled with JetBrains decompiler
// Type: ProjectM.CurrentMapZone
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CurrentMapZone
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UserZoneEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldZone;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunk;
    [FieldOffset(0)]
    public Entity UserZoneEntity;
    [FieldOffset(8)]
    public Entity ZoneEntity;
    [FieldOffset(16)]
    public WorldZone WorldZone;
    [FieldOffset(20)]
    public TerrainChunk TerrainChunk;

    static CurrentMapZone()
    {
      Il2CppClassPointerStore<CurrentMapZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CurrentMapZone));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurrentMapZone>.NativeClassPtr);
      CurrentMapZone.NativeFieldInfoPtr_UserZoneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentMapZone>.NativeClassPtr, nameof (UserZoneEntity));
      CurrentMapZone.NativeFieldInfoPtr_ZoneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentMapZone>.NativeClassPtr, nameof (ZoneEntity));
      CurrentMapZone.NativeFieldInfoPtr_WorldZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentMapZone>.NativeClassPtr, nameof (WorldZone));
      CurrentMapZone.NativeFieldInfoPtr_TerrainChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentMapZone>.NativeClassPtr, nameof (TerrainChunk));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurrentMapZone>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
