// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.AoETarget
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AoETarget
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImportanceGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasHealth;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public float Importance;
    [FieldOffset(12)]
    public float3 Position;
    [FieldOffset(24)]
    public int ImportanceGroup;
    [FieldOffset(28)]
    public bool HasHealth;

    static AoETarget()
    {
      Il2CppClassPointerStore<AoETarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (AoETarget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AoETarget>.NativeClassPtr);
      AoETarget.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoETarget>.NativeClassPtr, nameof (Entity));
      AoETarget.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoETarget>.NativeClassPtr, nameof (Importance));
      AoETarget.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoETarget>.NativeClassPtr, nameof (Position));
      AoETarget.NativeFieldInfoPtr_ImportanceGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoETarget>.NativeClassPtr, nameof (ImportanceGroup));
      AoETarget.NativeFieldInfoPtr_HasHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AoETarget>.NativeClassPtr, nameof (HasHealth));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AoETarget>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
