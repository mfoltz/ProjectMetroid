// Decompiled with JetBrains decompiler
// Type: ProjectM.DetectedEntity
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DetectedEntity
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsAggroable;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsAiPointOfInterest;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public float3 Position;
    [FieldOffset(20)]
    public float Radius;
    [FieldOffset(24)]
    public Team Team;
    [FieldOffset(32)]
    public bool IsDead;
    [FieldOffset(33)]
    public bool IsAggroable;
    [FieldOffset(34)]
    public bool HasTeam;
    [FieldOffset(35)]
    public bool IsAiPointOfInterest;

    static DetectedEntity()
    {
      Il2CppClassPointerStore<DetectedEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DetectedEntity));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetectedEntity>.NativeClassPtr);
      DetectedEntity.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectedEntity>.NativeClassPtr, nameof (Entity));
      DetectedEntity.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectedEntity>.NativeClassPtr, nameof (Position));
      DetectedEntity.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectedEntity>.NativeClassPtr, nameof (Radius));
      DetectedEntity.NativeFieldInfoPtr_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectedEntity>.NativeClassPtr, nameof (Team));
      DetectedEntity.NativeFieldInfoPtr_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectedEntity>.NativeClassPtr, nameof (IsDead));
      DetectedEntity.NativeFieldInfoPtr_IsAggroable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectedEntity>.NativeClassPtr, nameof (IsAggroable));
      DetectedEntity.NativeFieldInfoPtr_HasTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectedEntity>.NativeClassPtr, nameof (HasTeam));
      DetectedEntity.NativeFieldInfoPtr_IsAiPointOfInterest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectedEntity>.NativeClassPtr, nameof (IsAiPointOfInterest));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DetectedEntity>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
