// Decompiled with JetBrains decompiler
// Type: ProjectM.DynamicWorldVFXSpawnEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DynamicWorldVFXSpawnEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Spawner;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldPos;
    private static readonly System.IntPtr NativeFieldInfoPtr_ManagerIndex;
    [FieldOffset(0)]
    public Entity Spawner;
    [FieldOffset(8)]
    public float3 WorldPos;
    [FieldOffset(20)]
    public int ManagerIndex;

    static DynamicWorldVFXSpawnEvent()
    {
      Il2CppClassPointerStore<DynamicWorldVFXSpawnEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DynamicWorldVFXSpawnEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicWorldVFXSpawnEvent>.NativeClassPtr);
      DynamicWorldVFXSpawnEvent.NativeFieldInfoPtr_Spawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicWorldVFXSpawnEvent>.NativeClassPtr, nameof (Spawner));
      DynamicWorldVFXSpawnEvent.NativeFieldInfoPtr_WorldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicWorldVFXSpawnEvent>.NativeClassPtr, nameof (WorldPos));
      DynamicWorldVFXSpawnEvent.NativeFieldInfoPtr_ManagerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicWorldVFXSpawnEvent>.NativeClassPtr, nameof (ManagerIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DynamicWorldVFXSpawnEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
