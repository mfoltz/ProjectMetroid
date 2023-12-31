// Decompiled with JetBrains decompiler
// Type: ProjectM.CastResult
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
  public struct CastResult
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceSquared;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsAggroable;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsAiPointOfInterest;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public float DistanceSquared;
    [FieldOffset(12)]
    public float3 EntityPosition;
    [FieldOffset(24)]
    public Team Team;
    [FieldOffset(32)]
    public bool IsAggroable;
    [FieldOffset(33)]
    public bool HasTeam;
    [FieldOffset(34)]
    public bool IsAiPointOfInterest;

    static CastResult()
    {
      Il2CppClassPointerStore<CastResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CastResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastResult>.NativeClassPtr);
      CastResult.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastResult>.NativeClassPtr, nameof (Entity));
      CastResult.NativeFieldInfoPtr_DistanceSquared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastResult>.NativeClassPtr, nameof (DistanceSquared));
      CastResult.NativeFieldInfoPtr_EntityPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastResult>.NativeClassPtr, nameof (EntityPosition));
      CastResult.NativeFieldInfoPtr_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastResult>.NativeClassPtr, nameof (Team));
      CastResult.NativeFieldInfoPtr_IsAggroable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastResult>.NativeClassPtr, nameof (IsAggroable));
      CastResult.NativeFieldInfoPtr_HasTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastResult>.NativeClassPtr, nameof (HasTeam));
      CastResult.NativeFieldInfoPtr_IsAiPointOfInterest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastResult>.NativeClassPtr, nameof (IsAiPointOfInterest));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastResult>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
