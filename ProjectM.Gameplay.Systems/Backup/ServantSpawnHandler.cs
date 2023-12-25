// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantSpawnHandler
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
  public struct ServantSpawnHandler
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StationEntity;
    [FieldOffset(0)]
    public Entity StationEntity;

    static ServantSpawnHandler()
    {
      Il2CppClassPointerStore<ServantSpawnHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (ServantSpawnHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantSpawnHandler>.NativeClassPtr);
      ServantSpawnHandler.NativeFieldInfoPtr_StationEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSpawnHandler>.NativeClassPtr, nameof (StationEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantSpawnHandler>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
