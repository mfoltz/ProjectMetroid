// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.RoofTileVariations
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Roofs
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RoofTileVariations
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabRotationOffset;
    [FieldOffset(0)]
    public PrefabGUID PrefabGUID;
    [FieldOffset(4)]
    public OrthogonalRotation PrefabRotationOffset;

    static RoofTileVariations()
    {
      Il2CppClassPointerStore<RoofTileVariations>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Roofs", nameof (RoofTileVariations));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoofTileVariations>.NativeClassPtr);
      RoofTileVariations.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTileVariations>.NativeClassPtr, nameof (PrefabGUID));
      RoofTileVariations.NativeFieldInfoPtr_PrefabRotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTileVariations>.NativeClassPtr, nameof (PrefabRotationOffset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoofTileVariations>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
