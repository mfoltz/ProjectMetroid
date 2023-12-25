// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.AbilityThrowTowardsEventHitTarget_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityThrowTowardsEventHitTarget_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomHitRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewThrowEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetStartPositionToTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnOffset;
    [FieldOffset(0)]
    public float RandomHitRadius;
    [FieldOffset(4)]
    public PrefabGUID NewThrowEntity;
    [FieldOffset(8)]
    public int Count;
    [FieldOffset(12)]
    public bool SetStartPositionToTarget;
    [FieldOffset(16)]
    public float3 SpawnOffset;

    static AbilityThrowTowardsEventHitTarget_DataServer()
    {
      Il2CppClassPointerStore<AbilityThrowTowardsEventHitTarget_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (AbilityThrowTowardsEventHitTarget_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityThrowTowardsEventHitTarget_DataServer>.NativeClassPtr);
      AbilityThrowTowardsEventHitTarget_DataServer.NativeFieldInfoPtr_RandomHitRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityThrowTowardsEventHitTarget_DataServer>.NativeClassPtr, nameof (RandomHitRadius));
      AbilityThrowTowardsEventHitTarget_DataServer.NativeFieldInfoPtr_NewThrowEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityThrowTowardsEventHitTarget_DataServer>.NativeClassPtr, nameof (NewThrowEntity));
      AbilityThrowTowardsEventHitTarget_DataServer.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityThrowTowardsEventHitTarget_DataServer>.NativeClassPtr, nameof (Count));
      AbilityThrowTowardsEventHitTarget_DataServer.NativeFieldInfoPtr_SetStartPositionToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityThrowTowardsEventHitTarget_DataServer>.NativeClassPtr, nameof (SetStartPositionToTarget));
      AbilityThrowTowardsEventHitTarget_DataServer.NativeFieldInfoPtr_SpawnOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityThrowTowardsEventHitTarget_DataServer>.NativeClassPtr, nameof (SpawnOffset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityThrowTowardsEventHitTarget_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
