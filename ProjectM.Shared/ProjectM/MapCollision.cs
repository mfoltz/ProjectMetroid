// Decompiled with JetBrains decompiler
// Type: ProjectM.MapCollision
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapCollision
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RADIUS;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollidesAgainstMapFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_Result;
    [FieldOffset(0)]
    public float Radius;
    [FieldOffset(4)]
    public MapCollisionFlags CollidesAgainstMapFlags;
    [FieldOffset(8)]
    public MapCollisionResult Result;

    static MapCollision()
    {
      Il2CppClassPointerStore<MapCollision>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapCollision));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapCollision>.NativeClassPtr);
      MapCollision.NativeFieldInfoPtr_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollision>.NativeClassPtr, nameof (RADIUS));
      MapCollision.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollision>.NativeClassPtr, nameof (Radius));
      MapCollision.NativeFieldInfoPtr_CollidesAgainstMapFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollision>.NativeClassPtr, nameof (CollidesAgainstMapFlags));
      MapCollision.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollision>.NativeClassPtr, nameof (Result));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapCollision>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe float RADIUS
    {
      get
      {
        float radius;
        IL2CPP.il2cpp_field_static_get_value(MapCollision.NativeFieldInfoPtr_RADIUS, (void*) &radius);
        return radius;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapCollision.NativeFieldInfoPtr_RADIUS, (void*) &value);
      }
    }
  }
}
