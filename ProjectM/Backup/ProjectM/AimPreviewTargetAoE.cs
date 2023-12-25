﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.AimPreviewTargetAoE
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AimPreviewTargetAoE
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ArcSequenceGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArcSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CircleSequenceGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CircleSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowArc;
    [FieldOffset(0)]
    public SequenceGUID ArcSequenceGUID;
    [FieldOffset(4)]
    public SequenceState ArcSequenceState;
    [FieldOffset(12)]
    public SequenceGUID CircleSequenceGUID;
    [FieldOffset(16)]
    public SequenceState CircleSequenceState;
    [FieldOffset(24)]
    public bool ShowArc;

    static AimPreviewTargetAoE()
    {
      Il2CppClassPointerStore<AimPreviewTargetAoE>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AimPreviewTargetAoE));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AimPreviewTargetAoE>.NativeClassPtr);
      AimPreviewTargetAoE.NativeFieldInfoPtr_ArcSequenceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewTargetAoE>.NativeClassPtr, nameof (ArcSequenceGUID));
      AimPreviewTargetAoE.NativeFieldInfoPtr_ArcSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewTargetAoE>.NativeClassPtr, nameof (ArcSequenceState));
      AimPreviewTargetAoE.NativeFieldInfoPtr_CircleSequenceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewTargetAoE>.NativeClassPtr, nameof (CircleSequenceGUID));
      AimPreviewTargetAoE.NativeFieldInfoPtr_CircleSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewTargetAoE>.NativeClassPtr, nameof (CircleSequenceState));
      AimPreviewTargetAoE.NativeFieldInfoPtr_ShowArc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewTargetAoE>.NativeClassPtr, nameof (ShowArc));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AimPreviewTargetAoE>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
