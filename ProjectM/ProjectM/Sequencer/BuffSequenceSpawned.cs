﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.BuffSequenceSpawned
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BuffSequenceSpawned
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceGuid;
    [FieldOffset(0)]
    public Entity SequenceInstance;
    [FieldOffset(8)]
    public BlobAssetReference<ConditionBlob> Condition;
    [FieldOffset(16)]
    public SequenceGUID SequenceGuid;

    static BuffSequenceSpawned()
    {
      Il2CppClassPointerStore<BuffSequenceSpawned>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (BuffSequenceSpawned));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffSequenceSpawned>.NativeClassPtr);
      BuffSequenceSpawned.NativeFieldInfoPtr_SequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSpawned>.NativeClassPtr, nameof (SequenceInstance));
      BuffSequenceSpawned.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSpawned>.NativeClassPtr, nameof (Condition));
      BuffSequenceSpawned.NativeFieldInfoPtr_SequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSpawned>.NativeClassPtr, nameof (SequenceGuid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffSequenceSpawned>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
