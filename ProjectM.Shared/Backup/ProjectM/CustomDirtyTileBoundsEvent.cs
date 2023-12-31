// Decompiled with JetBrains decompiler
// Type: ProjectM.CustomDirtyTileBoundsEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CustomDirtyTileBoundsEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldBounds;
    [FieldOffset(0)]
    public TileType TileTypes;
    [FieldOffset(4)]
    public BoundsMinMax WorldBounds;

    static CustomDirtyTileBoundsEvent()
    {
      Il2CppClassPointerStore<CustomDirtyTileBoundsEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CustomDirtyTileBoundsEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomDirtyTileBoundsEvent>.NativeClassPtr);
      CustomDirtyTileBoundsEvent.NativeFieldInfoPtr_TileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomDirtyTileBoundsEvent>.NativeClassPtr, nameof (TileTypes));
      CustomDirtyTileBoundsEvent.NativeFieldInfoPtr_WorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomDirtyTileBoundsEvent>.NativeClassPtr, nameof (WorldBounds));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomDirtyTileBoundsEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
