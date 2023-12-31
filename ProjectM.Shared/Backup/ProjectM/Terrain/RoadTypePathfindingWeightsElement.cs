// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.RoadTypePathfindingWeightsElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RoadTypePathfindingWeightsElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RoadTypeCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeightFactor;
    [FieldOffset(0)]
    public float WeightFactor;

    static RoadTypePathfindingWeightsElement()
    {
      Il2CppClassPointerStore<RoadTypePathfindingWeightsElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (RoadTypePathfindingWeightsElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadTypePathfindingWeightsElement>.NativeClassPtr);
      RoadTypePathfindingWeightsElement.NativeFieldInfoPtr_RoadTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadTypePathfindingWeightsElement>.NativeClassPtr, nameof (RoadTypeCount));
      RoadTypePathfindingWeightsElement.NativeFieldInfoPtr_WeightFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadTypePathfindingWeightsElement>.NativeClassPtr, nameof (WeightFactor));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoadTypePathfindingWeightsElement>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int RoadTypeCount
    {
      get
      {
        int roadTypeCount;
        IL2CPP.il2cpp_field_static_get_value(RoadTypePathfindingWeightsElement.NativeFieldInfoPtr_RoadTypeCount, (void*) &roadTypeCount);
        return roadTypeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RoadTypePathfindingWeightsElement.NativeFieldInfoPtr_RoadTypeCount, (void*) &value);
      }
    }
  }
}
