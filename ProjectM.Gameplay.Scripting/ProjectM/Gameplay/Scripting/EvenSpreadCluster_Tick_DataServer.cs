// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.EvenSpreadCluster_Tick_DataServer
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
  public struct EvenSpreadCluster_Tick_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationPerTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksDone;
    private static readonly System.IntPtr NativeFieldInfoPtr_IndividualRandom;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseAimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseSelfRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseAIReturnPosAsOrigo;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysMaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_FullCircleSpread;
    [FieldOffset(0)]
    public float OffsetAngle;
    [FieldOffset(4)]
    public float RandomAngle;
    [FieldOffset(8)]
    public float RotationPerTick;
    [FieldOffset(12)]
    public int Count;
    [FieldOffset(16)]
    public int TicksDone;
    [FieldOffset(20)]
    public bool IndividualRandom;
    [FieldOffset(21)]
    public bool UseAimDirection;
    [FieldOffset(22)]
    public bool UseSelfRotation;
    [FieldOffset(23)]
    public bool UseAIReturnPosAsOrigo;
    [FieldOffset(24)]
    public bool AlwaysMaxRange;
    [FieldOffset(28)]
    public float3 SpawnOffset;
    [FieldOffset(40)]
    public bool IgnoreCollision;
    [FieldOffset(41)]
    public bool FullCircleSpread;

    static EvenSpreadCluster_Tick_DataServer()
    {
      Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (EvenSpreadCluster_Tick_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr);
      EvenSpreadCluster_Tick_DataServer.NativeFieldInfoPtr_OffsetAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, nameof (OffsetAngle));
      EvenSpreadCluster_Tick_DataServer.NativeFieldInfoPtr_RandomAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, nameof (RandomAngle));
      EvenSpreadCluster_Tick_DataServer.NativeFieldInfoPtr_RotationPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, nameof (RotationPerTick));
      EvenSpreadCluster_Tick_DataServer.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, nameof (Count));
      EvenSpreadCluster_Tick_DataServer.NativeFieldInfoPtr_TicksDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, nameof (TicksDone));
      EvenSpreadCluster_Tick_DataServer.NativeFieldInfoPtr_IndividualRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, nameof (IndividualRandom));
      EvenSpreadCluster_Tick_DataServer.NativeFieldInfoPtr_UseAimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, nameof (UseAimDirection));
      EvenSpreadCluster_Tick_DataServer.NativeFieldInfoPtr_UseSelfRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, nameof (UseSelfRotation));
      EvenSpreadCluster_Tick_DataServer.NativeFieldInfoPtr_UseAIReturnPosAsOrigo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, nameof (UseAIReturnPosAsOrigo));
      EvenSpreadCluster_Tick_DataServer.NativeFieldInfoPtr_AlwaysMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, nameof (AlwaysMaxRange));
      EvenSpreadCluster_Tick_DataServer.NativeFieldInfoPtr_SpawnOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, nameof (SpawnOffset));
      EvenSpreadCluster_Tick_DataServer.NativeFieldInfoPtr_IgnoreCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, nameof (IgnoreCollision));
      EvenSpreadCluster_Tick_DataServer.NativeFieldInfoPtr_FullCircleSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, nameof (FullCircleSpread));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EvenSpreadCluster_Tick_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
