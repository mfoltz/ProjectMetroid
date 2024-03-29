﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleRoomEvent
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleRoomEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RoomEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Merged;
    [FieldOffset(0)]
    public Entity RoomEntity;
    [FieldOffset(8)]
    public CastleRoomEventType EventType;
    [FieldOffset(12)]
    public bool Merged;

    static CastleRoomEvent()
    {
      Il2CppClassPointerStore<CastleRoomEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding", nameof (CastleRoomEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRoomEvent>.NativeClassPtr);
      CastleRoomEvent.NativeFieldInfoPtr_RoomEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoomEvent>.NativeClassPtr, nameof (RoomEntity));
      CastleRoomEvent.NativeFieldInfoPtr_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoomEvent>.NativeClassPtr, nameof (EventType));
      CastleRoomEvent.NativeFieldInfoPtr_Merged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoomEvent>.NativeClassPtr, nameof (Merged));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRoomEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
