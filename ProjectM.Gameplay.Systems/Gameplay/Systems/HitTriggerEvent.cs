﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.HitTriggerEvent
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HitTriggerEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    [FieldOffset(0)]
    public Entity Entity;

    static HitTriggerEvent()
    {
      Il2CppClassPointerStore<HitTriggerEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (HitTriggerEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitTriggerEvent>.NativeClassPtr);
      HitTriggerEvent.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitTriggerEvent>.NativeClassPtr, nameof (Entity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HitTriggerEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
