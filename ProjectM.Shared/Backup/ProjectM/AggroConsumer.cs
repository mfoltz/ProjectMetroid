// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroConsumer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AggroConsumer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ProximityRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProximityWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetSwitchThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlertDecayPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreCombatPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistanceFromPreCombatPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlertTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeaggroReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_Active;
    [FieldOffset(0)]
    public float ProximityRadius;
    [FieldOffset(4)]
    public float ProximityWeight;
    [FieldOffset(8)]
    public float DamageWeight;
    [FieldOffset(12)]
    public float RemoveDelay;
    [FieldOffset(16)]
    public float TargetSwitchThreshold;
    [FieldOffset(20)]
    public float AlertDecayPerSecond;
    [FieldOffset(24)]
    public float3 PreCombatPosition;
    [FieldOffset(36)]
    public float MaxDistanceFromPreCombatPosition;
    [FieldOffset(40)]
    public NetworkedEntity AggroTarget;
    [FieldOffset(52)]
    public NetworkedEntity AlertTarget;
    [FieldOffset(64)]
    public AggroReason AggroReason;
    [FieldOffset(68)]
    public DeaggroReason DeaggroReason;
    [FieldOffset(72)]
    public ModifiableBool Active;

    static AggroConsumer()
    {
      Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AggroConsumer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr);
      AggroConsumer.NativeFieldInfoPtr_ProximityRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, nameof (ProximityRadius));
      AggroConsumer.NativeFieldInfoPtr_ProximityWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, nameof (ProximityWeight));
      AggroConsumer.NativeFieldInfoPtr_DamageWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, nameof (DamageWeight));
      AggroConsumer.NativeFieldInfoPtr_RemoveDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, nameof (RemoveDelay));
      AggroConsumer.NativeFieldInfoPtr_TargetSwitchThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, nameof (TargetSwitchThreshold));
      AggroConsumer.NativeFieldInfoPtr_AlertDecayPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, nameof (AlertDecayPerSecond));
      AggroConsumer.NativeFieldInfoPtr_PreCombatPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, nameof (PreCombatPosition));
      AggroConsumer.NativeFieldInfoPtr_MaxDistanceFromPreCombatPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, nameof (MaxDistanceFromPreCombatPosition));
      AggroConsumer.NativeFieldInfoPtr_AggroTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, nameof (AggroTarget));
      AggroConsumer.NativeFieldInfoPtr_AlertTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, nameof (AlertTarget));
      AggroConsumer.NativeFieldInfoPtr_AggroReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, nameof (AggroReason));
      AggroConsumer.NativeFieldInfoPtr_DeaggroReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, nameof (DeaggroReason));
      AggroConsumer.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, nameof (Active));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroConsumer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
