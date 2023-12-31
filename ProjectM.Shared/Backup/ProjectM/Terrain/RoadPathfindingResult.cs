// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.RoadPathfindingResult
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RoadPathfindingResult
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodePosition;
    [FieldOffset(0)]
    public float3 NodePosition;

    static RoadPathfindingResult()
    {
      Il2CppClassPointerStore<RoadPathfindingResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (RoadPathfindingResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadPathfindingResult>.NativeClassPtr);
      RoadPathfindingResult.NativeFieldInfoPtr_NodePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfindingResult>.NativeClassPtr, nameof (NodePosition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoadPathfindingResult>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
