// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.MaterialChangeEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MaterialChangeEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialAssetIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_RendererMask;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShadowCastingMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyNormalMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyBaseMap;
    [FieldOffset(0)]
    public int NodeIndex;
    [FieldOffset(4)]
    public BlackboardParameterRuntime TargetParameter;
    [FieldOffset(8)]
    public int MaterialAssetIndex;
    [FieldOffset(12)]
    public int RendererMask;
    [FieldOffset(16)]
    public int Importance;
    [FieldOffset(20)]
    public ShadowCastingMode ShadowCastingMode;
    [FieldOffset(24)]
    public bool CopyNormalMap;
    [FieldOffset(25)]
    public bool CopyBaseMap;

    static MaterialChangeEvent()
    {
      Il2CppClassPointerStore<MaterialChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (MaterialChangeEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeEvent>.NativeClassPtr);
      MaterialChangeEvent.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEvent>.NativeClassPtr, nameof (NodeIndex));
      MaterialChangeEvent.NativeFieldInfoPtr_TargetParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEvent>.NativeClassPtr, nameof (TargetParameter));
      MaterialChangeEvent.NativeFieldInfoPtr_MaterialAssetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEvent>.NativeClassPtr, nameof (MaterialAssetIndex));
      MaterialChangeEvent.NativeFieldInfoPtr_RendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEvent>.NativeClassPtr, nameof (RendererMask));
      MaterialChangeEvent.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEvent>.NativeClassPtr, nameof (Importance));
      MaterialChangeEvent.NativeFieldInfoPtr_ShadowCastingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEvent>.NativeClassPtr, nameof (ShadowCastingMode));
      MaterialChangeEvent.NativeFieldInfoPtr_CopyNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEvent>.NativeClassPtr, nameof (CopyNormalMap));
      MaterialChangeEvent.NativeFieldInfoPtr_CopyBaseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeEvent>.NativeClassPtr, nameof (CopyBaseMap));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialChangeEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
