// Decompiled with JetBrains decompiler
// Type: ProjectM.NewUnitTag
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NewUnitTag
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FollowerTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapToStation;
    [FieldOffset(0)]
    public Entity FollowerTarget;
    [FieldOffset(8)]
    public bool MapToStation;

    static NewUnitTag()
    {
      Il2CppClassPointerStore<NewUnitTag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (NewUnitTag));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewUnitTag>.NativeClassPtr);
      NewUnitTag.NativeFieldInfoPtr_FollowerTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewUnitTag>.NativeClassPtr, nameof (FollowerTarget));
      NewUnitTag.NativeFieldInfoPtr_MapToStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewUnitTag>.NativeClassPtr, nameof (MapToStation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NewUnitTag>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
