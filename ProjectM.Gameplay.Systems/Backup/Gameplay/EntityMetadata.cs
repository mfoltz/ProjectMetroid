// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.EntityMetadata
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EntityMetadata
  {
    static EntityMetadata()
    {
      Il2CppClassPointerStore<EntityMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay", nameof (EntityMetadata));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityMetadata>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityMetadata>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
