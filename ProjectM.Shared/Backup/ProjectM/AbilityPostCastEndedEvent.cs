﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityPostCastEndedEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityPostCastEndedEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Character;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_WasInterrupted;
    [FieldOffset(0)]
    public Entity Character;
    [FieldOffset(8)]
    public Entity Ability;
    [FieldOffset(16)]
    public Entity AbilityGroup;
    [FieldOffset(24)]
    public bool WasInterrupted;

    static AbilityPostCastEndedEvent()
    {
      Il2CppClassPointerStore<AbilityPostCastEndedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityPostCastEndedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityPostCastEndedEvent>.NativeClassPtr);
      AbilityPostCastEndedEvent.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPostCastEndedEvent>.NativeClassPtr, nameof (Character));
      AbilityPostCastEndedEvent.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPostCastEndedEvent>.NativeClassPtr, nameof (Ability));
      AbilityPostCastEndedEvent.NativeFieldInfoPtr_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPostCastEndedEvent>.NativeClassPtr, nameof (AbilityGroup));
      AbilityPostCastEndedEvent.NativeFieldInfoPtr_WasInterrupted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityPostCastEndedEvent>.NativeClassPtr, nameof (WasInterrupted));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityPostCastEndedEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
