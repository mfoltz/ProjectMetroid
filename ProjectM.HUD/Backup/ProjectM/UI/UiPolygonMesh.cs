// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UiPolygonMesh
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Physics;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UiPolygonMesh
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Aabb;
    private static readonly System.IntPtr NativeFieldInfoPtr_MeshIndex;
    [FieldOffset(0)]
    public Aabb Aabb;
    [FieldOffset(24)]
    public int MeshIndex;

    static UiPolygonMesh()
    {
      Il2CppClassPointerStore<UiPolygonMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (UiPolygonMesh));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UiPolygonMesh>.NativeClassPtr);
      UiPolygonMesh.NativeFieldInfoPtr_Aabb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiPolygonMesh>.NativeClassPtr, nameof (Aabb));
      UiPolygonMesh.NativeFieldInfoPtr_MeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiPolygonMesh>.NativeClassPtr, nameof (MeshIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UiPolygonMesh>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
