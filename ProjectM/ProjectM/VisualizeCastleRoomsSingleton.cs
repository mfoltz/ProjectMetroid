// Decompiled with JetBrains decompiler
// Type: ProjectM.VisualizeCastleRoomsSingleton
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VisualizeCastleRoomsSingleton
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Filter;
    [FieldOffset(0)]
    public NeighbourFilter Filter;

    static VisualizeCastleRoomsSingleton()
    {
      Il2CppClassPointerStore<VisualizeCastleRoomsSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VisualizeCastleRoomsSingleton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualizeCastleRoomsSingleton>.NativeClassPtr);
      VisualizeCastleRoomsSingleton.NativeFieldInfoPtr_Filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualizeCastleRoomsSingleton>.NativeClassPtr, nameof (Filter));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisualizeCastleRoomsSingleton>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
