// Decompiled with JetBrains decompiler
// Type: ProjectM.Script_Buff_MoveToBusStop_DataServer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Buff_MoveToBusStop_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BusStopName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed_Base;
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed_Variation;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxOffsetDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyDistanceSq;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDestroyBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_PatrolEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastWaypointPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    [FieldOffset(0)]
    public FixedString32 BusStopName;
    [FieldOffset(32)]
    public float Speed_Base;
    [FieldOffset(36)]
    public float Speed_Variation;
    [FieldOffset(40)]
    public float MaxOffsetDistance;
    [FieldOffset(44)]
    public float DestroyDistanceSq;
    [FieldOffset(48)]
    public PrefabGUID TargetDestroyBuff;
    [FieldOffset(52)]
    public Entity PatrolEntity;
    [FieldOffset(60)]
    public float2 LastWaypointPosition;
    [FieldOffset(68)]
    public Script_Buff_MoveToBusStop_State State;

    static Script_Buff_MoveToBusStop_DataServer()
    {
      Il2CppClassPointerStore<Script_Buff_MoveToBusStop_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Script_Buff_MoveToBusStop_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_MoveToBusStop_DataServer>.NativeClassPtr);
      Script_Buff_MoveToBusStop_DataServer.NativeFieldInfoPtr_BusStopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop_DataServer>.NativeClassPtr, nameof (BusStopName));
      Script_Buff_MoveToBusStop_DataServer.NativeFieldInfoPtr_Speed_Base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop_DataServer>.NativeClassPtr, nameof (Speed_Base));
      Script_Buff_MoveToBusStop_DataServer.NativeFieldInfoPtr_Speed_Variation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop_DataServer>.NativeClassPtr, nameof (Speed_Variation));
      Script_Buff_MoveToBusStop_DataServer.NativeFieldInfoPtr_MaxOffsetDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop_DataServer>.NativeClassPtr, nameof (MaxOffsetDistance));
      Script_Buff_MoveToBusStop_DataServer.NativeFieldInfoPtr_DestroyDistanceSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop_DataServer>.NativeClassPtr, nameof (DestroyDistanceSq));
      Script_Buff_MoveToBusStop_DataServer.NativeFieldInfoPtr_TargetDestroyBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop_DataServer>.NativeClassPtr, nameof (TargetDestroyBuff));
      Script_Buff_MoveToBusStop_DataServer.NativeFieldInfoPtr_PatrolEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop_DataServer>.NativeClassPtr, nameof (PatrolEntity));
      Script_Buff_MoveToBusStop_DataServer.NativeFieldInfoPtr_LastWaypointPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop_DataServer>.NativeClassPtr, nameof (LastWaypointPosition));
      Script_Buff_MoveToBusStop_DataServer.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_MoveToBusStop_DataServer>.NativeClassPtr, nameof (State));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Buff_MoveToBusStop_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
