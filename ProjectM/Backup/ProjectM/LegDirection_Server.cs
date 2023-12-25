﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.LegDirection_Server
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LegDirection_Server
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FullSpeedAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinSpeedAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinSpeedMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpeedModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyUserCharacterRotation;
    [FieldOffset(0)]
    public float RotationSpeed;
    [FieldOffset(4)]
    public float FullSpeedAngle;
    [FieldOffset(8)]
    public float MinSpeedAngle;
    [FieldOffset(12)]
    public float MinSpeedMultiplier;
    [FieldOffset(16)]
    public ModificationId SpeedModId;
    [FieldOffset(20)]
    public bool OnlyUserCharacterRotation;

    static LegDirection_Server()
    {
      Il2CppClassPointerStore<LegDirection_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (LegDirection_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegDirection_Server>.NativeClassPtr);
      LegDirection_Server.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegDirection_Server>.NativeClassPtr, nameof (RotationSpeed));
      LegDirection_Server.NativeFieldInfoPtr_FullSpeedAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegDirection_Server>.NativeClassPtr, nameof (FullSpeedAngle));
      LegDirection_Server.NativeFieldInfoPtr_MinSpeedAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegDirection_Server>.NativeClassPtr, nameof (MinSpeedAngle));
      LegDirection_Server.NativeFieldInfoPtr_MinSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegDirection_Server>.NativeClassPtr, nameof (MinSpeedMultiplier));
      LegDirection_Server.NativeFieldInfoPtr_SpeedModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegDirection_Server>.NativeClassPtr, nameof (SpeedModId));
      LegDirection_Server.NativeFieldInfoPtr_OnlyUserCharacterRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegDirection_Server>.NativeClassPtr, nameof (OnlyUserCharacterRotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LegDirection_Server>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
