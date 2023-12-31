// Decompiled with JetBrains decompiler
// Type: ProjectM.MapCollisionResult
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapCollisionResult
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionNormal;
    private static readonly System.IntPtr NativeFieldInfoPtr_Collision;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlreadyInCollision;
    [FieldOffset(0)]
    public float2 CollisionNormal;
    [FieldOffset(8)]
    public bool Collision;
    [FieldOffset(9)]
    public bool AlreadyInCollision;

    static MapCollisionResult()
    {
      Il2CppClassPointerStore<MapCollisionResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapCollisionResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapCollisionResult>.NativeClassPtr);
      MapCollisionResult.NativeFieldInfoPtr_CollisionNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionResult>.NativeClassPtr, nameof (CollisionNormal));
      MapCollisionResult.NativeFieldInfoPtr_Collision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionResult>.NativeClassPtr, nameof (Collision));
      MapCollisionResult.NativeFieldInfoPtr_AlreadyInCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionResult>.NativeClassPtr, nameof (AlreadyInCollision));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapCollisionResult>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
